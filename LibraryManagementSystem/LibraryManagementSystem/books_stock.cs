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
using System.Net.Mail;
using System.Net;

namespace LibraryManagementSystem
{
    public partial class books_stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public books_stock()
        {
            InitializeComponent();
        }

        public void fill_books_info()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select books_Id as ID, books_name as Name,books_author_name as Author,books_quantity as Quantity,available_book as Available from books_info";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBook_stock.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void books_stock_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_books_info();
            
        }

        private void dgvBooksStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSend_stock.Text = "No Mail To Send";
                txtEmail_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
                btnSend_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
                string index;
                index = dgvBook_stock.SelectedCells[0].Value.ToString();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select user_Id_card as Card_ID, user_account_name as Account_Name, user_contact as Phone, user_email as Email, books_name as Book_Name, books_issue_date as Issue_Date, books_return_date as Return_Date from issue_books inner join user_details on issue_books.UID = user_details.UID inner join books_info on issue_books.books_Id = books_info.books_Id where issue_books.books_Id='" + index + "' and issue_books.books_return_date=''";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBookReturn_stock.DataSource = dt;
                txtEmail_stock.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void dgvBookReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSend_stock.Text = "Send Mail Now";
                btnSend_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
                txtEmail_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
                string get_email;
                get_email = dgvBookReturn_stock.SelectedCells[3].Value.ToString();
                txtEmail_stock.Text = get_email.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtSearchBooksStock_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select books_name as Name,books_author_name as Author,books_quantity as Quantity,available_book as Available from books_info where books_name like('%" + txtSearchBooksStock.Text +"%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBook_stock.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static string email = "";

        

        private void btnSend_stock_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                //(username, password)
                smtp.Credentials = new NetworkCredential("mailserviceb1606951@gmail.com", "9nullthis");
                //(from,to,subject,body)
                MailMessage mail = new MailMessage("mailserviceb1606951@gmail.com", txtEmail_stock.Text, "Testing Mail Service for book return notice", txtContent_stock.Text);
                mail.Priority = MailPriority.High;
                smtp.Send(mail);
                MessageBox.Show("Send mail successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
    }
}
