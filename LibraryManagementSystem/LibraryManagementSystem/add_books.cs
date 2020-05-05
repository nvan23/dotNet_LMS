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
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        int BookID;
        public add_books()
        {
            InitializeComponent();
        }

        public void refesh()
        {
            txtBookName.Text = "";
            txtBookAuthorName.Text = "";
            txtBookPublication.Text = "";
            dtpBookPurchaseDate.Value = DateTime.Now;
            txtBookPrice.Text = "";
            txtQuantity.Text = "";
        }

        private bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                MessageBox.Show("Book Name not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBookAuthorName.Text))
            {
                MessageBox.Show("Book Author Name not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookAuthorName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBookPublication.Text))
            {
                MessageBox.Show("Publication not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookPublication.Focus();
                return false;
            }
           
            if (string.IsNullOrWhiteSpace(txtBookPrice.Text))
            {
                MessageBox.Show("Book Price not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookPrice.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Quantity not empty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Focus();
                return false;
            }


            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (checkData())
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into books_info values('" + txtBookName.Text + "','" + txtBookAuthorName.Text + "','" + txtBookPublication.Text + "','" + dtpBookPurchaseDate.Text + "'," + txtBookPrice.Text + "," + txtQuantity.Text + ")";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    MessageBox.Show("Add book successfully", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại :) ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select MAX(Id) from books_info";
                cmd.ExecuteNonQuery();
                BookID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch
            {
                BookID = 0;
            }

            BookID++;
           
            refesh();
            txtBookID.Text = BookID.ToString();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            txtBookName.Focus();
        }

        private void add_books_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
    }
}
