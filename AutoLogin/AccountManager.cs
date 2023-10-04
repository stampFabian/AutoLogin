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
            // TODO: refresh the data grid
            
            // Open the database connection
            

            // Execute a SQL query to fetch data, replace 'YourTableName' with your actual table name
            string tableName = "users"; // Replace with your actual table name
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
                
                //---------------------------------------------
                //test
                //---------------------------------------------

                //change the label to the username of the selected row
                
                
                
                
                //string username = dataTable.Rows[0].Cells[1].Value.ToString();
                //accNameLbl.Text = username;
                
                
                
                
                /*string username = dataTable.ToString();
                MessageBox.Show(username);
                    
                    //Instance.GetDataTable("users").Rows[0]["username"].ToString();
                accNameLbl.Name = username;
                */
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
    }
}