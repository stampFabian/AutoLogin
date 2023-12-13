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
            // Execute a SQL query to fetch data, replace 'YourTableName' with your actual table name
            string tableName = "accounts_table"; // Replace with your actual table name
            string query = $"SELECT * FROM {tableName} where uid = '{Login.uid}'";

            try
            {
                MySqlCommand command = new MySqlCommand(query, DbManager.activeCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0) // checks if any data was returned
                {
                    dataGrid1.DataSource = dataTable;

                    string username = dataTable.Rows[0]["username"].ToString();
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

        private void undoBtn_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (tbUsername != null)
            {
                tbUsername.Visible = true;
                tbEmail.Visible = false;
            }
            else
            {
                tbEmail.Visible = true;
                tbUsername.Visible = false;
            }
            
            string type;

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
            string query = $"INSERT INTO {tableName}(type, info, email, username, password, link, uid) VALUES('{type}', '{info}', '{email}', '{username}', '{password}' , '{link}' , '{Login.uid}')";
            
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

        private void AccountManager_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void gB1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            ControlPaint.DrawBorder(e.Graphics, this.gB1.ClientRectangle, Color.Transparent, ButtonBorderStyle.Solid);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void DIY_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            tbType.Visible = true;
            cB_template.Visible = false;
            tbLink.Text = "";
        }

        private void template_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            cB_template.Visible = true;
            tbType.Visible = false;
        }

        private void cB_template_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cB_template.SelectedItem.ToString();

            switch (selected)
            {
                case "Google":
                    tbLink.Text = "https://accounts.google.com/signin/v2/identifier?hl=en&passive=true&continue=https%3A%2F%2Fwww.google.com%2F&ec=GAZAAQ&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
                    tbEmail.Visible = true;
                    tbUsername.Visible = false;
                    break;
                case "Microsoft":
                    tbLink.Text = "https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1620237113&rver=7.3.6963.0&wp=MBI_SSL&wreply=https%3a%2f%2fwww.microsoft.com%2fen-us%2f&lc=1033&id=74335&aadredir=1";
                    tbEmail.Visible = true;
                    tbUsername.Visible = false;
                    break;
                case "Github":
                    tbLink.Text = "https://github.com/login";
                    tbEmail.Visible = true;
                    tbUsername.Visible = false;
                    break;
                case "\ud835\udd4f":
                    tbLink.Text = "https://twitter.com/i/flow/login";
                    tbEmail.Visible = true;
                    tbUsername.Visible = true;
                    break;
            }
        }
    }
}