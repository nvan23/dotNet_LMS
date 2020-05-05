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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public view_student_info()
        {
            InitializeComponent();
        }

        public void fill_grid()
        {
            try
            {
                dgvStudent.Columns.Clear();
                dgvStudent.Refresh();
                int index = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvStudent.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "Student Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dgvStudent.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dgvStudent.Rows[index].Cells[8].Value = img;
                    dgvStudent.Rows[index].Height = 100;
                    index = index + 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_grid();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudent_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgvStudent.Columns.Clear();
                dgvStudent.Refresh();

                int index = 0;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_name like('%"+ txtSearchStudentName.Text +"%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvStudent.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "Student Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dgvStudent.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dgvStudent.Rows[index].Cells[8].Value = img;
                    dgvStudent.Rows[index].Height = 100;
                    index = index + 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = Convert.ToInt32(dgvStudent.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info where id=" + index + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txtStudentName_edit.Text = dr["student_name"].ToString();
                txtEnrollmentNo_edit.Text = dr["student_enrollment_no"].ToString();
                txtStudentDepartment_edit.Text = dr["student_department"].ToString();
                txtStudentSeminar_edit.Text = dr["student_sem"].ToString();
                txtStudentContactNo_edit.Text = dr["student_contact"].ToString();
                txtStudentEmail_edit.Text = dr["student_email"].ToString();
                //pictureBoxStudent_edit.Text = dr["student_iamge"].ToString();
            }

        }

        private void btnChooseFile_edit_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            result = openFileImageEdit.ShowDialog();
            openFileImageEdit.Filter = "JPEG Files (*.jpeg)|*jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
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
                else if (result == DialogResult.Cancel)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
