using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class clsConnection
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                //login with window authentication option, so there are no user name and password
                con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
                con.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
