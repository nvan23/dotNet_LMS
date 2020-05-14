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
        //create values for book data
        int book_id;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public return_books()
        {
            InitializeComponent();
        }

        public void load_data()
        {
            try
            {
                //Fill data for dgvReturn
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "SELECT Issue_id AS ID, books_name as Book_Name, books_issue_date AS Issue_Date, books_return_date AS Return_Date, user_id_card as Card_ID, user_full_name as Full_Name, user_email as Email FROM issue_books INNER JOIN user_details ON issue_books.UID = user_details.UID INNER JOIN books_info ON issue_books.books_Id = books_info.books_Id where books_return_date=''";
                cmd3.ExecuteNonQuery();

                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dt3);
                dgvReturnBooks.DataSource = dt3;

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
                cmd.CommandText = "SELECT Issue_id AS ID, books_name as Book_Name, books_issue_date AS Issue_Date, books_return_date AS Return_Date, user_id_card as Card_ID, user_full_name as Full_Name, user_email as Email FROM issue_books INNER JOIN user_details ON issue_books.UID = user_details.UID INNER JOIN books_info ON issue_books.books_Id = books_info.books_Id where books_return_date='' and user_Id_card='" + enrollment + "'";
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
                cmd.CommandText = "select Issue_id AS ID, books_name as Book_Name, books_issue_date AS Issue_Date, books_return_date AS Return_Date, user_id_card as Card_ID, user_full_name as Full_Name, user_email as Email from issue_books INNER JOIN user_details ON issue_books.UID = user_details.UID INNER JOIN books_info ON issue_books.books_Id = books_info.books_Id where Issue_Id=" + index+"";
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
                string books_name;
                index = Convert.ToInt32(dgvReturnBooks.SelectedCells[0].Value.ToString());
                books_name = dgvReturnBooks.SelectedCells[1].Value.ToString();
                //Get student data
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from books_info";
                cmd2.ExecuteNonQuery();

                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                foreach (DataRow dr2 in dt2.Rows)
                {
                    book_id = Convert.ToInt32(dr2["books_Id"].ToString());
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update issue_books set books_return_date='"+ dtpBookReturnDate.Value.ToString() +"' where Issue_Id=" + index + "";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update books_info set available_book=available_book+1 where books_name='" + books_name.ToString() + "'";
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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            report_books_remain_retain _report_books_remain_retain = new report_books_remain_retain();
            _report_books_remain_retain.Show();
        }
    }
}
