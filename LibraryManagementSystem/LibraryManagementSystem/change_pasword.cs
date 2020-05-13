using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class change_pasword : Form
    {
        string get_password;
        string key = Class1.GetRandomPassword(6);
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        public change_pasword()
        {
            InitializeComponent();
        }
        private bool check_password()
        {
            if (string.IsNullOrWhiteSpace(txt_curent_pw.Text))
            {
                MessageBox.Show("Current password is not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_curent_pw.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_enter_pw.Text))
            {
                MessageBox.Show("Password is not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_enter_pw.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_confirm_pw.Text))
            {
                MessageBox.Show("Confirm password is not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_confirm_pw.Focus();
                return false;
            }
            if(txt_enter_pw.Text != txt_confirm_pw.Text)
            {
                MessageBox.Show("The confirm password is not match the password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_confirm_pw.Focus();
                return false;
            }
            return true;
        }
        private void btn_get_key(object sender, EventArgs e)
        {
            try
            {
                //Send key to mail of current user
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                //(username, password)
                smtp.Credentials = new NetworkCredential("mailserviceb1606951@gmail.com", "9nullthis");
                //(from,to,subject,body)
                MailMessage mail = new MailMessage("mailserviceb1606951@gmail.com", login.get_current_mail, "Your confirmation code is ", key);
                mail.Priority = MailPriority.High;
                smtp.Send(mail);
                MessageBox.Show("Open your email to get code");



                //Compare key
                if (txt_get_key.Text == key)
                {
                    panel_change_password.Visible = true;
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from user_details";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        get_password = dr["user_password"].ToString();
                    }

                    if (check_password())
                    {
                        if (txt_curent_pw.Text == get_password)
                        {
                            SqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "update user_details set user_password='"+ txt_confirm_pw.Text +"' where uid='"+ login.uid +"'";
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Update password successfully!");
                        }
                        MessageBox.Show("There are errors in processing when updating password, try again");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void change_pasword_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
        
    }
}
