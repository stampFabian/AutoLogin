using System;
using System.Windows.Forms;

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