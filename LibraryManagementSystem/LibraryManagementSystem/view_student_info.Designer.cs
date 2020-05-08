namespace LibraryManagementSystem
{
    partial class view_student_info
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchStudentName = new System.Windows.Forms.Button();
            this.txtSearchStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStudentEmail_edit = new System.Windows.Forms.TextBox();
            this.txtStudentContactNo_edit = new System.Windows.Forms.TextBox();
            this.txtStudentDepartment_edit = new System.Windows.Forms.TextBox();
            this.txtStudentSeminar_edit = new System.Windows.Forms.TextBox();
            this.txtEnrollmentNo_edit = new System.Windows.Forms.TextBox();
            this.txtStudentName_edit = new System.Windows.Forms.TextBox();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnChooseFile_edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxStudent_edit = new System.Windows.Forms.PictureBox();
            this.openFileImageEdit = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(12, 29);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(981, 496);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            this.dgvStudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvStudent_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchStudentName);
            this.panel1.Controls.Add(this.txtSearchStudentName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1010, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 95);
            this.panel1.TabIndex = 1;
            // 
            // btnSearchStudentName
            // 
            this.btnSearchStudentName.Location = new System.Drawing.Point(163, 58);
            this.btnSearchStudentName.Name = "btnSearchStudentName";
            this.btnSearchStudentName.Size = new System.Drawing.Size(220, 23);
            this.btnSearchStudentName.TabIndex = 2;
            this.btnSearchStudentName.Text = "Search";
            this.btnSearchStudentName.UseVisualStyleBackColor = true;
            // 
            // txtSearchStudentName
            // 
            this.txtSearchStudentName.Location = new System.Drawing.Point(0, 29);
            this.txtSearchStudentName.Multiline = true;
            this.txtSearchStudentName.Name = "txtSearchStudentName";
            this.txtSearchStudentName.Size = new System.Drawing.Size(383, 23);
            this.txtSearchStudentName.TabIndex = 1;
            this.txtSearchStudentName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Student Name";
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.btnDelete);
            this.panelStudent.Controls.Add(this.txtStudentEmail_edit);
            this.panelStudent.Controls.Add(this.txtStudentContactNo_edit);
            this.panelStudent.Controls.Add(this.txtStudentDepartment_edit);
            this.panelStudent.Controls.Add(this.txtStudentSeminar_edit);
            this.panelStudent.Controls.Add(this.txtEnrollmentNo_edit);
            this.panelStudent.Controls.Add(this.txtStudentName_edit);
            this.panelStudent.Controls.Add(this.btnUpdateStudent);
            this.panelStudent.Controls.Add(this.btnChooseFile_edit);
            this.panelStudent.Controls.Add(this.label7);
            this.panelStudent.Controls.Add(this.labelContactNo);
            this.panelStudent.Controls.Add(this.label5);
            this.panelStudent.Controls.Add(this.label4);
            this.panelStudent.Controls.Add(this.label3);
            this.panelStudent.Controls.Add(this.label6);
            this.panelStudent.Controls.Add(this.pictureBoxStudent_edit);
            this.panelStudent.Location = new System.Drawing.Point(1004, 130);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(396, 409);
            this.panelStudent.TabIndex = 2;
            this.panelStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStudent_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStudentEmail_edit
            // 
            this.txtStudentEmail_edit.Location = new System.Drawing.Point(3, 320);
            this.txtStudentEmail_edit.Name = "txtStudentEmail_edit";
            this.txtStudentEmail_edit.Size = new System.Drawing.Size(380, 20);
            this.txtStudentEmail_edit.TabIndex = 15;
            // 
            // txtStudentContactNo_edit
            // 
            this.txtStudentContactNo_edit.Location = new System.Drawing.Point(3, 262);
            this.txtStudentContactNo_edit.Name = "txtStudentContactNo_edit";
            this.txtStudentContactNo_edit.Size = new System.Drawing.Size(157, 20);
            this.txtStudentContactNo_edit.TabIndex = 14;
            // 
            // txtStudentDepartment_edit
            // 
            this.txtStudentDepartment_edit.Location = new System.Drawing.Point(3, 134);
            this.txtStudentDepartment_edit.Name = "txtStudentDepartment_edit";
            this.txtStudentDepartment_edit.Size = new System.Drawing.Size(157, 20);
            this.txtStudentDepartment_edit.TabIndex = 13;
            // 
            // txtStudentSeminar_edit
            // 
            this.txtStudentSeminar_edit.Location = new System.Drawing.Point(3, 196);
            this.txtStudentSeminar_edit.Name = "txtStudentSeminar_edit";
            this.txtStudentSeminar_edit.Size = new System.Drawing.Size(157, 20);
            this.txtStudentSeminar_edit.TabIndex = 12;
            // 
            // txtEnrollmentNo_edit
            // 
            this.txtEnrollmentNo_edit.Location = new System.Drawing.Point(3, 74);
            this.txtEnrollmentNo_edit.Name = "txtEnrollmentNo_edit";
            this.txtEnrollmentNo_edit.Size = new System.Drawing.Size(157, 20);
            this.txtEnrollmentNo_edit.TabIndex = 11;
            // 
            // txtStudentName_edit
            // 
            this.txtStudentName_edit.Location = new System.Drawing.Point(3, 19);
            this.txtStudentName_edit.Name = "txtStudentName_edit";
            this.txtStudentName_edit.Size = new System.Drawing.Size(157, 20);
            this.txtStudentName_edit.TabIndex = 10;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(3, 372);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(227, 23);
            this.btnUpdateStudent.TabIndex = 9;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnChooseFile_edit
            // 
            this.btnChooseFile_edit.Location = new System.Drawing.Point(236, 259);
            this.btnChooseFile_edit.Name = "btnChooseFile_edit";
            this.btnChooseFile_edit.Size = new System.Drawing.Size(147, 23);
            this.btnChooseFile_edit.TabIndex = 8;
            this.btnChooseFile_edit.Text = "Choose File To Update";
            this.btnChooseFile_edit.UseVisualStyleBackColor = true;
            this.btnChooseFile_edit.Click += new System.EventHandler(this.btnChooseFile_edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Student Email";
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Location = new System.Drawing.Point(5, 246);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(104, 13);
            this.labelContactNo.TabIndex = 6;
            this.labelContactNo.Text = "Student Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student Seminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enrollment No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Student Name";
            // 
            // pictureBoxStudent_edit
            // 
            this.pictureBoxStudent_edit.Location = new System.Drawing.Point(166, 19);
            this.pictureBoxStudent_edit.Name = "pictureBoxStudent_edit";
            this.pictureBoxStudent_edit.Size = new System.Drawing.Size(217, 198);
            this.pictureBoxStudent_edit.TabIndex = 0;
            this.pictureBoxStudent_edit.TabStop = false;
            this.pictureBoxStudent_edit.Click += new System.EventHandler(this.pictureBoxStudent_edit_Click);
            // 
            // openFileImageEdit
            // 
            this.openFileImageEdit.FileName = "openFileDialog1";
            // 
            // view_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 552);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStudent);
            this.Name = "view_student_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student Infomation";
            this.Load += new System.EventHandler(this.view_student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchStudentName;
        private System.Windows.Forms.TextBox txtSearchStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.TextBox txtStudentEmail_edit;
        private System.Windows.Forms.TextBox txtStudentContactNo_edit;
        private System.Windows.Forms.TextBox txtStudentDepartment_edit;
        private System.Windows.Forms.TextBox txtStudentSeminar_edit;
        private System.Windows.Forms.TextBox txtEnrollmentNo_edit;
        private System.Windows.Forms.TextBox txtStudentName_edit;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnChooseFile_edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxStudent_edit;
        private System.Windows.Forms.OpenFileDialog openFileImageEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}