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
    public partial class return_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public return_books()
        {
            InitializeComponent();
        }

        public void load_data()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id as ID, student_enrollment_no as Student_ID, student_name as Full_Name, student_contact as Phone, student_email as Email, books_name as Book_Name, books_issue_date as Issue_Date, books_return_date as Return_Date from issue_books where books_return_date=''";
                //cmd.CommandText = "select * from issue_books where books_return_date=''";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvReturnBooks.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void fill_grid(string enrollment)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id as ID, student_enrollment_no as Student_ID, student_name as Full_Name, student_contact as Phone, student_email as Email, books_name as Book_Name, books_issue_date as Issue_Date, books_return_date as Return_Date from issue_books where student_enrollment_no='" + enrollment.ToString() +"' and books_return_date=''";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvReturnBooks.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void return_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            load_data();
        }

        private void btnSearchBooks_return_Click(object sender, EventArgs e)
        {
            fill_grid(txtEnrollmentNo_return.Text);
        }

        private void dgvReturnBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //panelReturnBook_update.Visible = true;
                int index;
                index = Convert.ToInt32(dgvReturnBooks.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id as ID, student_enrollment_no as Student_ID, student_name as Full_Name, student_contact as Phone, student_email as Email, books_name as Book_Name, books_issue_date as Issue_Date, books_return_date as Return_Date from issue_books where Id=" + index+"";
                cmd.ExecuteNonQuery();
                

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtBookName_return.Text = dr["Book_Name"].ToString();
                    txtIssueDate_return.Text = Convert.ToString(dr["Issue_Date"].ToString());
                    dtpBookReturnDate.MinDate = Convert.ToDateTime(dr["Issue_Date"].ToString());
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                index = Convert.ToInt32(dgvReturnBooks.SelectedCells[0].Value.ToString());

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update issue_books set books_return_date='"+ dtpBookReturnDate.Value.ToString() +"' where Id=" + index + "";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update books_info set available_book=available_book+1 where books_name='" + txtBookName_return.Text + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Books Return Successfully");
                //panelReturnBook_update.Visible = false;
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtEnrollmentNo_return_KeyUp(object sender, KeyEventArgs e)
        {
            fill_grid(txtEnrollmentNo_return.Text);
        }

        private void btnCancel_update_books_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
