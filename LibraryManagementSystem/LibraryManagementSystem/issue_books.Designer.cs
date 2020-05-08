namespace LibraryManagementSystem
{
    partial class issue_books
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
            this.listBoxBooksName = new System.Windows.Forms.ListBox();
            this.dtpBookIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.btnSearchStudent_issue = new System.Windows.Forms.Button();
            this.txtBooksName_issue = new System.Windows.Forms.TextBox();
            this.txtStudentEmail_issue = new System.Windows.Forms.TextBox();
            this.txtStudentContact_issue = new System.Windows.Forms.TextBox();
            this.txtStudentSeminar_issue = new System.Windows.Forms.TextBox();
            this.txtStudentDepartment_issue = new System.Windows.Forms.TextBox();
            this.txtStudentName_issue = new System.Windows.Forms.TextBox();
            this.txtStudentEnrollmentNo_issue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxBooksName);
            this.panel1.Controls.Add(this.dtpBookIssueDate);
            this.panel1.Controls.Add(this.btnIssueBooks);
            this.panel1.Controls.Add(this.btnSearchStudent_issue);
            this.panel1.Controls.Add(this.txtBooksName_issue);
            this.panel1.Controls.Add(this.txtStudentEmail_issue);
            this.panel1.Controls.Add(this.txtStudentContact_issue);
            this.panel1.Controls.Add(this.txtStudentSeminar_issue);
            this.panel1.Controls.Add(this.txtStudentDepartment_issue);
            this.panel1.Controls.Add(this.txtStudentName_issue);
            this.panel1.Controls.Add(this.txtStudentEnrollmentNo_issue);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 381);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBoxBooksName
            // 
            this.listBoxBooksName.FormattingEnabled = true;
            this.listBoxBooksName.Location = new System.Drawing.Point(33, 159);
            this.listBoxBooksName.Name = "listBoxBooksName";
            this.listBoxBooksName.Size = new System.Drawing.Size(200, 147);
            this.listBoxBooksName.TabIndex = 19;
            this.listBoxBooksName.Visible = false;
            this.listBoxBooksName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxBooksName_MouseClick);
            this.listBoxBooksName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxBooksName_KeyDown);
            // 
            // dtpBookIssueDate
            // 
            this.dtpBookIssueDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBookIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookIssueDate.Location = new System.Drawing.Point(254, 286);
            this.dtpBookIssueDate.Name = "dtpBookIssueDate";
            this.dtpBookIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBookIssueDate.TabIndex = 18;
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.Location = new System.Drawing.Point(33, 326);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(421, 23);
            this.btnIssueBooks.TabIndex = 17;
            this.btnIssueBooks.Text = "Issue Books";
            this.btnIssueBooks.UseVisualStyleBackColor = true;
            this.btnIssueBooks.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearchStudent_issue
            // 
            this.btnSearchStudent_issue.Location = new System.Drawing.Point(33, 57);
            this.btnSearchStudent_issue.Name = "btnSearchStudent_issue";
            this.btnSearchStudent_issue.Size = new System.Drawing.Size(188, 23);
            this.btnSearchStudent_issue.TabIndex = 16;
            this.btnSearchStudent_issue.Text = "Check Student";
            this.btnSearchStudent_issue.UseVisualStyleBackColor = true;
            this.btnSearchStudent_issue.Click += new System.EventHandler(this.btnSearchStudent_issue_Click);
            // 
            // txtBooksName_issue
            // 
            this.txtBooksName_issue.Location = new System.Drawing.Point(33, 133);
            this.txtBooksName_issue.Name = "txtBooksName_issue";
            this.txtBooksName_issue.Size = new System.Drawing.Size(200, 20);
            this.txtBooksName_issue.TabIndex = 14;
            this.txtBooksName_issue.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.txtBooksName_issue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBooksName_issue_KeyDown);
            this.txtBooksName_issue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBooksName_issue_KeyUp);
            // 
            // txtStudentEmail_issue
            // 
            this.txtStudentEmail_issue.Location = new System.Drawing.Point(254, 237);
            this.txtStudentEmail_issue.Name = "txtStudentEmail_issue";
            this.txtStudentEmail_issue.Size = new System.Drawing.Size(200, 20);
            this.txtStudentEmail_issue.TabIndex = 13;
            this.txtStudentEmail_issue.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtStudentContact_issue
            // 
            this.txtStudentContact_issue.Location = new System.Drawing.Point(254, 184);
            this.txtStudentContact_issue.Name = "txtStudentContact_issue";
            this.txtStudentContact_issue.Size = new System.Drawing.Size(200, 20);
            this.txtStudentContact_issue.TabIndex = 12;
            this.txtStudentContact_issue.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtStudentSeminar_issue
            // 
            this.txtStudentSeminar_issue.Location = new System.Drawing.Point(254, 133);
            this.txtStudentSeminar_issue.Name = "txtStudentSeminar_issue";
            this.txtStudentSeminar_issue.Size = new System.Drawing.Size(200, 20);
            this.txtStudentSeminar_issue.TabIndex = 11;
            this.txtStudentSeminar_issue.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtStudentDepartment_issue
            // 
            this.txtStudentDepartment_issue.Location = new System.Drawing.Point(254, 81);
            this.txtStudentDepartment_issue.Name = "txtStudentDepartment_issue";
            this.txtStudentDepartment_issue.Size = new System.Drawing.Size(200, 20);
            this.txtStudentDepartment_issue.TabIndex = 10;
            this.txtStudentDepartment_issue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtStudentName_issue
            // 
            this.txtStudentName_issue.Location = new System.Drawing.Point(254, 31);
            this.txtStudentName_issue.Name = "txtStudentName_issue";
            this.txtStudentName_issue.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName_issue.TabIndex = 9;
            this.txtStudentName_issue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtStudentEnrollmentNo_issue
            // 
            this.txtStudentEnrollmentNo_issue.Location = new System.Drawing.Point(33, 31);
            this.txtStudentEnrollmentNo_issue.Name = "txtStudentEnrollmentNo_issue";
            this.txtStudentEnrollmentNo_issue.Size = new System.Drawing.Size(188, 20);
            this.txtStudentEnrollmentNo_issue.TabIndex = 8;
            this.txtStudentEnrollmentNo_issue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enter Books Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Issue Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Semimar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Enrollment No.";
            // 
            // issue_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 408);
            this.Controls.Add(this.panel1);
            this.Name = "issue_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Books";
            this.Load += new System.EventHandler(this.issue_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.Button btnSearchStudent_issue;
        private System.Windows.Forms.TextBox txtBooksName_issue;
        private System.Windows.Forms.TextBox txtStudentEmail_issue;
        private System.Windows.Forms.TextBox txtStudentContact_issue;
        private System.Windows.Forms.TextBox txtStudentSeminar_issue;
        private System.Windows.Forms.TextBox txtStudentDepartment_issue;
        private System.Windows.Forms.TextBox txtStudentName_issue;
        private System.Windows.Forms.TextBox txtStudentEnrollmentNo_issue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBookIssueDate;
        private System.Windows.Forms.ListBox listBoxBooksName;
    }
}