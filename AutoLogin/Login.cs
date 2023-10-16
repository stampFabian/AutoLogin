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
        public DbManager dbm = new DbManager();
        public static string username = "";
        public Login()
        {
            InitializeComponent();
            temp();
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
            bool tableAccExists = await DbManager.checkIfTableExists("account_table");
            
            if (!tableExists)
            {
                await DbManager.createPasswordTable("users_table", "uid", "username", "hashed_password");
            }

            if (!tableAccExists)
            {
                List<string> names = new List<string>();
                names.Add("id");
                names.Add("type");
                names.Add("info");
                names.Add("email");
                names.Add("username");
                names.Add("password");
                
                List<string> types = new List<string>();
                types.Add("INT");
                types.Add("VARCHAR(255)");
                types.Add("VARCHAR(255)");
                types.Add("VARCHAR(255)");
                types.Add("VARCHAR(255)");
                types.Add("VARCHAR(500)");
                
                List<string> cannull = new List<string>();
                cannull.Add("NOT NULL");
                cannull.Add("NOT NULL");
                cannull.Add("NOT NULL");
                cannull.Add("NOT NULL");
                cannull.Add("NOT NULL");
                cannull.Add("NOT NULL");
                
                await DbManager.createTable("account_table", names, types, cannull);
            }
        }

        public async void buttonLogin_Click(object sender, System.EventArgs e)
        {
            if (await DbManager.checkPasswordUser("users_table", textBoxUsername.Text, textBoxPassword.Text))
            {
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
    }
}