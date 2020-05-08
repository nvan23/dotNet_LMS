using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        //int BookID = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public add_books()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
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
                    cmd.CommandText = "insert into books_info values('" + txtBookName.Text + "','" + txtBookAuthorName.Text + "','" + txtBookPublication.Text + "','" + dtpBookPurchaseDate.Text + "'," + txtBookPrice.Text + "," + txtQuantity.Text + "," + txtQuantity.Text + ")";
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
                /*
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select MAX(Id) from books_info";
                cmd.ExecuteNonQuery();
                BookID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                */
                refesh();
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                txtBookName.Focus();
            }
            catch(Exception ex)
            {
                //BookID = 0;
                MessageBox.Show(ex.Message.ToString());
            }
            
            //BookID++;
           
            //refesh();
            //txtBookID.Text = BookID.ToString();
            
        }

        private void add_books_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
