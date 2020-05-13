using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class send_email_session
    {
        string _email = "";
        public string _mail
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



        public void reset()
        {
            _email = "";
        }
    }
}
