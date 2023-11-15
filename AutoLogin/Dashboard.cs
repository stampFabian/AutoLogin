using System;
using System.Data;
using System.Windows.Forms;
using DatabaseManager;
using MySql.Data.MySqlClient;

namespace AutoLogin
{
    public partial class Dashboard : Form
    {
        public string username;
        public Dashboard()
        {
            InitializeComponent();
            this.username = Login.username;
            dashboard_lbl_username.Text = "Hello " + username;
            comboBox1.Items.Add("Add new Account");
            refresh();
        }

        private async void refresh()
        {
            // Execute a SQL query to fetch data, replace 'YourTableName' with your actual table name
            string tableName = "accounts_table"; // Replace with your actual table name
            string query = $"SELECT * FROM {tableName} where username = '{username}'";

            try
            {
                // Create a MySqlCommand and MySqlDataAdapter
                MySqlCommand command = new MySqlCommand(query, DbManager.activeCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // add item to combobox for each account
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dataTable.Rows[i]["type"].ToString() + " / " + dataTable.Rows[i]["info"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error fetching data");
            }
            finally
            {
                DbManager.closeConnection();
            }
        }
        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dashboard_button_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountManager AccountManager = new AccountManager();           
            AccountManager.Show();
        }

        private void dashboard_lbl_username_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Add new Account")
            {
                this.Hide();
                AccountManager AccountManager = new AccountManager();
                AccountManager.Show();
            }
        }
    }
}