namespace LibraryManagementSystem
{
    partial class reset_password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reset_password));
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconHome = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconHome);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.iconExit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSendMail);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(331, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 355);
            this.panel3.TabIndex = 15;
            // 
            // iconHome
            // 
            this.iconHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconHome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.iconHome.FlatAppearance.BorderSize = 0;
            this.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconHome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHome.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconHome.IconSize = 30;
            this.iconHome.Location = new System.Drawing.Point(14, 8);
            this.iconHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconHome.Name = "iconHome";
            this.iconHome.Rotation = 0D;
            this.iconHome.Size = new System.Drawing.Size(32, 33);
            this.iconHome.TabIndex = 25;
            this.iconHome.UseVisualStyleBackColor = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reset Password";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.iconExit.FlatAppearance.BorderSize = 0;
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconExit.IconSize = 20;
            this.iconExit.Location = new System.Drawing.Point(296, 4);
            this.iconExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconExit.Name = "iconExit";
            this.iconExit.Rotation = 0D;
            this.iconExit.Size = new System.Drawing.Size(32, 33);
            this.iconExit.TabIndex = 23;
            this.iconExit.UseVisualStyleBackColor = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(18, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email ";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendMail.BackgroundImage")));
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSendMail.Location = new System.Drawing.Point(18, 270);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(293, 30);
            this.btnSendMail.TabIndex = 11;
            this.btnSendMail.Text = "Send ";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(19, 205);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 1);
            this.panel6.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(19, 179);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 31);
            this.txtEmail.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(61, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 355);
            this.panel2.TabIndex = 16;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(662, 355);
            this.panel5.TabIndex = 18;
            // 
            // reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(662, 355);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reset_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconHome;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}