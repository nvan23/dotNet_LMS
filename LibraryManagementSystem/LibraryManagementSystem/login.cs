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
        

        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }
        
        public static int uid = 0;
        public static string user_account_name= "";
        public static string user_full_name = "";
        public static int per_id = 0;
        public static int status_id = 0;
        public static string get_current_mail = "";
        public static string get_image_location = "";

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkData())
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
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
                        user_full_name = dr["user_full_name"].ToString();
                        uid = Convert.ToInt32(dr["uid"].ToString());
                        get_current_mail = dr["user_email"].ToString();
                        get_image_location = dr["user_image"].ToString();
                        if (status_id == 1)
                        {
                            uid = 0;
                            user_account_name = "";
                            per_id = 0;
                            status_id = 0;
                            get_current_mail = "";
                            get_image_location = "";
                            MessageBox.Show("Your Account is blocked");
                        }
                        else
                        {
                            Home _home = new Home();
                            _home.Show();
                            this.Hide();
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
            Home _home = new Home();
            _home.Show();
            this.Close();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconHome_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            reset_password _reset_password = new reset_password();
            _reset_password.Show();
            this.Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }    
}
