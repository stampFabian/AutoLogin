using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using DatabaseManager;
using System;
using System.Drawing;


namespace AutoLogin
{
    public partial class AccountManager : Form
    {
        string needForLogin = "email";
        public AccountManager()
        {
            InitializeComponent();
            
            // Opens the database connection
            DbManager.openConnection();
            refresh();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();           
            dashboard.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            // SQL query gets executed
            string tableName = "accounts_table"; // pay attention to the correct table name
            string query = $"SELECT * FROM {tableName} where uid = '{Login.uid}'";

            try
            {
                // Create a new MySQL command with the provided query and connection
                MySqlCommand command = new MySqlCommand(query, DbManager.activeCon);
                // Create a new MySQL data adapter to retrieve data from the database
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                // Create a new DataTable to store the retrieved data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the data received by the adapter
                adapter.Fill(dataTable);

                // Check if any data was returned
                if (dataTable.Rows.Count > 0)
                {
                    // If yes, set the data source of the data grid to the DataTable
                    dataGrid1.DataSource = dataTable;

                    // Get the username from the first row of the DataTable
                    string username = dataTable.Rows[0]["username"].ToString();
                    // Set the text of the label to greet the user
                    accNameLbl.Text = "Hello " + username;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error when retrieving the data");
            }
            finally
            {
                DbManager.closeConnection();
            }
        }

        // Add Account
        private void addBtn_Click(object sender, EventArgs e)
        {
            string type;

            // If template is visible, use the text from selected template
            // Otherwise use the text from DIY
            if (cB_template.Visible == true)
            {
                type = cB_template.Text;
            }
            else
            {
                type = tbType.Text;
            }
            
            string info = tbInfo.Text;
            string email = tbEmail.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string link = tbLink.Text;
            
            //insert details into table
            
            string tableName = "accounts_table";
            string query = $"INSERT INTO {tableName}(type, info, email, username, password, link, uid, needed_for_login) VALUES('{type}', '{info}', '{email}', '{username}', '{password}' , '{link}' , '{Login.uid}', '{needForLogin}')";
            
            //execute query
            try
            {
                DbManager.openConnection();
                
                MySqlCommand command = new MySqlCommand(query, DbManager.activeCon);
                MySqlDataReader reader = command.ExecuteReader();
                
                MessageBox.Show("Account added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error adding account");
            }
            finally
            {
                DbManager.closeConnection();
            }
            refresh();
        }

        private void AccountManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void gB1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            ControlPaint.DrawBorder(e.Graphics, this.gB1.ClientRectangle, Color.Transparent, ButtonBorderStyle.Solid);
        }

        // Radio Button DIY is checked
        private void DIY_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            tbType.Visible = true;
            cB_template.Visible = false;
            tbLink.Text = "";
            lblActivate.Visible = true;
            gB2.Visible = true;
            rBEmail.Visible = true;
            rBUsername.Visible = true;
        }

        // Radio Button Template is checked
        private void template_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            cB_template.Visible = true;
            tbType.Visible = false;
            lblActivate.Visible = false;
            gB2.Visible = false;
            rBEmail.Visible = false;
            rBUsername.Visible = false;

            if (cB_template.Text != "")
            {
                if (cB_template.Text == "Google")
                {
                    tbLink.Text = "https://accounts.google.com/signin/v2/identifier?hl=en&passive=true&continue=https%3A%2F%2Fwww.google.com%2F&ec=GAZAAQ&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
                }
                else if (cB_template.Text == "Microsoft")
                {
                    tbLink.Text = "https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1620237113&rver=7.3.6963.0&wp=MBI_SSL&wreply=https%3a%2f%2fwww.microsoft.com%2fen-us%2f&lc=1033&id=74335&aadredir=1";
                }
                else if (cB_template.Text == "Github")
                {
                    tbLink.Text = "https://github.com/login";
                }
                else if (cB_template.Text == "\ud835\udd4f")
                {
                    tbLink.Text = "https://twitter.com/i/flow/login";
                }
            }
        }

        // Template options
        private void cB_template_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cB_template.SelectedItem.ToString();
            
            tbEmail.Visible = true;
            tbUsername.Visible = true;

            // Login-link for each Website is automatically set
            switch (selected)
            {
                case "Google":
                    tbLink.Text = "https://accounts.google.com/signin/v2/identifier?hl=en&passive=true&continue=https%3A%2F%2Fwww.google.com%2F&ec=GAZAAQ&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
                    break;
                case "Microsoft":
                    tbLink.Text = "https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1620237113&rver=7.3.6963.0&wp=MBI_SSL&wreply=https%3a%2f%2fwww.microsoft.com%2fen-us%2f&lc=1033&id=74335&aadredir=1";
                    break;
                case "Github":
                    tbLink.Text = "https://github.com/login";
                    break;
                case "\ud835\udd4f":
                    tbLink.Text = "https://twitter.com/i/flow/login";
                    break;
            }
        }

        // Radio Button Email is checked
        private void rBEmail_CheckedChanged(object sender, EventArgs e)
        {
            needForLogin = "email";
        }

        // Radio Button Username is checked
        private void rBUsername_CheckedChanged(object sender, EventArgs e)
        {
            needForLogin = "username";
        }

        
        private void gB2_Paint(object sender, PaintEventArgs e){
            e.Graphics.Clear(this.BackColor);
            ControlPaint.DrawBorder(e.Graphics, this.gB1.ClientRectangle, Color.Transparent, ButtonBorderStyle.Solid);
        }

        private void lblActivate_Click(object sender, EventArgs e){
            throw new System.NotImplementedException();
        }
    }
}