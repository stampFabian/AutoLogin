using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DatabaseManager;
using MySql.Data.MySqlClient;

namespace AutoLogin
{
    public partial class Dashboard : Form
    {
        public string username;
        public List<Account> accounts = new List<Account>();
        public static string accName = "";
        public static string accPsw = "";
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
            string query = $"SELECT * FROM {tableName} where uid = '{Login.uid}'";

            try
            {
                // Create a MySqlCommand and MySqlDataAdapter
                MySqlCommand command = new MySqlCommand(query, DbManager.activeCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                accounts.Clear();

                // add item to combobox for each account
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dataTable.Rows[i]["type"].ToString() + " / " + dataTable.Rows[i]["info"].ToString());
                    accounts.Add(new Account(Int32.Parse(dataTable.Rows[i]["accid"].ToString()),dataTable.Rows[i]["type"].ToString(), dataTable.Rows[i]["info"].ToString(), dataTable.Rows[i]["email"].ToString(), dataTable.Rows[i]["username"].ToString(), dataTable.Rows[i]["password"].ToString(), dataTable.Rows[i]["link"].ToString(), Int32.Parse(dataTable.Rows[i]["uid"].ToString())));
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

        private void dashboard_button_login_Click(object sender, EventArgs e)
        {
            //Get Link from selected account and open it in default browser
            System.Diagnostics.Process.Start(accounts[comboBox1.SelectedIndex - 1].link);
            accName = accounts[comboBox1.SelectedIndex - 1].username;
            accPsw = accounts[comboBox1.SelectedIndex - 1].password;
            Clipboard.SetText(" ");
        }

        private void button1_Click(object sender, EventArgs e){
            this.Hide();
            Login login1 = new Login();
            login1.Show();
        }
    }
}