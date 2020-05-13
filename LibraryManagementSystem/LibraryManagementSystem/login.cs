using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace LibraryManagementSystem
{
    
    public partial class login : Form
    {
        int count = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        DateTime checkin = DateTime.Now;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private login_session _login_session;

        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }


        /*
        private int getID(string username, string pass)
        {
            int id = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM user_details WHERE user_email ='" + username + "' and user_password='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = Convert.ToInt32(dr["UID"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        private string get_user_name(string username, string pass)
        {
            string user_name = "";
                SqlCommand cmd = new SqlCommand("SELECT * FROM user_details WHERE user_email ='" + username + "' and user_password='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        user_name = dr["user_account_name"].ToString();
                    }
                }
            return username;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //ID_USER = getID(txtUsername.Text, txtPassword.Text);
            ACCOUNT_NAME = get_user_name(txtUsername.Text, txtPassword.Text);
            if (ACCOUNT_NAME != "")
            {
                Home _home = new Home();
                _home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
            }
        }

        public void login_log()
        {

        }
        */
        public static int uid = 0;
        public static string user_account_name= "";
        public static int per_id = 0;
        public static int status_id = 0;
        public static string get_current_mail = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                _login_session = new login_session();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * from library_person where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
                //cmd.CommandText = "select * from student_info where student_email='" + txtUsername.Text + "' and student_password='" + txtPassword.Text + "'";
                cmd.CommandText = "select * from user_details inner join status_account on user_details.status_Id = status_account.status_Id inner join permission on permission.per_Id = user_details.per_Id where (user_details.user_email = '" + txtUsername.Text + "' or user_details.user_account_name = '"+ txtUsername.Text +"' or user_details.user_Id_card = '"+ txtUsername.Text +"') and user_details.user_password = '" + txtPassword.Text +"'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count == 0)
                {
                    MessageBox.Show("Username Or Password not match", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        status_id = Convert.ToInt32(dr["status_Id"].ToString());
                        per_id = Convert.ToInt32(dr["per_Id"].ToString());
                        user_account_name = dr["user_account_name"].ToString();
                        uid = Convert.ToInt32(dr["uid"].ToString());
                        get_current_mail = dr["user_email"].ToString();
                        if (status_id == 1)
                        {
                            MessageBox.Show("Your Account is blocked");
                        }
                        else
                        {
                            Home _home = new Home();
                            _home.Show();
                        }
                    }
                }
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return false;
            }
            
            return true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }    
}
