namespace LibraryManagementSystem
{
    partial class send_mail
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
        public void InitializeComponent()
        {
            this.txtContent_stock = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail_stock = new System.Windows.Forms.TextBox();
            this.btnSendMail = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent_stock
            // 
            this.txtContent_stock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent_stock.Location = new System.Drawing.Point(12, 6);
            this.txtContent_stock.Multiline = true;
            this.txtContent_stock.Name = "txtContent_stock";
            this.txtContent_stock.Size = new System.Drawing.Size(555, 358);
            this.txtContent_stock.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.txtEmail_stock);
            this.panel1.Controls.Add(this.btnSendMail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 50);
            this.panel1.TabIndex = 5;
            // 
            // txtEmail_stock
            // 
            this.txtEmail_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            this.txtEmail_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail_stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail_stock.ForeColor = System.Drawing.Color.Black;
            this.txtEmail_stock.Location = new System.Drawing.Point(12, 12);
            this.txtEmail_stock.Multiline = true;
            this.txtEmail_stock.Name = "txtEmail_stock";
            this.txtEmail_stock.ReadOnly = true;
            this.txtEmail_stock.Size = new System.Drawing.Size(399, 31);
            this.txtEmail_stock.TabIndex = 31;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSendMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSendMail.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSendMail.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnSendMail.IconSize = 20;
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.Location = new System.Drawing.Point(417, 12);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSendMail.Rotation = 0D;
            this.btnSendMail.Size = new System.Drawing.Size(150, 31);
            this.btnSendMail.TabIndex = 30;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtContent_stock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 376);
            this.panel2.TabIndex = 6;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconButton1.IconColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(261, 12);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(150, 31);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.Text = "Send Mail";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // send_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(588, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "send_mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send Mail To Student";
            this.Load += new System.EventHandler(this.send_mail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtContent_stock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSendMail;
        private System.Windows.Forms.TextBox txtEmail_stock;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}