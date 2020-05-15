using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class add_user : Form
    {
        
        string pwd = Class1.GetRandomPassword(20);
        string random_password = Class1.GetRandomPassword(20);
        string get_gender;
        string wanted_path;
        string update_date = "";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public add_user()
        {
            InitializeComponent();
        }

        public void get_all_role()
        {

            //get all member of Role
            SqlCommand cmd1 = new SqlCommand("Select * from permission", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataColumn id_role = new DataColumn("per_Id");
            DataColumn name_role = new DataColumn("per_Name");
            dt1.Columns.Add(id_role);
            dt1.Columns.Add(name_role);

            while (dr1.Read())
            {
                dt1.Rows.Add(Convert.ToInt32(dr1[0]), dr1[1].ToString());
            }

            cbo_role.DataSource = dt1;
            cbo_role.ValueMember = "per_Id";
            cbo_role.DisplayMember = "per_name";
            dr1.Close();
        }

        public void get_all_status()
        {
            //get all member of Status
            SqlCommand cmd2 = new SqlCommand("Select * from status_account", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataColumn status_id = new DataColumn("status_Id");
            DataColumn status_name = new DataColumn("status_name");
            dt2.Columns.Add(status_id);
            dt2.Columns.Add(status_name);

            while (dr2.Read())
            {
                dt2.Rows.Add(Convert.ToInt32(dr2[0]), dr2[1].ToString());
            }

            cbo_block.DataSource = dt2;
            cbo_block.ValueMember = "status_Id";
            cbo_block.DisplayMember = "status_name";
            dr2.Close();
        }

        private bool checkData_add_student()
        {
            if (string.IsNullOrWhiteSpace(txt_user_account_name.Text))
            {
                MessageBox.Show("Account Name not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user_account_name.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_user_full_name.Text))
            {
                MessageBox.Show("Full Name not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user_full_name.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_user_card_id.Text))
            {
                MessageBox.Show("Card ID not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user_card_id.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_user_contact.Text))
            {
                MessageBox.Show("Contact not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user_contact.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_user_department.Text))
            {
                MessageBox.Show("Department not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user_department.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_user_email.Text))
            {
                MessageBox.Show("Email not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user_email.Focus();
                return false;
            }

            return true;
        }

        private void open_file(object sender, EventArgs e)
        {

            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DialogResult result = openFileImage.ShowDialog();
            openFileImage.Filter = "JPEG Files (*.jpeg)|*jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (result == DialogResult.OK) //Test result
            {
                pictureBoxUser.ImageLocation = openFileImage.FileName;
                pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void create_user(object sender, EventArgs e)
        {
            try
            {
                if (checkData_add_student())
                {
                    string img_path;

                    if (button_user_male.Checked)
                    {
                        get_gender = "Male";
                    }
                    else
                    {
                        get_gender = "Female";
                    }

                    File.Copy(openFileImage.FileName, wanted_path + "\\user_images\\" + pwd + ".jpg");
                    img_path = "user_images\\" + pwd + ".jpg";
                    
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into user_details values('" + txt_user_account_name.Text + "','"+ txt_user_full_name.Text +"','" + img_path.ToString() + "','" + txt_user_card_id.Text + "','" + txt_user_department.Text + "','" + txt_user_contact.Text + "','" + txt_user_email.Text + "','"+ random_password.ToString() +"','"+ get_gender.ToString() +"','"+ DateTime.Now +"','"+update_date+"','"+ cbo_role.SelectedValue + "', '" + cbo_block.SelectedValue + "')";
                    cmd.ExecuteNonQuery();

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    //(username, password)
                    smtp.Credentials = new NetworkCredential("mailserviceb1606951@gmail.com", "9nullthis");
                    //(from,to,subject,body)
                    MailMessage mail = new MailMessage("mailserviceb1606951@gmail.com", txt_user_email.Text, "Welcome to Library Team", "Welcome "+ txt_user_full_name.Text + " to Library, Now you can login my libary system via your email. To safe your account, please do not share this email for anyone. From Library Team. Your libary account password is  " + random_password.ToString());
                    mail.Priority = MailPriority.High;
                    smtp.Send(mail);

                    MessageBox.Show("Adding Student Infomation Successfully! Go to your email to get your password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void check_mail_fomart(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txt_user_email.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(txt_user_email.Text.Trim()))
                {
                    MessageBox.Show("Email address format is not correct.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_user_email.Focus();
                }
            }
        }

        private void txt_view_user_phone_Leave(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"[0-9]{4}[0-9]{3}[0-9]{3}");
            if (!pattern.IsMatch(txt_user_contact.Text))
            {
                MessageBox.Show("Phone Number Format is invalid, Please retype to continue!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_user_contact.Focus();
            }
        }

        private void refesh()
        {
            txt_user_account_name.Text = "";
            txt_user_card_id.Text = "";
            txt_user_contact.Text = "";
            txt_user_department.Text = "";
            txt_user_email.Text = "";
            txt_user_full_name.Text = "";
            pictureBoxUser.Image = null;
            button_user_male.Checked = false;
            button_user_female.Checked = false;
            cbo_block.SelectedIndex = -1;
            cbo_role.SelectedIndex = -1;
        }

        private void new_user(object sender, EventArgs e)
        {
            try
            {
                refesh();
                txt_user_account_name.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void add_user_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            get_all_role();
            get_all_status();
        }
    }
}
