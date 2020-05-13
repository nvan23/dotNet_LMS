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
        int User_ID;
        int Books_ID;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public issue_books()
        {
            InitializeComponent();
        }

        public void refesh()
        {
            txtStudentContact_issue.Clear();
            txtStudentDepartment_issue.Clear();
            txtStudentEmail_issue.Clear();
            txtStudentName_issue.Clear();
            txt_issue_account_name.Clear();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int book_quantity = 0;
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from books_info where books_name='" + txtBooksName_issue.Text + "'";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach(DataRow dr2 in dt2.Rows)
                {
                    Books_ID = Convert.ToInt32(dr2["books_Id"].ToString());
                    book_quantity = Convert.ToInt32(dr2["available_book"].ToString());
                }
                if(book_quantity > 0)
                {

                    int index = 0;
                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "select * from user_details where user_Id_card='" + txtStudentEnrollmentNo_issue.Text + "'";
                    cmd3.ExecuteNonQuery();

                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                    da3.Fill(dt3);
                    index = Convert.ToInt32(dt3.Rows.Count.ToString());

                    if (index == 0)
                    {
                        MessageBox.Show("Your Card ID Not Found. Please try again with another Card ID");
                        refesh();
                    }
                    else
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into issue_books values('" + User_ID + "','" + Books_ID + "','" + DateTime.Now + "','')";
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "update books_info set available_book=available_book-1 where books_name='" + txtBooksName_issue.Text + "'";
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Book Issue Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Now, Book Not Available!!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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
                cmd.CommandText = "select * from user_details where user_Id_card='"+ txtStudentEnrollmentNo_issue.Text +"'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                index = Convert.ToInt32(dt.Rows.Count.ToString());
                
                if(index == 0)
                {
                    MessageBox.Show("Your Enrollment No. Not Found. Please try again with another enrollment");
                    refesh();
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        User_ID = Convert.ToInt32(dr["UID"].ToString());
                        txtStudentName_issue.Text = dr["user_full_name"].ToString();
                        txtStudentDepartment_issue.Text = dr["user_department"].ToString();
                        txt_issue_account_name.Text = dr["user_account_name"].ToString();
                        txtStudentContact_issue.Text = dr["user_contact"].ToString();
                        txtStudentEmail_issue.Text = dr["user_email"].ToString();

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
                        Books_ID = Convert.ToInt32(dr["books_Id"].ToString());
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
