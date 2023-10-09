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
                    //Refer to login form
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
    }
}
