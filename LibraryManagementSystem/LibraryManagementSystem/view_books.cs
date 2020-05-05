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
    public partial class view_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");

        public view_books()
        {
            InitializeComponent();
        }

        public void display_books()
        {
            int index = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewBooks.DataSource = dt;
                index = Convert.ToInt32(dt.Rows.Count.ToString());
                con.Close();

                if (index == 0)
                {
                    MessageBox.Show("No data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void view_books_Load(object sender, EventArgs e)
        {
            display_books();   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%" + txtSearchBook.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewBooks.DataSource = dt;

                index = Convert.ToInt32(dt.Rows.Count.ToString());

                con.Close();

                if (index == 0)
                {
                    MessageBox.Show("No data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%" + txtSearchBook.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewBooks.DataSource = dt;

                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_author_name like('%" + txtSeachAuthor.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewBooks.DataSource = dt;

                index = Convert.ToInt32(dt.Rows.Count.ToString());

                con.Close();

                if (index == 0)
                {
                    MessageBox.Show("No data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSeachAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_author_name like('%" + txtSeachAuthor.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                

                dgvViewBooks.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = Convert.ToInt32(dgvViewBooks.SelectedCells[0].Value.ToString());

            try
            {
                panelEdit.Visible = true;
                

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where id="+index+"";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    txtBookName_edit.Text = dr["books_name"].ToString();
                    txtBookAuthorName_edit.Text = dr["books_author_name"].ToString();
                    txtBookPublication_edit.Text = dr["books_publication_name"].ToString();
                    dtpBookPurchaseDate_edit.Value = Convert.ToDateTime(dr["books_purchase_date"].ToString());
                    txtBookPrice_edit.Text = dr["books_price"].ToString();
                    txtQuantity_edit.Text = dr["books_quantity"].ToString();
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index;
            index = Convert.ToInt32(dgvViewBooks.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update books_info set books_name='"+ txtBookName_edit.Text +"',books_author_name='"+ txtBookAuthorName_edit.Text +"',books_publication_name='"+ txtBookPublication_edit.Text +"',books_purchase_date='"+ dtpBookPurchaseDate_edit.Value +"',books_price="+ txtBookPrice_edit.Text +",books_quantity='"+ txtQuantity_edit.Text +"' where id="+index+"";
                cmd.ExecuteNonQuery();
                con.Close();
                display_books();
                MessageBox.Show("Update successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
        private void btnSearchAuthor_Click(object sender, KeyEventArgs e)
        {

        }
        */
    }
}
