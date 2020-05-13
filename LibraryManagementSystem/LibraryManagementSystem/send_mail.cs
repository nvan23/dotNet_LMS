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
        private send_email_session _send_email_session;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        public send_mail()
        {
            InitializeComponent();
            _send_email_session = new send_email_session();
            txtEmail_stock.Text = books_stock.email.ToString();
        }

        private void send_mail_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            
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

               // _send_email_session.reset();

                MessageBox.Show("Send mail successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            _send_email_session = new send_email_session();
            MessageBox.Show(_send_email_session._mail.ToString());
        }
    }
}
