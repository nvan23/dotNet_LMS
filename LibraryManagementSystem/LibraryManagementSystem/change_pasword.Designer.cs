namespace LibraryManagementSystem
{
    partial class change_pasword
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
            this.panel_change_password = new System.Windows.Forms.Panel();
            this.btnChangePassword = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirm_pw = new System.Windows.Forms.TextBox();
            this.txt_enter_pw = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_current_pwd = new System.Windows.Forms.TextBox();
            this.panel_change_password.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_change_password
            // 
            this.panel_change_password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel_change_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_change_password.Controls.Add(this.txt_current_pwd);
            this.panel_change_password.Controls.Add(this.txt_confirm_pw);
            this.panel_change_password.Controls.Add(this.txt_enter_pw);
            this.panel_change_password.Controls.Add(this.btnChangePassword);
            this.panel_change_password.Controls.Add(this.panel6);
            this.panel_change_password.Controls.Add(this.panel4);
            this.panel_change_password.Controls.Add(this.panel3);
            this.panel_change_password.Controls.Add(this.label13);
            this.panel_change_password.Controls.Add(this.label1);
            this.panel_change_password.Controls.Add(this.panel8);
            this.panel_change_password.Controls.Add(this.label11);
            this.panel_change_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_change_password.Location = new System.Drawing.Point(0, 50);
            this.panel_change_password.Name = "panel_change_password";
            this.panel_change_password.Size = new System.Drawing.Size(586, 308);
            this.panel_change_password.TabIndex = 1;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnChangePassword.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnChangePassword.IconSize = 20;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(69, 238);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChangePassword.Rotation = 0D;
            this.btnChangePassword.Size = new System.Drawing.Size(372, 31);
            this.btnChangePassword.TabIndex = 58;
            this.btnChangePassword.Text = "Confirm Now";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btn_change_pasword);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(69, 219);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(372, 1);
            this.panel6.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(72, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 1);
            this.panel4.TabIndex = 90;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(75, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 1);
            this.panel3.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(72, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 24);
            this.label13.TabIndex = 81;
            this.label13.Text = "Curent Password";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(72, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "New Password";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txt_confirm_pw
            // 
            this.txt_confirm_pw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_confirm_pw.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_confirm_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm_pw.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_pw.Location = new System.Drawing.Point(72, 193);
            this.txt_confirm_pw.Multiline = true;
            this.txt_confirm_pw.Name = "txt_confirm_pw";
            this.txt_confirm_pw.Size = new System.Drawing.Size(372, 25);
            this.txt_confirm_pw.TabIndex = 89;
            // 
            // txt_enter_pw
            // 
            this.txt_enter_pw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_enter_pw.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_enter_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_enter_pw.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enter_pw.Location = new System.Drawing.Point(72, 124);
            this.txt_enter_pw.Multiline = true;
            this.txt_enter_pw.Name = "txt_enter_pw";
            this.txt_enter_pw.Size = new System.Drawing.Size(369, 25);
            this.txt_enter_pw.TabIndex = 88;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(72, 219);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(372, 1);
            this.panel8.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(72, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 24);
            this.label11.TabIndex = 85;
            this.label11.Text = "Confirm Password";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btn_cancel.Location = new System.Drawing.Point(452, 8);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 33);
            this.btn_cancel.TabIndex = 75;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_current_pwd
            // 
            this.txt_current_pwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_current_pwd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_current_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_current_pwd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_current_pwd.Location = new System.Drawing.Point(72, 45);
            this.txt_current_pwd.Multiline = true;
            this.txt_current_pwd.Name = "txt_current_pwd";
            this.txt_current_pwd.Size = new System.Drawing.Size(369, 25);
            this.txt_current_pwd.TabIndex = 91;
            // 
            // change_pasword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(586, 358);
            this.Controls.Add(this.panel_change_password);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "change_pasword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "change_pasword";
            this.Load += new System.EventHandler(this.change_pasword_Load);
            this.panel_change_password.ResumeLayout(false);
            this.panel_change_password.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_change_password;
        private FontAwesome.Sharp.IconButton btnChangePassword;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_confirm_pw;
        private System.Windows.Forms.TextBox txt_enter_pw;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_current_pwd;
    }
}