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
using MySql.Data.MySqlClient;

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
                labelRegisterPasswordWrong.Visible = false;
                //Check if password is strong enough
                //Must contain at least 8 characters, 1 uppercase letter, 1 lowercase letter, 1 number and 1 special character
                if (textBoxRegisterPassword.Text.Length < 8)
                {
                    labelRegisterPasswordSafety.Visible = true;
                    return;
                }
                else
                {
                    labelRegisterPasswordSafety.Visible = false;
                }
                bool hasUpperCase = false;
                bool hasLowerCase = false;
                bool hasNumber = false;
                bool hasSpecialChar = false;
                
                foreach (char c in textBoxRegisterPassword.Text)
                {
                    if (char.IsUpper(c))
                    {
                        hasUpperCase = true;
                    }
                    else if (char.IsLower(c))
                    {
                        hasLowerCase = true;
                    }
                    else if (char.IsDigit(c))
                    {
                        hasNumber = true;
                    }
                    else if (char.IsSymbol(c) || char.IsPunctuation(c))
                    {
                        hasSpecialChar = true;
                    }
                }
                if (!hasUpperCase || !hasLowerCase || !hasNumber || !hasSpecialChar)
                {
                    labelRegisterPasswordSafety.Visible = true;
                    return;
                }
                else
                {
                    labelRegisterPasswordSafety.Visible = false;
                }
                //Check if email already exists in users_table
                 string query = "SELECT * FROM users_table WHERE email = '" + textBoxRegisterEmail.Text + "'";
                 MySqlCommand command = new MySqlCommand(query, DbManager.activeCon);
                 
                 //Check if username already exists in users_table
                 if(command.ExecuteScalar() != null)
                 {
                     labelRegisterEmailExists.Visible = true;
                     return;
                 } else
                 {
                     labelRegisterEmailExists.Visible = false;
                 }
                 
                
                if (DbManager.addDataToPswTable("users_table", textBoxRegisterUsername.Text, textBoxRegisterPassword.Text, textBoxRegisterEmail.Text))
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

        private void labelRegisterEmailExists_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e){
            this.Hide();
            Login login1 = new Login();
            login1.Show();
        }
    }
}
