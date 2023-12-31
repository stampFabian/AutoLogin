using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManager;

namespace AutoLogin
{
    public partial class Login : Form
    {
        private KeyboardHook keyboardHookInstance;
        public DbManager dbm = new DbManager();
        public static string username = "";
        public static int uid = 0;
        public Login()
        {
            InitializeComponent();
            //InitializeClipboardMonitor();
            InitializeKeyboardHook();
            temp();
        }
        private void InitializeKeyboardHook()
        {
            keyboardHookInstance = new KeyboardHook();
            KeyboardHook.SetHook();
        }
        public async void temp()
        {
            await InitializeAsync();
        }
        public async Task InitializeAsync()
        {

            DbManager.server = "localhost";
            DbManager.database = "database";
            DbManager.uname = "root";
            DbManager.psw = "Test1!";
            DbManager.convertToConStrg(false);
            await DbManager.openConnection();

            bool tableExists = await DbManager.checkIfTableExists("users_table");

            if (!tableExists)
            {
                List<string> columns = new List<string>();
                columns.Add("uid");
                columns.Add("username");
                columns.Add("hashed_password");
                
                await DbManager.createPasswordTable("users_table", "uid", "username", "hashed_password");
            }
            
            bool table2Exists = await DbManager.checkIfTableExists("accounts_table");
            if(!table2Exists)
            {
                List<string> names = new List<string>();
                names.Add("accid");
                names.Add("uid");
                names.Add("type");
                names.Add("info");
                names.Add("email");
                names.Add("username");
                names.Add("password");
                

                List<string> types = new List<string>();
                types.Add("INT auto_increment PRIMARY KEY");
                types.Add("INT");
                types.Add("VARCHAR(255)");
                types.Add("VARCHAR(255)");
                types.Add("VARCHAR(255)");
                types.Add("VARCHAR(255)");
                types.Add("VARCHAR(500)");
                

                List<string> canBeNull = new List<string>();
                canBeNull.Add("NOT NULL");
                canBeNull.Add("NOT NULL");
                canBeNull.Add("NOT NULL");
                canBeNull.Add("NOT NULL");
                canBeNull.Add("NOT NULL");
                canBeNull.Add("NOT NULL");
                canBeNull.Add("NOT NULL");
                
                await DbManager.createTable("accounts_table", names, types, canBeNull);
            }
        }

        public async void buttonLogin_Click(object sender, System.EventArgs e)
        {
            int uid2 = await DbManager.checkPasswordUser("users_table", textBoxUsername.Text, textBoxPassword.Text);
            if (uid2 != 0)
            {
                uid = uid2;
                this.Hide();
                username = textBoxUsername.Text;
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

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPW forgotPassword1 = new ForgotPW();
            forgotPassword1.Show();

        }
    }
}
