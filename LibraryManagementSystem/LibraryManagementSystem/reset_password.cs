using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class reset_password : Form
    {

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
        int count = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        public reset_password()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            login _login = new login();
            _login.Show();
            this.Close();
        }

        private void iconHome_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Show();
            this.Close();
        }

        private bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        public static string passwd = "";

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkData())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from user_details where user_email='"+ txtEmail.Text +"'";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    count = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (count == 0)
                    {
                        MessageBox.Show("Email not match. Try again with another email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEmail.Focus();
                    }
                    else
                    {
                        foreach(DataRow dr in dt.Rows)
                        {
                            passwd = dr["user_password"].ToString();
                        }
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        //(username, password)
                        smtp.Credentials = new NetworkCredential("mailserviceb1606951@gmail.com", "9nullthis");
                        //(from,to,subject,body)
                        MailMessage mail = new MailMessage("mailserviceb1606951@gmail.com", txtEmail.Text, "Your old password is", passwd.ToString());
                        mail.Priority = MailPriority.High;
                        smtp.Send(mail);
                        MessageBox.Show("Your old password sent to your mail"); ;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
