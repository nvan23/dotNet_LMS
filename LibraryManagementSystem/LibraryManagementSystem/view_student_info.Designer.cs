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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchStudentName = new System.Windows.Forms.TextBox();
            this.btnSearchStudentName = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.dgvStudent.Location = new System.Drawing.Point(261, 12);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(967, 301);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 128);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Student Name";
            // 
            // txtSearchStudentName
            // 
            this.txtSearchStudentName.Location = new System.Drawing.Point(121, 14);
            this.txtSearchStudentName.Name = "txtSearchStudentName";
            this.txtSearchStudentName.Size = new System.Drawing.Size(119, 20);
            this.txtSearchStudentName.TabIndex = 1;
            this.txtSearchStudentName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnSearchStudentName
            // 
            this.btnSearchStudentName.Location = new System.Drawing.Point(121, 40);
            this.btnSearchStudentName.Name = "btnSearchStudentName";
            this.btnSearchStudentName.Size = new System.Drawing.Size(119, 23);
            this.btnSearchStudentName.TabIndex = 2;
            this.btnSearchStudentName.Text = "Search";
            this.btnSearchStudentName.UseVisualStyleBackColor = true;
            // 
            // panelStudent
            // 
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
            this.panelStudent.Controls.Add(this.label2);
            this.panelStudent.Controls.Add(this.label6);
            this.panelStudent.Controls.Add(this.pictureBoxStudent_edit);
            this.panelStudent.Location = new System.Drawing.Point(261, 319);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(967, 230);
            this.panelStudent.TabIndex = 2;
            // 
            // txtStudentEmail_edit
            // 
            this.txtStudentEmail_edit.Location = new System.Drawing.Point(476, 40);
            this.txtStudentEmail_edit.Name = "txtStudentEmail_edit";
            this.txtStudentEmail_edit.Size = new System.Drawing.Size(249, 20);
            this.txtStudentEmail_edit.TabIndex = 15;
            // 
            // txtStudentContactNo_edit
            // 
            this.txtStudentContactNo_edit.Location = new System.Drawing.Point(525, 149);
            this.txtStudentContactNo_edit.Name = "txtStudentContactNo_edit";
            this.txtStudentContactNo_edit.Size = new System.Drawing.Size(200, 20);
            this.txtStudentContactNo_edit.TabIndex = 14;
            // 
            // txtStudentDepartment_edit
            // 
            this.txtStudentDepartment_edit.Location = new System.Drawing.Point(17, 149);
            this.txtStudentDepartment_edit.Name = "txtStudentDepartment_edit";
            this.txtStudentDepartment_edit.Size = new System.Drawing.Size(200, 20);
            this.txtStudentDepartment_edit.TabIndex = 13;
            // 
            // txtStudentSeminar_edit
            // 
            this.txtStudentSeminar_edit.Location = new System.Drawing.Point(276, 149);
            this.txtStudentSeminar_edit.Name = "txtStudentSeminar_edit";
            this.txtStudentSeminar_edit.Size = new System.Drawing.Size(200, 20);
            this.txtStudentSeminar_edit.TabIndex = 12;
            // 
            // txtEnrollmentNo_edit
            // 
            this.txtEnrollmentNo_edit.Location = new System.Drawing.Point(276, 42);
            this.txtEnrollmentNo_edit.Name = "txtEnrollmentNo_edit";
            this.txtEnrollmentNo_edit.Size = new System.Drawing.Size(157, 20);
            this.txtEnrollmentNo_edit.TabIndex = 11;
            // 
            // txtStudentName_edit
            // 
            this.txtStudentName_edit.Location = new System.Drawing.Point(17, 40);
            this.txtStudentName_edit.Name = "txtStudentName_edit";
            this.txtStudentName_edit.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName_edit.TabIndex = 10;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(798, 204);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(166, 23);
            this.btnUpdateStudent.TabIndex = 9;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnChooseFile_edit
            // 
            this.btnChooseFile_edit.Location = new System.Drawing.Point(889, 175);
            this.btnChooseFile_edit.Name = "btnChooseFile_edit";
            this.btnChooseFile_edit.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile_edit.TabIndex = 8;
            this.btnChooseFile_edit.Text = "Choose File";
            this.btnChooseFile_edit.UseVisualStyleBackColor = true;
            this.btnChooseFile_edit.Click += new System.EventHandler(this.btnChooseFile_edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Student Email";
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Location = new System.Drawing.Point(522, 132);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(104, 13);
            this.labelContactNo.TabIndex = 6;
            this.labelContactNo.Text = "Student Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student Seminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enrollment No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Student Name";
            // 
            // pictureBoxStudent_edit
            // 
            this.pictureBoxStudent_edit.Location = new System.Drawing.Point(800, 3);
            this.pictureBoxStudent_edit.Name = "pictureBoxStudent_edit";
            this.pictureBoxStudent_edit.Size = new System.Drawing.Size(164, 166);
            this.pictureBoxStudent_edit.TabIndex = 0;
            this.pictureBoxStudent_edit.TabStop = false;
            // 
            // openFileImageEdit
            // 
            this.openFileImageEdit.FileName = "openFileDialog1";
            // 
            // view_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 572);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxStudent_edit;
        private System.Windows.Forms.OpenFileDialog openFileImageEdit;
    }
}