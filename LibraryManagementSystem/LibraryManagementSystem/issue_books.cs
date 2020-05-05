using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class issue_books : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public issue_books()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into issue_books values('" + txtStudentEnrollmentNo_issue.Text + "','" + txtStudentName_issue.Text + "','" + txtStudentDepartment_issue.Text + "','" + txtStudentSeminar_issue.Text + "','" + txtStudentContact_issue.Text + "','" + txtStudentEmail_issue.Text + "','" + txtBooksName_issue.Text + "','" + dtpBookIssueDate.Value.ToShortDateString() + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Book Issue Successfully!");
            }
        }

        private void issue_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btnSearchStudent_issue_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;  
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_enrollment_no='"+ txtStudentEnrollmentNo_issue.Text +"'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                index = Convert.ToInt32(dt.Rows.Count.ToString());
                
                if(index == 0)
                {
                    MessageBox.Show("Your Enrollment No. Not Found. Please try again with another enrollment");
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtStudentName_issue.Text = dr["student_name"].ToString();
                        txtStudentDepartment_issue.Text = dr["student_department"].ToString();
                        txtStudentSeminar_issue.Text = dr["student_sem"].ToString();
                        txtStudentContact_issue.Text = dr["student_contact"].ToString();
                        txtStudentEmail_issue.Text = dr["student_email"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtBooksName_issue_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            if(e.KeyCode != Keys.Enter)
            {
                listBoxBooksName.Items.Clear();
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%"+ txtBooksName_issue.Text +"%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count > 0)
                {
                    listBoxBooksName.Visible = true;
                    foreach(DataRow dr in dt.Rows)
                    {
                        listBoxBooksName.Items.Add(dr["books_name"].ToString());
                    }
                }
                else
                {
                    
                }
            }

        }

        private void txtBooksName_issue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxBooksName.Focus();
                listBoxBooksName.SelectedIndex = 0;
            }
        }

        private void listBoxBooksName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtBooksName_issue.Text = listBoxBooksName.SelectedItem.ToString();
                listBoxBooksName.Visible = false;
            }
        }

        private void listBoxBooksName_MouseClick(object sender, MouseEventArgs e)
        {
            txtBooksName_issue.Text = listBoxBooksName.SelectedItem.ToString();
            listBoxBooksName.Visible = false;
        }
    }
}
