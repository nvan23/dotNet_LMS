using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class view_user : Form
    {
       
        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;
        string get_gender;
        string set_gender;

        DialogResult result;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");

        public view_user()
        {
            InitializeComponent();
            fill_grid();
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

        public void fill_grid()
        {

            dgv_view_user.Columns.Clear();
            dgv_view_user.Refresh();
            get_all_role();
            get_all_status();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            int flag = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from user_details";
            cmd.CommandText = "select UID AS ID, user_email as Email, user_full_name as Full_Name, user_Id_card AS Card_ID from user_details";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_view_user.DataSource = dt;
            

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from user_details";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.HeaderText = "Image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageCol.SortMode = DataGridViewColumnSortMode.Automatic;
            imageCol.Width = 100;
            dgv_view_user.Columns.Add(imageCol);

            foreach (DataRow dr1 in dt1.Rows)
            {
                Bitmap img = new Bitmap(@"..\..\" + dr1["user_image"].ToString());
                dgv_view_user.Rows[flag].Cells[4].Value = img;
                dgv_view_user.Rows[flag].Height = 100;
                flag = flag + 1;
            }

        }
        
        private void view_user_Load(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            int flag = 0;
            try
            {
                dgv_view_user.Columns.Clear();
                dgv_view_user.Refresh();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select UID AS ID, user_email as Email, user_full_name as Full_Name, user_Id_card AS Card_ID from user_details where user_account_name like('%" + txt_view_search.Text + "%') or user_full_name like('%" + txt_view_search.Text + "%') or user_Id_card like('%" + txt_view_search.Text + "%') or user_email like('%" + txt_view_search.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_view_user.DataSource = dt;

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from user_details where user_account_name like('%" + txt_view_search.Text + "%') or user_full_name like('%" + txt_view_search.Text + "%') or user_Id_card like('%" + txt_view_search.Text + "%') or user_email like('%" + txt_view_search.Text + "%')";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "Image";
                imageCol.SortMode = DataGridViewColumnSortMode.Automatic;
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dgv_view_user.Columns.Add(imageCol);

                foreach (DataRow dr1 in dt1.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr1["user_image"].ToString());
                    dgv_view_user.Rows[flag].Cells[4].Value = img;
                    dgv_view_user.Rows[flag].Height = 100;
                    flag = flag + 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgv_user_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                panel_view_edit.Visible = true;
                int index = 0;
                Bitmap img;
                index = Convert.ToInt32(dgv_view_user.SelectedCells[0].Value.ToString());

                panel_view_edit.Visible = true;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from user_details where UID=" + index + "";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    get_gender = dr["user_gender"].ToString();
                    if (get_gender == "Male")
                    {
                        btn_view_user_male.Checked = true;
                    }
                    else
                    {
                        btn_view_user_female.Checked = true;
                    }
                    txt_view_user_account.Text = dr["user_account_name"].ToString();
                    img = new Bitmap(@"..\..\" + dr["user_image"].ToString());
                    pictureBox_view_user_image.Image = img;
                    pictureBox_view_user_image.SizeMode = PictureBoxSizeMode.StretchImage;
                    txt_view_Id_card.Text = dr["user_Id_card"].ToString();
                    txt_view_user_department.Text = dr["user_department"].ToString();
                    txt_view_user_full_name.Text = dr["user_full_name"].ToString();
                    txt_view_user_phone.Text = dr["user_contact"].ToString();
                    txt_view_user_email.Text = dr["user_email"].ToString();
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
            result = openFileImageEdit.ShowDialog();
            openFileImageEdit.Filter = "JPEG Files (*.jpeg)|*jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (result == DialogResult.OK) //Test result
            {
                pictureBox_view_user_image.ImageLocation = openFileImageEdit.FileName;
                pictureBox_view_user_image.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            
            
        }

        /*
        private bool check_Change()
        {
            int id;
            id = Convert.ToInt32(dgv_view_user.SelectedCells[0].Value.ToString());

            panelStudent_edit.Visible = true;
            SqlCommand cmd_id = con.CreateCommand();
            cmd_id.CommandType = CommandType.Text;
            cmd_id.CommandText = "select * from user_details where UID=" + id + "";
            cmd_id.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd_id);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                if (txt_view_user_account.Text == dr["user_account_name"].ToString() &&
                    txt_view_Id_card.Text == dr["user_Id_card"].ToString() &&
                    txt_view_user_department.Text == dr["user_department"].ToString() &&
                    txt_view_user_full_name.Text == dr["user_full_name"].ToString() &&
                    txt_view_user_phone.Text == dr["user_contact"].ToString() &&
                    txt_view_user_full_name.Text == dr["user_email"].ToString()
                    )
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return true;
        }
        */

        private void view_btn_update(object sender, EventArgs e)
        {
            try
            {
                if (result == DialogResult.OK)
                {
                    int index;
                    index = Convert.ToInt32(dgv_view_user.SelectedCells[0].Value.ToString());
                    string img_path;

                    File.Copy(openFileImageEdit.FileName, wanted_path + "\\user_images\\" + pwd + ".jpg");
                    img_path = "user_images\\" + pwd + ".jpg";

                    if (btn_view_user_male.Checked == true)
                    {
                        set_gender = "Male";
                    }
                    else if (btn_view_user_female.Checked == true)
                    {
                        set_gender = "Female";
                    }

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update user_details set user_account_name='" + txt_view_user_account.Text + "',user_full_name='" + txt_view_user_full_name.Text + "',user_image='" + img_path.ToString() + "',user_Id_card='" + txt_view_Id_card.Text + "',user_department='" + txt_view_user_department.Text + "',user_contact='" + txt_view_user_phone.Text + "',user_email='" + txt_view_user_email.Text + "',user_gender='" + set_gender.ToString() + "',user_date_update = '" + DateTime.Now + "', per_Id='" + cbo_role.SelectedValue + "', status_Id='" + cbo_block.SelectedValue + "' where UID=" + index + "";
                    cmd.ExecuteNonQuery();
                    fill_grid();
                    MessageBox.Show("Update successfully");
                    MessageBox.Show(wanted_path.ToString());
                }
                //else if (result == DialogResult.Cancel || result == DialogResult.None)
                else
                {
                    /*
                    if (check_Change())
                    {
                        MessageBox.Show("Nothing to change!");
                    }
                    else
                    {
                    */
                    int index;
                    index = Convert.ToInt32(dgv_view_user.SelectedCells[0].Value.ToString());

                    if (btn_view_user_male.Checked == true)
                    {
                        set_gender = "Male";
                    }
                    else if (btn_view_user_female.Checked == true)
                    {
                        set_gender = "Female";
                    }

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update user_details set user_account_name='" + txt_view_user_account.Text + "',user_full_name='" + txt_view_user_full_name.Text + "',user_Id_card='" + txt_view_Id_card.Text + "',user_department='" + txt_view_user_department.Text + "',user_contact='" + txt_view_user_phone.Text + "',user_email='" + txt_view_user_email.Text + "',user_gender='" + set_gender.ToString() + "',user_date_update = '" + DateTime.Now + "', per_Id='" + cbo_role.SelectedValue + "', status_Id='" + cbo_block.SelectedValue + "' where UID=" + index + "";
                    cmd.ExecuteNonQuery();
                        
                    fill_grid();
                    refesh();
                    MessageBox.Show("Update successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void view_btn_delete(object sender, EventArgs e)
        {
            try
            {
                int index;
                index = Convert.ToInt32(dgv_view_user.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from user_details where UID='" + index + "'";
                cmd.ExecuteNonQuery();
                fill_grid();
                MessageBox.Show("Delete successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void view_btn_search_click(object sender, EventArgs e)
        {
            try
            {
                dgv_view_user.Columns.Clear();
                dgv_view_user.Refresh();

                int index = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select UID AS ID, user_email as Email, user_full_name as Full_Name, user_Id_card AS Card_ID from user_details where user_account_name like('%" + txt_view_search.Text + "%') or user_full_name like('%" + txt_view_search.Text + "%') or user_Id_card like('%" + txt_view_search.Text + "%') or user_email like('%" + txt_view_search.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dgv_view_user.Columns.Add(imageCol);

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select user_image from user_details where user_account_name like('%" + txt_view_search.Text + "%') or user_full_name like('%" + txt_view_search.Text + "%') or user_Id_card like('%" + txt_view_search.Text + "%') or user_email like('%" + txt_view_search.Text + "%')";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                foreach (DataRow dr1 in dt1.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr1["user_image"].ToString());
                    dgv_view_user.Rows[index].Cells[5].Value = img;
                    dgv_view_user.Rows[index].Height = 100;
                    index = index + 1;
                }
                int i = Convert.ToInt32(dt1.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("No data");
                }
                if (txt_view_search.Text == null)
                {
                    MessageBox.Show("Could Need To Some Kachater :))");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void refesh()
        {
            txt_view_Id_card.Clear();
            txt_view_search.Clear();
            txt_view_user_account.Clear();
            txt_view_user_department.Clear();
            txt_view_user_email.Clear();
            txt_view_user_full_name.Clear();
            txt_view_user_phone.Clear();
            pictureBox_view_user_image.Image = null;
            btn_view_user_female.Checked = false;
            btn_view_user_male.Checked = false;
            cbo_block.SelectedIndex = -1;
            cbo_role.SelectedIndex = -1;
        }

        private void view_btn_cancel(object sender, EventArgs e)
        {
            refesh();
            fill_grid();
        }

        
    }
}
