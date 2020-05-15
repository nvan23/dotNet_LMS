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
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select books_id as ID, books_name as Name, books_author_name as Author, books_publication_name as Publication, books_purchase_date as Purchase_Date, books_price as Price, books_quantity as Quantity, available_book as Available from books_info";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dgvViewBooks.DataSource = dt;
                
                index = Convert.ToInt32(dt.Rows.Count.ToString());
                
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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display_books();   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select books_id as ID, books_name as Name, books_author_name as Author, books_publication_name as Publication, books_purchase_date as Purchase_Date, books_price as Price, books_quantity as Quantity, available_book as Available from books_info where books_name like('%" + txtSearchBookName.Text + "%') or books_author_name like('"+txtSearchBookName.Text+"')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewBooks.DataSource = dt;

                index = Convert.ToInt32(dt.Rows.Count.ToString());
                
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
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select books_id as ID, books_name as Name, books_author_name as Author, books_publication_name as Publication, books_purchase_date as Purchase_Date, books_price as Price, books_quantity as Quantity, available_book as Available from books_info where books_name like('%" + txtSearchBookName.Text + "%') or books_author_name like('" + txtSearchBookName.Text + "')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvViewBooks.DataSource = dt;
                                
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
                if(login.per_id == 1)
                {
                    panelEdit.Visible = true;
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_id="+index+"";
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

     

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                index = Convert.ToInt32(dgvViewBooks.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update books_info set books_name='" + txtBookName_edit.Text + "',books_author_name='" + txtBookAuthorName_edit.Text + "',books_publication_name='" + txtBookPublication_edit.Text + "',books_purchase_date='" + dtpBookPurchaseDate_edit.Value + "',books_price=" + txtBookPrice_edit.Text + ",books_quantity='" + txtQuantity_edit.Text + "',available_book='" + txtQuantity_edit.Text + "' where books_id=" + index + "";
                cmd.ExecuteNonQuery();
                display_books();
                MessageBox.Show("Update successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }    
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index;
            index = Convert.ToInt32(dgvViewBooks.SelectedCells[0].Value.ToString());
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from books_info where books_id='" + index + "'";
                cmd.ExecuteNonQuery();

                display_books();
                MessageBox.Show("Delete successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_update_books_Click(object sender, EventArgs e)
        {
            display_books();
        }
    }
}
