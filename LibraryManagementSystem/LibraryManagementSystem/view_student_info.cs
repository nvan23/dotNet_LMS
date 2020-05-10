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
    public partial class view_student_info : Form
    {
        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;
        DialogResult result;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");

        public view_student_info()
        {
            InitializeComponent();
            fill_grid();
        }

        public void fill_grid()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                int flag = 0;
                dgvStudent.Columns.Clear();
                dgvStudent.Refresh();
                panelStudent_edit.Visible = false;

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * from student_info";
                cmd.CommandText = "select id AS ID, student_name AS Name, student_enrollment_no AS MSSV, student_email AS Email from student_info";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvStudent.DataSource = dt;

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from student_info";
                cmd1.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                
                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dgvStudent.Columns.Add(imageCol);

                foreach (DataRow dr in dt1.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());                    
                    dgvStudent.Rows[flag].Cells[4].Value = img;
                    dgvStudent.Rows[flag].Height = 100;
                    flag = flag + 1;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {
            fill_grid();
        }
        
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int flag = 0;
            try
            {
                dgvStudent.Columns.Clear();
                dgvStudent.Refresh();
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id as ID, student_name as Name, student_enrollment_no as StudentID, student_email as Email from student_info where student_name like('%" + txtSearchStudentName.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvStudent.DataSource = dt;

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from student_info where student_name like('%" + txtSearchStudentName.Text + "%')";
                cmd1.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dgvStudent.Columns.Add(imageCol);

                foreach (DataRow dr in dt1.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dgvStudent.Rows[flag].Cells[4].Value = img;
                    dgvStudent.Rows[flag].Height = 100;
                    flag = flag + 1;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int index = 0;
                Bitmap img;
                index = Convert.ToInt32(dgvStudent.SelectedCells[0].Value.ToString());

                panelStudent_edit.Visible = true;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where id=" + index + "";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtStudentName_edit.Text = dr["student_name"].ToString();
                    // pictureBoxStudent_edit.ImageLocation = dr["student_image"].ToString();
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    pictureBoxStudent_edit.Image = img;
                    pictureBoxStudent_edit.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtEnrollmentNo_edit.Text = dr["student_enrollment_no"].ToString();
                    txtStudentDepartment_edit.Text = dr["student_department"].ToString();
                    txtStudentSeminar_edit.Text = dr["student_sem"].ToString();
                    txtStudentContactNo_edit.Text = dr["student_contact"].ToString();
                    txtStudentEmail_edit.Text = dr["student_email"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnChooseFile_edit_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            result = openFileImageEdit.ShowDialog();
            openFileImageEdit.Filter = "JPEG Files (*.jpeg)|*jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (result == DialogResult.OK) //Test result
            {
                pictureBoxStudent_edit.ImageLocation = openFileImageEdit.FileName;
                pictureBoxStudent_edit.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private bool check_Change()
        {
            int id = 0;
            id = Convert.ToInt32(dgvStudent.SelectedCells[0].Value.ToString());

            panelStudent_edit.Visible = true;
            SqlCommand cmd_id = con.CreateCommand();
            cmd_id.CommandType = CommandType.Text;
            cmd_id.CommandText = "select * from student_info where id=" + id + "";
            cmd_id.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd_id);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                if (txtStudentName_edit.Text == dr["student_name"].ToString() &&
                    txtEnrollmentNo_edit.Text == dr["student_enrollment_no"].ToString() &&
                    txtStudentDepartment_edit.Text == dr["student_department"].ToString() &&
                    txtStudentSeminar_edit.Text == dr["student_sem"].ToString() &&
                    txtStudentContactNo_edit.Text == dr["student_contact"].ToString() &&
                    txtStudentEmail_edit.Text == dr["student_email"].ToString()
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

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (result == DialogResult.OK)
                {
                    int index;
                    index = Convert.ToInt32(dgvStudent.SelectedCells[0].Value.ToString());
                    string img_path;
                    File.Copy(openFileImageEdit.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                    img_path = "student_images\\" + pwd + ".jpg";

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update student_info set student_name='" + txtStudentName_edit.Text + "',student_image='" + img_path.ToString() + "',student_enrollment_no='" + txtEnrollmentNo_edit.Text + "',student_department='" + txtStudentDepartment_edit.Text + "',student_sem='" + txtStudentSeminar_edit.Text + "',student_contact='" + txtStudentContactNo_edit.Text + "',student_email='" + txtStudentEmail_edit.Text + "' where id=" + index + "";
                    cmd.ExecuteNonQuery();
                    fill_grid();
                    MessageBox.Show("Update successfully");
                }
                //else if (result == DialogResult.Cancel || result == DialogResult.None)
                else 
                {
                    if (check_Change())
                    {
                        MessageBox.Show("Nothing to change!");
                    }
                    else
                    {
                        int index;
                        index = Convert.ToInt32(dgvStudent.SelectedCells[0].Value.ToString());
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update student_info set student_name='" + txtStudentName_edit.Text + "',student_enrollment_no='" + txtEnrollmentNo_edit.Text + "',student_department='" + txtStudentDepartment_edit.Text + "',student_sem='" + txtStudentSeminar_edit.Text + "',student_contact='" + txtStudentContactNo_edit.Text + "',student_email='" + txtStudentEmail_edit.Text + "' where id=" + index + "";
                        cmd.ExecuteNonQuery();
                        fill_grid();
                        MessageBox.Show("Update successfully");
                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                index = Convert.ToInt32(dgvStudent.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from student_info where id='" + index + "'";
                cmd.ExecuteNonQuery();
                fill_grid();
                MessageBox.Show("Delete successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStudent.Columns.Clear();
                dgvStudent.Refresh();

                int index = 0;                
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from student_info where student_name like('%" + txtSearchStudentName.Text + "%')";
                cmd1.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dgvStudent.Columns.Add(imageCol);

                foreach (DataRow dr in dt1.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dgvStudent.Rows[index].Cells[4].Value = img;
                    dgvStudent.Rows[index].Height = 100;
                    index = index + 1;
                }
                int i = Convert.ToInt32(dt1.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("No data");
                }
                if(txtSearchStudentName.Text == null)
                {
                    MessageBox.Show("Could Need To Some Kachater :))");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCancel_update_Click(object sender, EventArgs e)
        {
            fill_grid();
        }
    }
}
