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

                if (dataTable.Rows.Count > 0) // Überprüfe, ob Daten vorhanden sind
                {
                    dataGrid1.DataSource = dataTable;

                    string username = dataTable.Rows[0]["username"].ToString();
                    accNameLbl.Text = username;
                }
                else
                {
                    // Keine Daten vorhanden, zeige eine entsprechende Meldung an oder handle den Fall
                    MessageBox.Show("Keine Daten gefunden.", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Fehler: " + ex.Message, @"Fehler beim Abrufen der Daten");
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
            string type = tbType.Text;
            string info = tbInfo.Text;
            string email = tbEmail.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            
            //insert details into table
            
            string tableName = "accounts_table";
            string query = $"INSERT INTO {tableName}(type, info, email, username, password, uid) VALUES('{type}', '{info}', '{email}', '{username}', '{password}', '{Login.uid}')";
            
            //execute query
            try
            {
                DbManager.openConnection();
                //DbManager.addDataToTable("TALBE NAME", "LISTE AN COLUMNS", "LISTE AN VALUES");
                
                
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
    }
}