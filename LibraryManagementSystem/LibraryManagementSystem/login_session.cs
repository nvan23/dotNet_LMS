using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class login_session
    {
        string _account = "";
        string _password = "";

        public string account
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
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
        public void Reset()
        {
            _account = "";
            _password = "";
        }

    }
    
}
