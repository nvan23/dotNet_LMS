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
    public partial class History : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
        public History()
        {
            InitializeComponent();
        }
        public void load_history()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT books_name as Book_Name, books_issue_date AS Issue_Date, books_return_date AS Return_Date FROM issue_books INNER JOIN user_details ON issue_books.UID = user_details.UID INNER JOIN books_info ON issue_books.books_Id = books_info.books_Id where user_details.UID = '" + login.uid + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_history_user.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void fill_grid(string key_search)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT books_name as Book_Name, books_issue_date AS Issue_Date, books_return_date AS Return_Date FROM issue_books INNER JOIN user_details ON issue_books.UID = user_details.UID INNER JOIN books_info ON issue_books.books_Id = books_info.books_Id where user_details.UID = '" + login.uid + "' and books_info.books_name like ('%" + key_search + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_history_user.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btn_history_search_click(object sender, EventArgs e)
        {
            fill_grid(txt_history_search.Text);
        }

        private void key_up_search_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select history.Book_Name, history.Issue_Date, history.Return_Date from (SELECT books_name as Book_Name, books_issue_date AS Issue_Date, books_return_date AS Return_Date FROM issue_books INNER JOIN user_details ON issue_books.UID = user_details.UID INNER JOIN books_info ON issue_books.books_Id = books_info.books_Id where user_details.UID = '" + login.uid +"') history where history.Book_Name like('%"+ txt_history_search.Text +"%');";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_history_user.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void History_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            load_history();
        }

        private void key_up_search_click(object sender, KeyEventArgs e)
        {

        }
    }
}
