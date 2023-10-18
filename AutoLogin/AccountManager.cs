using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using DatabaseManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AutoLogin
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();           
            dashboard.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Execute a SQL query to fetch data, replace 'YourTableName' with your actual table name
            string tableName = "accounts_table"; // Replace with your actual table name
            string query = $"SELECT * FROM {tableName}";

            try
            {
                // Create a MySqlCommand and MySqlDataAdapter
                MySqlCommand command = new MySqlCommand(query, DbManager.activeCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with data from the database
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGrid1.DataSource = dataTable;

                
                // Changes the name of the label to the username
                // Get the current username from the database
                string username = dataTable.Rows[0]["username"].ToString();

                // Rename the btnRefresh button to the username
                accNameLbl.Text = username;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error fetching data");
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            List<string> columns = new List<string>();
            columns.Add("type");
            columns.Add("info");
            columns.Add("email");
            columns.Add("username");
            columns.Add("password");
            
            List<string> values = new List<string>();
            values.Add(tbType.Text);
            values.Add(tbInfo.Text);
            values.Add(tbEmail.Text);
            values.Add(tbUsername.Text);
            values.Add(tbPassword.Text);
            
            //insert details into table
            
            string tableName = "accounts_table";
            
            //execute query
            
            bool task1 = await DbManager.addDataToTable(tableName, columns, values);

            if (task1)
            {
                MessageBox.Show(@"Account added successfully", @"Success");
            }
            
            // Refresh the data grid
            btnRefresh_Click(sender, e);
        }
    }
}