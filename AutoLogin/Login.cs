using System;
using System.Windows.Forms;
using DatabaseManager;

namespace AutoLogin
{
    public partial class Login : Form
    {
        public DbManager dbm = new DbManager();
        public Login()
        {
            InitializeComponent();
            DbManager.server = "localhost";
            DbManager.database = "database";
            DbManager.uname = "root";
            DbManager.psw = "Test1!";
            DbManager.convertToConStrg(false);
            DbManager.openConnection();
            if (!DbManager.checkIfTableExists("users"))
            {
                DbManager.createPasswordTable("users", "uid", "username", "password");
            }

            
        }

        public void buttonLogin_Click(object sender, System.EventArgs e)
        {
            if (DbManager.checkPasswordUser("users", textBoxUsername.Text, textBoxPassword.Text))
            {
                this.Hide();
                Dashboard dashboard1 = new Dashboard();           
                dashboard1.Show();
            }
            else
            {
                labelError.Visible = true;
            }
            


        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonLoginRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register1 = new Register();
            register1.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}