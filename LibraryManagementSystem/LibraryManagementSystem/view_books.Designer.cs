namespace LibraryManagementSystem
{
    partial class view_books
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
            this.dgvViewBooks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.txtSeachAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.dtpBookPurchaseDate_edit = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity_edit = new System.Windows.Forms.TextBox();
            this.txtBookPrice_edit = new System.Windows.Forms.TextBox();
            this.txtBookPublication_edit = new System.Windows.Forms.TextBox();
            this.txtBookAuthorName_edit = new System.Windows.Forms.TextBox();
            this.txtBookName_edit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewBooks
            // 
            this.dgvViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBooks.Location = new System.Drawing.Point(309, 12);
            this.dgvViewBooks.Name = "dgvViewBooks";
            this.dgvViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewBooks.Size = new System.Drawing.Size(874, 257);
            this.dgvViewBooks.TabIndex = 0;
            this.dgvViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewBooks_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchBook);
            this.panel1.Controls.Add(this.txtSearchBook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 118);
            this.panel1.TabIndex = 1;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(111, 49);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(163, 23);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search Now";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(111, 23);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(163, 20);
            this.txtSearchBook.TabIndex = 1;
            this.txtSearchBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Book Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchAuthor);
            this.panel2.Controls.Add(this.txtSeachAuthor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 133);
            this.panel2.TabIndex = 3;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(111, 49);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(163, 23);
            this.btnSearchAuthor.TabIndex = 2;
            this.btnSearchAuthor.Text = "Search Now";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // txtSeachAuthor
            // 
            this.txtSeachAuthor.Location = new System.Drawing.Point(111, 23);
            this.txtSeachAuthor.Name = "txtSeachAuthor";
            this.txtSeachAuthor.Size = new System.Drawing.Size(163, 20);
            this.txtSeachAuthor.TabIndex = 1;
            this.txtSeachAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSeachAuthor_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Author Name";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnUpdate);
            this.panelEdit.Controls.Add(this.dtpBookPurchaseDate_edit);
            this.panelEdit.Controls.Add(this.txtQuantity_edit);
            this.panelEdit.Controls.Add(this.txtBookPrice_edit);
            this.panelEdit.Controls.Add(this.txtBookPublication_edit);
            this.panelEdit.Controls.Add(this.txtBookAuthorName_edit);
            this.panelEdit.Controls.Add(this.txtBookName_edit);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.label8);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Location = new System.Drawing.Point(309, 275);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(846, 203);
            this.panelEdit.TabIndex = 4;
            this.panelEdit.Visible = false;
            // 
            // dtpBookPurchaseDate_edit
            // 
            this.dtpBookPurchaseDate_edit.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBookPurchaseDate_edit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookPurchaseDate_edit.Location = new System.Drawing.Point(566, 15);
            this.dtpBookPurchaseDate_edit.Name = "dtpBookPurchaseDate_edit";
            this.dtpBookPurchaseDate_edit.Size = new System.Drawing.Size(200, 20);
            this.dtpBookPurchaseDate_edit.TabIndex = 30;
            // 
            // txtQuantity_edit
            // 
            this.txtQuantity_edit.Location = new System.Drawing.Point(566, 107);
            this.txtQuantity_edit.Name = "txtQuantity_edit";
            this.txtQuantity_edit.Size = new System.Drawing.Size(200, 20);
            this.txtQuantity_edit.TabIndex = 27;
            // 
            // txtBookPrice_edit
            // 
            this.txtBookPrice_edit.Location = new System.Drawing.Point(566, 56);
            this.txtBookPrice_edit.Name = "txtBookPrice_edit";
            this.txtBookPrice_edit.Size = new System.Drawing.Size(200, 20);
            this.txtBookPrice_edit.TabIndex = 26;
            // 
            // txtBookPublication_edit
            // 
            this.txtBookPublication_edit.Location = new System.Drawing.Point(148, 103);
            this.txtBookPublication_edit.Name = "txtBookPublication_edit";
            this.txtBookPublication_edit.Size = new System.Drawing.Size(200, 20);
            this.txtBookPublication_edit.TabIndex = 25;
            // 
            // txtBookAuthorName_edit
            // 
            this.txtBookAuthorName_edit.Location = new System.Drawing.Point(148, 56);
            this.txtBookAuthorName_edit.Name = "txtBookAuthorName_edit";
            this.txtBookAuthorName_edit.Size = new System.Drawing.Size(200, 20);
            this.txtBookAuthorName_edit.TabIndex = 24;
            // 
            // txtBookName_edit
            // 
            this.txtBookName_edit.Location = new System.Drawing.Point(148, 14);
            this.txtBookName_edit.Name = "txtBookName_edit";
            this.txtBookName_edit.Size = new System.Drawing.Size(200, 20);
            this.txtBookName_edit.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Book Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Book Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Book Purchase Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Book Publication";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Book Author Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Book Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(566, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 23);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 580);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvViewBooks);
            this.Name = "view_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Books";
            this.Load += new System.EventHandler(this.view_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.TextBox txtSeachAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.DateTimePicker dtpBookPurchaseDate_edit;
        private System.Windows.Forms.TextBox txtQuantity_edit;
        private System.Windows.Forms.TextBox txtBookPrice_edit;
        private System.Windows.Forms.TextBox txtBookPublication_edit;
        private System.Windows.Forms.TextBox txtBookAuthorName_edit;
        private System.Windows.Forms.TextBox txtBookName_edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
    }
}