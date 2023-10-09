using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManager;

namespace AutoLogin
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegisterSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxRegisterPassword.Text.Equals(textBoxRegisterPasswordCheck.Text))
            {
                if (DbManager.addDataToPswTable("users_table", textBoxRegisterUsername.Text, textBoxRegisterPassword.Text))
                {
                    MessageBox.Show("Account created!");
                    this.Hide();
                    Login login1 = new Login();
                    login1.Show();
                }
                else
                {
                    MessageBox.Show("Account creation failed!");
                }
            }
            else
            {
                labelRegisterPasswordWrong.Visible = true;
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
