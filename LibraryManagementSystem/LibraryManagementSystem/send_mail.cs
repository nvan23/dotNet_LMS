using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class send_mail : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        public send_mail()
        {
            InitializeComponent();
        }

        private void send_mail_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            books_stock _books_stock = new books_stock();
            txtEmail_stock.Text = _books_stock.binding_mail();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            books_stock _books_stock = new books_stock();
            MessageBox.Show(_books_stock.binding_mail().ToString());
        }
    }
}
