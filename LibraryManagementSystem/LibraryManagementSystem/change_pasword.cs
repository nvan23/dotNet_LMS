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
        string key = Class1.GetRandomPassword(20);
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        public change_pasword()
        {
            InitializeComponent();
        }
        private bool check_password()
        {
            if (string.IsNullOrWhiteSpace(txt_current_pwd.Text))
            {
                MessageBox.Show("Current password is not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_current_pwd.Focus();
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
            return true;
        }

        private void btn_change_pasword(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from user_details where UID='"+ login.uid +"'";
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
                if (txt_current_pwd.Text == get_password)
                {
                    if (txt_enter_pw.Text != txt_confirm_pw.Text)
                    {
                        MessageBox.Show("The confirm password is not match the password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_confirm_pw.Focus();
                    }
                    else
                    {
                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "update user_details set user_password='" + txt_confirm_pw.Text + "' where uid='" + login.uid + "'";
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Update password successfully!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("There are errors in processing when updating password, try again");
                }
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
