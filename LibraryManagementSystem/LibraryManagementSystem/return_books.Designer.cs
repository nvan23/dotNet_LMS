namespace LibraryManagementSystem
{
    partial class return_books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelReturnBook_update = new System.Windows.Forms.Panel();
            this.btnCancel_update_books = new System.Windows.Forms.Button();
            this.dtpBookReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIssueDate_return = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookName_return = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEnrollmentNo_return = new System.Windows.Forms.TextBox();
            this.btnSearchBooks_return = new FontAwesome.Sharp.IconButton();
            this.panelReturnBooks = new System.Windows.Forms.Panel();
            this.dgvReturnBooks = new System.Windows.Forms.DataGridView();
            this.panelReturnBook_update.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelReturnBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReturnBook_update
            // 
            this.panelReturnBook_update.Controls.Add(this.btnCancel_update_books);
            this.panelReturnBook_update.Controls.Add(this.dtpBookReturnDate);
            this.panelReturnBook_update.Controls.Add(this.label1);
            this.panelReturnBook_update.Controls.Add(this.label11);
            this.panelReturnBook_update.Controls.Add(this.txtIssueDate_return);
            this.panelReturnBook_update.Controls.Add(this.panel8);
            this.panelReturnBook_update.Controls.Add(this.label9);
            this.panelReturnBook_update.Controls.Add(this.txtBookName_return);
            this.panelReturnBook_update.Controls.Add(this.panel5);
            this.panelReturnBook_update.Controls.Add(this.btnReturn);
            this.panelReturnBook_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelReturnBook_update.Location = new System.Drawing.Point(880, 0);
            this.panelReturnBook_update.Name = "panelReturnBook_update";
            this.panelReturnBook_update.Size = new System.Drawing.Size(271, 648);
            this.panelReturnBook_update.TabIndex = 2;
            // 
            // btnCancel_update_books
            // 
            this.btnCancel_update_books.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel_update_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_update_books.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_update_books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnCancel_update_books.Location = new System.Drawing.Point(143, 9);
            this.btnCancel_update_books.Name = "btnCancel_update_books";
            this.btnCancel_update_books.Size = new System.Drawing.Size(109, 31);
            this.btnCancel_update_books.TabIndex = 75;
            this.btnCancel_update_books.Text = "Cancel";
            this.btnCancel_update_books.UseVisualStyleBackColor = false;
            this.btnCancel_update_books.Click += new System.EventHandler(this.btnCancel_update_books_Click);
            // 
            // dtpBookReturnDate
            // 
            this.dtpBookReturnDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(184)))), ((int)(((byte)(134)))));
            this.dtpBookReturnDate.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpBookReturnDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(184)))), ((int)(((byte)(134)))));
            this.dtpBookReturnDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(184)))), ((int)(((byte)(134)))));
            this.dtpBookReturnDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(184)))), ((int)(((byte)(134)))));
            this.dtpBookReturnDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBookReturnDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookReturnDate.Location = new System.Drawing.Point(24, 221);
            this.dtpBookReturnDate.Name = "dtpBookReturnDate";
            this.dtpBookReturnDate.Size = new System.Drawing.Size(227, 26);
            this.dtpBookReturnDate.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(184)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(21, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Select Return Date";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(21, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Issue Date";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // txtIssueDate_return
            // 
            this.txtIssueDate_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(196)))), ((int)(((byte)(199)))));
            this.txtIssueDate_return.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssueDate_return.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueDate_return.ForeColor = System.Drawing.Color.Black;
            this.txtIssueDate_return.Location = new System.Drawing.Point(24, 154);
            this.txtIssueDate_return.Name = "txtIssueDate_return";
            this.txtIssueDate_return.ReadOnly = true;
            this.txtIssueDate_return.Size = new System.Drawing.Size(227, 19);
            this.txtIssueDate_return.TabIndex = 48;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(24, 177);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(227, 1);
            this.panel8.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(21, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Book Name";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // txtBookName_return
            // 
            this.txtBookName_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(196)))), ((int)(((byte)(199)))));
            this.txtBookName_return.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName_return.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName_return.ForeColor = System.Drawing.Color.Black;
            this.txtBookName_return.Location = new System.Drawing.Point(24, 82);
            this.txtBookName_return.Name = "txtBookName_return";
            this.txtBookName_return.ReadOnly = true;
            this.txtBookName_return.Size = new System.Drawing.Size(227, 19);
            this.txtBookName_return.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(24, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 1);
            this.panel5.TabIndex = 47;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnReturn.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnReturn.IconSize = 30;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(6, 9);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReturn.Rotation = 0D;
            this.btnReturn.Size = new System.Drawing.Size(131, 31);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtEnrollmentNo_return);
            this.panel1.Controls.Add(this.btnSearchBooks_return);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 50);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(140, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 2);
            this.panel2.TabIndex = 35;
            // 
            // txtEnrollmentNo_return
            // 
            this.txtEnrollmentNo_return.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEnrollmentNo_return.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnrollmentNo_return.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentNo_return.ForeColor = System.Drawing.Color.Black;
            this.txtEnrollmentNo_return.Location = new System.Drawing.Point(142, 15);
            this.txtEnrollmentNo_return.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtEnrollmentNo_return.Multiline = true;
            this.txtEnrollmentNo_return.Name = "txtEnrollmentNo_return";
            this.txtEnrollmentNo_return.Size = new System.Drawing.Size(350, 28);
            this.txtEnrollmentNo_return.TabIndex = 34;
            this.txtEnrollmentNo_return.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnrollmentNo_return_KeyUp);
            // 
            // btnSearchBooks_return
            // 
            this.btnSearchBooks_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSearchBooks_return.FlatAppearance.BorderSize = 0;
            this.btnSearchBooks_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBooks_return.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchBooks_return.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBooks_return.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchBooks_return.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchBooks_return.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchBooks_return.IconSize = 20;
            this.btnSearchBooks_return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBooks_return.Location = new System.Drawing.Point(9, 9);
            this.btnSearchBooks_return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBooks_return.Name = "btnSearchBooks_return";
            this.btnSearchBooks_return.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchBooks_return.Rotation = 0D;
            this.btnSearchBooks_return.Size = new System.Drawing.Size(133, 31);
            this.btnSearchBooks_return.TabIndex = 33;
            this.btnSearchBooks_return.Text = "Check";
            this.btnSearchBooks_return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchBooks_return.UseVisualStyleBackColor = false;
            this.btnSearchBooks_return.Click += new System.EventHandler(this.btnSearchBooks_return_Click);
            // 
            // panelReturnBooks
            // 
            this.panelReturnBooks.Controls.Add(this.dgvReturnBooks);
            this.panelReturnBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReturnBooks.Location = new System.Drawing.Point(0, 50);
            this.panelReturnBooks.Name = "panelReturnBooks";
            this.panelReturnBooks.Size = new System.Drawing.Size(880, 598);
            this.panelReturnBooks.TabIndex = 5;
            // 
            // dgvReturnBooks
            // 
            this.dgvReturnBooks.AllowUserToAddRows = false;
            this.dgvReturnBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReturnBooks.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvReturnBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturnBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReturnBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBooks.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnBooks.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvReturnBooks.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvReturnBooks.Location = new System.Drawing.Point(9, 6);
            this.dgvReturnBooks.Name = "dgvReturnBooks";
            this.dgvReturnBooks.ReadOnly = true;
            this.dgvReturnBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnBooks.Size = new System.Drawing.Size(865, 580);
            this.dgvReturnBooks.TabIndex = 3;
            this.dgvReturnBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnBooks_CellClick);
            // 
            // return_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1151, 648);
            this.Controls.Add(this.panelReturnBooks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelReturnBook_update);
            this.Name = "return_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Books";
            this.Load += new System.EventHandler(this.return_books_Load);
            this.panelReturnBook_update.ResumeLayout(false);
            this.panelReturnBook_update.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelReturnBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelReturnBook_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEnrollmentNo_return;
        private FontAwesome.Sharp.IconButton btnSearchBooks_return;
        private System.Windows.Forms.Panel panelReturnBooks;
        private System.Windows.Forms.DataGridView dgvReturnBooks;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIssueDate_return;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookName_return;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpBookReturnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel_update_books;
    }
}