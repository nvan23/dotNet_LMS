using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        private IconButton currentBtn;
        public Form currentChildForm;
        public string flag = "";
        DateTime checkout = DateTime.Now;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E30J54Q\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Pooling=False");
        

        public Home()
        {
            InitializeComponent();

            //Move Form Anywhere
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            HideBtn(btnCreateBook);
            HideBtn(iconBtnView);
            
        }

        public void access()
        {
            if (login.per_id == 1)
            {
                admin_scope();
            }
            else if (login.per_id == 2)
            {
                user_scope();
            }
            else
            {
                guest_scope();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (login.user_account_name != "")
            {
                MessageBox.Show("Welcome back " + login.user_account_name);
                access();
            }
            else
            {
                guest_scope();
            }
        }

        public void admin_scope()
        {
            btnDashboard.Visible = true;
            btnBooks.Visible = true;
            btnIssueBook.Visible = true;
            btnReturnBook.Visible = true;
            btnStock.Visible = true;
            btnUsers.Visible = true;
            btn_logout.Visible = true;
            btnCreateBook.Visible = false;
            iconBtnView.Visible = false;
            btnLogin.Visible = false;
            btnHistory.Visible = true;
            btnAccount.Visible = true;
        }

        public void user_scope()
        {
            btnDashboard.Visible = false;
            btnBooks.Visible = true;
            btnIssueBook.Visible = false;
            btnReturnBook.Visible = false;
            btnStock.Visible = false;
            btnUsers.Visible = false;
            btn_logout.Visible = true;
            btnCreateBook.Visible = false;
            iconBtnView.Visible = false;
            btnLogin.Visible = false;
            btnHistory.Visible = true;
            btnAccount.Visible = true;
        }

        public void guest_scope()
        {
            btnDashboard.Visible = false;
            btnBooks.Visible = true;
            btnIssueBook.Visible = false;
            btnReturnBook.Visible = false;
            btnStock.Visible = false;
            btnUsers.Visible = false;
            btn_logout.Visible = false;
            btnCreateBook.Visible = false;
            iconBtnView.Visible = false;
            btn_logout.Visible = false;
            btnHistory.Visible = false;
            btnAccount.Visible = false;
        }

        //Set view function button
        public void HideBtn(Button btnCurrent)
        {
            btnCurrent.Hide();
        }
        public void ShowBtn(Button btnCurrent)
        {
            btnCurrent.Show();
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(251, 175, 44);
            public static Color color8 = Color.FromArgb(71, 213, 153);
            

            //Set function color
            public static Color colorFuncText = System.Drawing.SystemColors.HighlightText;
            public static Color colorFuncBtn = Color.FromArgb(54, 123, 245);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();

                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        
        public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.SystemColors.HighlightText;
                currentBtn.ForeColor = Color.FromArgb(63, 61, 86);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(63, 61, 86);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurrentChildForm.Text = childForm.Text;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new report_books_remain_retain());
            HideBtn(btnCreateBook);
            HideBtn(iconBtnView);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            if (login.per_id == 1)
            {
                ShowBtn(btnCreateBook);
                ShowBtn(iconBtnView);
            }
            
            
            OpenChildForm(new view_books());
            flag = "onBooksBtn";
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            ShowBtn(btnCreateBook);
            ShowBtn(iconBtnView);
            OpenChildForm(new view_user());
            flag = "onUsersBtn";
        }

        private void btnIssueBook_CLick(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new issue_books());
            HideBtn(btnCreateBook);
            HideBtn(iconBtnView);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new return_books());
            HideBtn(btnCreateBook);
            HideBtn(iconBtnView);
        }

        private void btnStock_CLick(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new books_stock());
            HideBtn(btnCreateBook);
            HideBtn(iconBtnView);
        }
        private void btnAccount_CLick(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new account_user());
            HideBtn(btnCreateBook);
            HideBtn(iconBtnView);
        }

        private void btnHistory_CLick(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new History());
        }

        private void btnLogin_CLick(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new login());
            btnLogin.Text = "Login";
        }

        private void btnLogout_CLick(object sender, EventArgs e)
        {
            login.per_id = 0;
            login.user_account_name = "";
            login.status_id = 0;
            login.uid = 0;
            guest_scope();
            btnLogin.Visible = true;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }


        private void avatar_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblCurrentChildForm.Text = "Home";
            HideBtn(btnCreateBook);
            HideBtn(iconBtnView);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            if(currentBtn != null)
            {
                if (flag == "onBooksBtn" && login.per_id == 1)
                {
                    OpenChildForm(new add_books());
                }
                if (flag == "onUsersBtn" && login.per_id == 1)
                {
                    OpenChildForm(new add_user());
                }
            }
            
        }
               

        private void iconBtnView_Click(object sender, EventArgs e)
        {
            if(currentBtn != null)
            {
                if (currentBtn == btnUsers)
                {
                    OpenChildForm(new view_user());
                }
                if (currentBtn == btnBooks)
                {
                    OpenChildForm(new view_books());
                }
            }
        }
    }
}
