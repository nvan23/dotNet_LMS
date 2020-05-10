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
    public partial class add_student_info : Form
    {
        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public add_student_info()
        {
            InitializeComponent();
        }
        

        private bool checkData_add_student()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Student Name not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEnrollmentNo.Text))
            {
                MessageBox.Show("Enrollment No not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnrollmentNo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStudentDepartment.Text))
            {
                MessageBox.Show("Student Department not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentDepartment.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentEmail.Text))
            {
                MessageBox.Show("Student Email not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStudentContactNo.Text))
            {
                MessageBox.Show("Student Contact Number not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentContactNo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStudentEmail.Text))
            {
                MessageBox.Show("Student Email not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStudentSeminar.Text))
            {
                MessageBox.Show("Student Seminar not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentSeminar.Focus();
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DialogResult result = openFileImage.ShowDialog();
            openFileImage.Filter = "JPEG Files (*.jpeg)|*jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (result == DialogResult.OK) //Test result
            {
                pictureBoxStudent.ImageLocation = openFileImage.FileName;
                pictureBoxStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkData_add_student())
                {
                    string img_path;
                    File.Copy(openFileImage.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                    img_path = "student_images\\" + pwd + ".jpg";

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into student_info values('" + txtStudentName.Text + "','" + img_path.ToString() + "','" + txtEnrollmentNo.Text + "','" + txtStudentDepartment.Text + "','" + txtStudentSeminar.Text + "','" + txtStudentContactNo.Text + "','" + txtStudentEmail.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Adding Student Infomation Successfully!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtStudentEmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtStudentEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(txtStudentEmail.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStudentEmail.Focus();
                }
            }
        }
        

        private void add_student_info_Load(object sender, EventArgs e)
        {
        }

        private void refesh()
        {
            txtStudentName.Text = "";
            txtEnrollmentNo.Text = "";
            txtStudentDepartment.Text = "";
            txtStudentContactNo.Text = "";
            txtStudentEmail.Text = "";
            txtStudentSeminar.Text = "";
            pictureBoxStudent.Image = null;
        }

        private void btnNew_student_Click(object sender, EventArgs e)
        {
            try
            {
                refesh();
                txtStudentName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
