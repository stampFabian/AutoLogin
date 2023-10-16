using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using DatabaseManager;
using System;


namespace AutoLogin
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
            
            // Opens the database connection
            DbManager.openConnection();
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
            string tableName = "users_table"; // Replace with your actual table name
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
            finally
            {
                // Close the database connection
                DbManager.closeConnection();
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }
    }
}