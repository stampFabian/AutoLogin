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
            DbManager.openConnection();
        }
        

    }
}