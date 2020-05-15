using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class account_user : Form
    {
        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;
        string get_gender;
        string set_gender;
        DialogResult result;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
        public account_user()
        {
            InitializeComponent();
            load_data();
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

        public void load_data()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            try
            {
                Bitmap img1;
                get_all_role();
                get_all_status();

                if(login.per_id == 1)
                {
                    cbo_block.Enabled = true;
                    cbo_role.Enabled = true;
                    txt_user_account_name.ReadOnly = false;
                    txt_user_card_id.ReadOnly = false;
                    txt_user_contact.ReadOnly = false;
                    txt_user_department.ReadOnly = false;
                    txt_user_email.ReadOnly = false;
                    txt_user_full_name.ReadOnly = false;
                    txt_user_full_name.BackColor = System.Drawing.SystemColors.HighlightText;
                    txt_user_account_name.BackColor = System.Drawing.SystemColors.HighlightText;
                    txt_user_card_id.BackColor = System.Drawing.SystemColors.HighlightText;
                    txt_user_contact.BackColor = System.Drawing.SystemColors.HighlightText;
                    txt_user_department.BackColor = System.Drawing.SystemColors.HighlightText;
                    txt_user_email.BackColor = System.Drawing.SystemColors.HighlightText;

                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from user_details where UID=" + login.uid + "";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    get_gender = dr["user_gender"].ToString();
                    if (get_gender == "Male")
                    {
                        button_account_male.Checked = true;
                    }
                    else
                    {
                        button_account_female.Checked = true;
                    }
                    txt_user_account_name.Text = dr["user_account_name"].ToString();
                    img1 = new Bitmap(@"..\..\" + dr["user_image"].ToString());
                    pictureBoxUser.Image = img1;
                    pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
                    Home.img = img1;
                    txt_user_card_id.Text = dr["user_Id_card"].ToString();
                    txt_user_department.Text = dr["user_department"].ToString();
                    txt_user_full_name.Text = dr["user_full_name"].ToString();
                    txt_user_contact.Text = dr["user_contact"].ToString();
                    txt_user_email.Text = dr["user_email"].ToString();
                    cbo_role.SelectedValue = Convert.ToInt32(dr["per_Id"].ToString());
                    cbo_block.SelectedValue = Convert.ToInt32(dr["status_Id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void view_user_choose_file(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            result = openFileImage.ShowDialog();
            openFileImage.Filter = "JPEG Files (*.jpeg)|*jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (result == DialogResult.OK) //Test result
            {
                pictureBoxUser.ImageLocation = openFileImage.FileName;
                pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btn_update(object sender, EventArgs e)
        {
            try
            {
                if (result == DialogResult.OK)
                {
                    string img_path;
                    File.Copy(openFileImage.FileName, wanted_path + "\\user_images\\" + pwd + ".jpg");
                    img_path = "user_images\\" + pwd + ".jpg";

                    if (button_account_male.Checked == true)
                    {
                        set_gender = "Male";
                    }
                    else if (button_account_female.Checked == true)
                    {
                        set_gender = "Female";
                    }

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update user_details set user_account_name='" + txt_user_account_name.Text + "',user_full_name='" + txt_user_full_name.Text + "',user_image='" + img_path.ToString() + "',user_Id_card='" + txt_user_card_id.Text + "',user_department='" + txt_user_department.Text + "',user_contact='" + txt_user_contact.Text + "',user_email='" + txt_user_email.Text + "',user_gender='" + set_gender.ToString() + "',user_date_update = '" + DateTime.Now + "', per_Id='" + cbo_role.SelectedValue + "', status_Id='" + cbo_block.SelectedValue + "' where UID=" + login.uid + "";
                    cmd.ExecuteNonQuery();
                    load_data();
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    if (button_account_male.Checked == true)
                    {
                        set_gender = "Male";
                    }
                    else if (button_account_female.Checked == true)
                    {
                        set_gender = "Female";
                    }

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update user_details set user_account_name='" + txt_user_account_name.Text + "',user_full_name='" + txt_user_full_name.Text + "',user_Id_card='" + txt_user_card_id.Text + "',user_department='" + txt_user_department.Text + "',user_contact='" + txt_user_contact.Text + "',user_email='" + txt_user_email.Text + "',user_gender='" + set_gender.ToString() + "',user_date_update = '" + DateTime.Now + "', per_Id='" + cbo_role.SelectedValue + "', status_Id='" + cbo_block.SelectedValue + "' where UID=" + login.uid + "";
                    cmd.ExecuteNonQuery();

                    load_data();
                    MessageBox.Show("Update successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_cancel(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_change_password(object sender, EventArgs e)
        {
            change_pasword _change_pasword = new change_pasword();
            _change_pasword.Show();
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
    }
}
