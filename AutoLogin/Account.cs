namespace AutoLogin
{
    public class Account
    {
        private int _accid;
        private string _type;
        private string _info;
        private string _email;
        private string _username;
        private string _password;
        private string _link;
        private int _uid;
        
        public int accid
        {
            get
            {
                return _accid;
            }
            set
            {
                _accid = value;
            }
        }
        
        public string type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        
        public string info
        {
            get
            {
                return _info;
            }
            set
            {
                _info = value;
            }
        }
        
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        
        public string link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
            }
        }
        
        public int uid
        {
            get
            {
                return _uid;
            }
            set
            {
                _uid = value;
            }
        }
        
        public Account(int accid, string type, string info, string email, string username, string password, string link, int uid)
        {
            this.accid = accid;
            this.type = type;
            this.info = info;
            this.email = email;
            this.username = username;
            this.password = password;
            this.link = link;
            this.uid = uid;
        }
    }
}