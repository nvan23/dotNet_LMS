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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchBooks_return = new System.Windows.Forms.Button();
            this.txtEnrollmentNo_return = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReturnBooks = new System.Windows.Forms.DataGridView();
            this.panelReturnBook_update = new System.Windows.Forms.Panel();
            this.txtIssueDate_return = new System.Windows.Forms.TextBox();
            this.txtBookName_return = new System.Windows.Forms.TextBox();
            this.dtpBookReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelReturnBooks = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooks)).BeginInit();
            this.panelReturnBook_update.SuspendLayout();
            this.panelReturnBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchBooks_return);
            this.panel1.Controls.Add(this.txtEnrollmentNo_return);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 101);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchBooks_return
            // 
            this.btnSearchBooks_return.Location = new System.Drawing.Point(16, 53);
            this.btnSearchBooks_return.Name = "btnSearchBooks_return";
            this.btnSearchBooks_return.Size = new System.Drawing.Size(173, 23);
            this.btnSearchBooks_return.TabIndex = 2;
            this.btnSearchBooks_return.Text = "Search";
            this.btnSearchBooks_return.UseVisualStyleBackColor = true;
            this.btnSearchBooks_return.Click += new System.EventHandler(this.btnSearchBooks_return_Click);
            // 
            // txtEnrollmentNo_return
            // 
            this.txtEnrollmentNo_return.Location = new System.Drawing.Point(16, 27);
            this.txtEnrollmentNo_return.Name = "txtEnrollmentNo_return";
            this.txtEnrollmentNo_return.Size = new System.Drawing.Size(173, 20);
            this.txtEnrollmentNo_return.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Enrollment No.";
            // 
            // dgvReturnBooks
            // 
            this.dgvReturnBooks.AllowUserToAddRows = false;
            this.dgvReturnBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBooks.Location = new System.Drawing.Point(15, 9);
            this.dgvReturnBooks.Name = "dgvReturnBooks";
            this.dgvReturnBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnBooks.Size = new System.Drawing.Size(1048, 390);
            this.dgvReturnBooks.TabIndex = 1;
            this.dgvReturnBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnBooks_CellClick);
            // 
            // panelReturnBook_update
            // 
            this.panelReturnBook_update.Controls.Add(this.txtIssueDate_return);
            this.panelReturnBook_update.Controls.Add(this.txtBookName_return);
            this.panelReturnBook_update.Controls.Add(this.dtpBookReturnDate);
            this.panelReturnBook_update.Controls.Add(this.btnReturn);
            this.panelReturnBook_update.Controls.Add(this.label4);
            this.panelReturnBook_update.Controls.Add(this.label3);
            this.panelReturnBook_update.Controls.Add(this.label2);
            this.panelReturnBook_update.Location = new System.Drawing.Point(10, 174);
            this.panelReturnBook_update.Name = "panelReturnBook_update";
            this.panelReturnBook_update.Size = new System.Drawing.Size(192, 239);
            this.panelReturnBook_update.TabIndex = 2;
            this.panelReturnBook_update.Visible = false;
            // 
            // txtIssueDate_return
            // 
            this.txtIssueDate_return.Location = new System.Drawing.Point(16, 107);
            this.txtIssueDate_return.Name = "txtIssueDate_return";
            this.txtIssueDate_return.ReadOnly = true;
            this.txtIssueDate_return.Size = new System.Drawing.Size(173, 20);
            this.txtIssueDate_return.TabIndex = 19;
            // 
            // txtBookName_return
            // 
            this.txtBookName_return.Location = new System.Drawing.Point(16, 52);
            this.txtBookName_return.Name = "txtBookName_return";
            this.txtBookName_return.ReadOnly = true;
            this.txtBookName_return.Size = new System.Drawing.Size(173, 20);
            this.txtBookName_return.TabIndex = 18;
            // 
            // dtpBookReturnDate
            // 
            this.dtpBookReturnDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBookReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookReturnDate.Location = new System.Drawing.Point(16, 161);
            this.dtpBookReturnDate.Name = "dtpBookReturnDate";
            this.dtpBookReturnDate.Size = new System.Drawing.Size(173, 20);
            this.dtpBookReturnDate.TabIndex = 17;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(16, 207);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(173, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Return Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // panelReturnBooks
            // 
            this.panelReturnBooks.Controls.Add(this.dgvReturnBooks);
            this.panelReturnBooks.Location = new System.Drawing.Point(213, 3);
            this.panelReturnBooks.Name = "panelReturnBooks";
            this.panelReturnBooks.Size = new System.Drawing.Size(1066, 402);
            this.panelReturnBooks.TabIndex = 3;
            this.panelReturnBooks.Visible = false;
            // 
            // return_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 425);
            this.Controls.Add(this.panelReturnBooks);
            this.Controls.Add(this.panelReturnBook_update);
            this.Controls.Add(this.panel1);
            this.Name = "return_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Books";
            this.Load += new System.EventHandler(this.return_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooks)).EndInit();
            this.panelReturnBook_update.ResumeLayout(false);
            this.panelReturnBook_update.PerformLayout();
            this.panelReturnBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchBooks_return;
        private System.Windows.Forms.TextBox txtEnrollmentNo_return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReturnBooks;
        private System.Windows.Forms.Panel panelReturnBook_update;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBookReturnDate;
        private System.Windows.Forms.Panel panelReturnBooks;
        private System.Windows.Forms.TextBox txtIssueDate_return;
        private System.Windows.Forms.TextBox txtBookName_return;
    }
}