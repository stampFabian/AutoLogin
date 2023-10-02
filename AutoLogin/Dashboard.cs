using System;
using System.Windows.Forms;

namespace AutoLogin
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
    }
}