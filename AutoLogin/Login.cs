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
            DbManager.uname = "adam";
            DbManager.psw = "Test1!";
            DbManager.convertToConStrg(false);
            //DbManager.openConnection();
        }

        public void buttonLogin_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Dashboard dashboard1 = new Dashboard();           
            dashboard1.Show();


        }
    }
}