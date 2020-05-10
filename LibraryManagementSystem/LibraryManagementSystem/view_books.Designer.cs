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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchStudent = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchBookName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBookName_edit = new System.Windows.Forms.TextBox();
            this.txtBookAuthorName_edit = new System.Windows.Forms.TextBox();
            this.txtBookPublication_edit = new System.Windows.Forms.TextBox();
            this.txtBookPrice_edit = new System.Windows.Forms.TextBox();
            this.txtQuantity_edit = new System.Windows.Forms.TextBox();
            this.dtpBookPurchaseDate_edit = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnCancel_update_books = new System.Windows.Forms.Button();
            this.dgvViewBooks = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBooks)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSearchStudent.FlatAppearance.BorderSize = 0;
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchStudent.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchStudent.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchStudent.IconSize = 20;
            this.btnSearchStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchStudent.Location = new System.Drawing.Point(12, 9);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchStudent.Rotation = 0D;
            this.btnSearchStudent.Size = new System.Drawing.Size(133, 31);
            this.btnSearchStudent.TabIndex = 29;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(132, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 2);
            this.panel3.TabIndex = 28;
            // 
            // txtSearchBookName
            // 
            this.txtSearchBookName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearchBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBookName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBookName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchBookName.Location = new System.Drawing.Point(132, 15);
            this.txtSearchBookName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtSearchBookName.Multiline = true;
            this.txtSearchBookName.Name = "txtSearchBookName";
            this.txtSearchBookName.Size = new System.Drawing.Size(440, 28);
            this.txtSearchBookName.TabIndex = 27;
            this.txtSearchBookName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(9, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "Name";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(12, 117);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(275, 1);
            this.panel7.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(9, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Author";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 1);
            this.panel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Purchase Date";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(12, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 1);
            this.panel2.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(9, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Publication";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(12, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 1);
            this.panel4.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(9, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "Quantity";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(12, 475);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 1);
            this.panel5.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(9, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "Price";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(12, 403);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(275, 1);
            this.panel6.TabIndex = 40;
            // 
            // txtBookName_edit
            // 
            this.txtBookName_edit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBookName_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName_edit.Location = new System.Drawing.Point(18, 95);
            this.txtBookName_edit.Name = "txtBookName_edit";
            this.txtBookName_edit.Size = new System.Drawing.Size(269, 20);
            this.txtBookName_edit.TabIndex = 43;
            // 
            // txtBookAuthorName_edit
            // 
            this.txtBookAuthorName_edit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBookAuthorName_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookAuthorName_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthorName_edit.Location = new System.Drawing.Point(18, 167);
            this.txtBookAuthorName_edit.Name = "txtBookAuthorName_edit";
            this.txtBookAuthorName_edit.Size = new System.Drawing.Size(269, 20);
            this.txtBookAuthorName_edit.TabIndex = 44;
            // 
            // txtBookPublication_edit
            // 
            this.txtBookPublication_edit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBookPublication_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookPublication_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPublication_edit.Location = new System.Drawing.Point(18, 239);
            this.txtBookPublication_edit.Name = "txtBookPublication_edit";
            this.txtBookPublication_edit.Size = new System.Drawing.Size(269, 20);
            this.txtBookPublication_edit.TabIndex = 45;
            // 
            // txtBookPrice_edit
            // 
            this.txtBookPrice_edit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBookPrice_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookPrice_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPrice_edit.Location = new System.Drawing.Point(18, 377);
            this.txtBookPrice_edit.Name = "txtBookPrice_edit";
            this.txtBookPrice_edit.Size = new System.Drawing.Size(269, 20);
            this.txtBookPrice_edit.TabIndex = 47;
            // 
            // txtQuantity_edit
            // 
            this.txtQuantity_edit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtQuantity_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity_edit.Location = new System.Drawing.Point(18, 449);
            this.txtQuantity_edit.Name = "txtQuantity_edit";
            this.txtQuantity_edit.Size = new System.Drawing.Size(269, 20);
            this.txtQuantity_edit.TabIndex = 48;
            // 
            // dtpBookPurchaseDate_edit
            // 
            this.dtpBookPurchaseDate_edit.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpBookPurchaseDate_edit.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpBookPurchaseDate_edit.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpBookPurchaseDate_edit.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpBookPurchaseDate_edit.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpBookPurchaseDate_edit.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBookPurchaseDate_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookPurchaseDate_edit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookPurchaseDate_edit.Location = new System.Drawing.Point(10, 308);
            this.dtpBookPurchaseDate_edit.Name = "dtpBookPurchaseDate_edit";
            this.dtpBookPurchaseDate_edit.Size = new System.Drawing.Size(275, 26);
            this.dtpBookPurchaseDate_edit.TabIndex = 49;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDelete.Location = new System.Drawing.Point(194, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 29);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(12, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 29);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnCancel_update_books);
            this.panelEdit.Controls.Add(this.btnDelete);
            this.panelEdit.Controls.Add(this.panel7);
            this.panelEdit.Controls.Add(this.label13);
            this.panelEdit.Controls.Add(this.btnUpdate);
            this.panelEdit.Controls.Add(this.panel1);
            this.panelEdit.Controls.Add(this.dtpBookPurchaseDate_edit);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Controls.Add(this.txtQuantity_edit);
            this.panelEdit.Controls.Add(this.panel4);
            this.panelEdit.Controls.Add(this.txtBookPrice_edit);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.txtBookPublication_edit);
            this.panelEdit.Controls.Add(this.panel2);
            this.panelEdit.Controls.Add(this.txtBookAuthorName_edit);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Controls.Add(this.txtBookName_edit);
            this.panelEdit.Controls.Add(this.panel6);
            this.panelEdit.Controls.Add(this.label10);
            this.panelEdit.Controls.Add(this.label11);
            this.panelEdit.Controls.Add(this.panel5);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Location = new System.Drawing.Point(982, 0);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(300, 681);
            this.panelEdit.TabIndex = 53;
            // 
            // btnCancel_update_books
            // 
            this.btnCancel_update_books.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel_update_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_update_books.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_update_books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnCancel_update_books.Location = new System.Drawing.Point(103, 8);
            this.btnCancel_update_books.Name = "btnCancel_update_books";
            this.btnCancel_update_books.Size = new System.Drawing.Size(85, 29);
            this.btnCancel_update_books.TabIndex = 74;
            this.btnCancel_update_books.Text = "Cancel";
            this.btnCancel_update_books.UseVisualStyleBackColor = false;
            this.btnCancel_update_books.Click += new System.EventHandler(this.btnCancel_update_books_Click);
            // 
            // dgvViewBooks
            // 
            this.dgvViewBooks.AllowUserToAddRows = false;
            this.dgvViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViewBooks.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBooks.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewBooks.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvViewBooks.Location = new System.Drawing.Point(12, 0);
            this.dgvViewBooks.Name = "dgvViewBooks";
            this.dgvViewBooks.ReadOnly = true;
            this.dgvViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewBooks.Size = new System.Drawing.Size(970, 619);
            this.dgvViewBooks.TabIndex = 5;
            this.dgvViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewBooks_CellClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSearchStudent);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.txtSearchBookName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(982, 50);
            this.panel8.TabIndex = 54;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dgvViewBooks);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 50);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(982, 631);
            this.panel10.TabIndex = 55;
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1282, 681);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panelEdit);
            this.Name = "view_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Books";
            this.Load += new System.EventHandler(this.view_books_Load);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBooks)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSearchStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchBookName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtBookName_edit;
        private System.Windows.Forms.TextBox txtBookAuthorName_edit;
        private System.Windows.Forms.TextBox txtBookPublication_edit;
        private System.Windows.Forms.TextBox txtBookPrice_edit;
        private System.Windows.Forms.TextBox txtQuantity_edit;
        private System.Windows.Forms.DateTimePicker dtpBookPurchaseDate_edit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.DataGridView dgvViewBooks;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnCancel_update_books;
    }
}