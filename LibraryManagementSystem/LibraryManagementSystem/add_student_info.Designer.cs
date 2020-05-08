namespace LibraryManagementSystem
{
    partial class add_student_info
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
            this.panelStudent = new System.Windows.Forms.Panel();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentContactNo = new System.Windows.Forms.TextBox();
            this.txtStudentDepartment = new System.Windows.Forms.TextBox();
            this.txtStudentSeminar = new System.Windows.Forms.TextBox();
            this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.txtStudentEmail);
            this.panelStudent.Controls.Add(this.txtStudentContactNo);
            this.panelStudent.Controls.Add(this.txtStudentDepartment);
            this.panelStudent.Controls.Add(this.txtStudentSeminar);
            this.panelStudent.Controls.Add(this.txtEnrollmentNo);
            this.panelStudent.Controls.Add(this.txtStudentName);
            this.panelStudent.Controls.Add(this.btnSave);
            this.panelStudent.Controls.Add(this.btnChooseFile);
            this.panelStudent.Controls.Add(this.label7);
            this.panelStudent.Controls.Add(this.labelContactNo);
            this.panelStudent.Controls.Add(this.label5);
            this.panelStudent.Controls.Add(this.label4);
            this.panelStudent.Controls.Add(this.label3);
            this.panelStudent.Controls.Add(this.label1);
            this.panelStudent.Controls.Add(this.pictureBoxStudent);
            this.panelStudent.Location = new System.Drawing.Point(12, 12);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(532, 382);
            this.panelStudent.TabIndex = 0;
            this.panelStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(6, 322);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(220, 20);
            this.txtStudentEmail.TabIndex = 15;
            this.txtStudentEmail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtStudentEmail.Leave += new System.EventHandler(this.txtStudentEmail_Leave);
            // 
            // txtStudentContactNo
            // 
            this.txtStudentContactNo.Location = new System.Drawing.Point(6, 267);
            this.txtStudentContactNo.Name = "txtStudentContactNo";
            this.txtStudentContactNo.Size = new System.Drawing.Size(220, 20);
            this.txtStudentContactNo.TabIndex = 14;
            this.txtStudentContactNo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtStudentDepartment
            // 
            this.txtStudentDepartment.Location = new System.Drawing.Point(6, 153);
            this.txtStudentDepartment.Name = "txtStudentDepartment";
            this.txtStudentDepartment.Size = new System.Drawing.Size(220, 20);
            this.txtStudentDepartment.TabIndex = 13;
            this.txtStudentDepartment.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtStudentSeminar
            // 
            this.txtStudentSeminar.Location = new System.Drawing.Point(6, 210);
            this.txtStudentSeminar.Name = "txtStudentSeminar";
            this.txtStudentSeminar.Size = new System.Drawing.Size(220, 20);
            this.txtStudentSeminar.TabIndex = 12;
            this.txtStudentSeminar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.Location = new System.Drawing.Point(6, 101);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(220, 20);
            this.txtEnrollmentNo.TabIndex = 11;
            this.txtEnrollmentNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(6, 47);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(220, 20);
            this.txtStudentName.TabIndex = 10;
            this.txtStudentName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(237, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(256, 291);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(237, 23);
            this.btnChooseFile.TabIndex = 8;
            this.btnChooseFile.Text = "Choose File To Upload";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Student Email";
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Location = new System.Drawing.Point(3, 251);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(104, 13);
            this.labelContactNo.TabIndex = 6;
            this.labelContactNo.Text = "Student Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student Seminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enrollment No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Location = new System.Drawing.Point(256, 47);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(237, 240);
            this.pictureBoxStudent.TabIndex = 0;
            this.pictureBoxStudent.TabStop = false;
            this.pictureBoxStudent.Click += new System.EventHandler(this.pictureBoxStudent_Click);
            // 
            // openFileImage
            // 
            this.openFileImage.FileName = "openFileDialog1";
            // 
            // add_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 420);
            this.Controls.Add(this.panelStudent);
            this.Name = "add_student_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.add_student_info_Load);
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentContactNo;
        private System.Windows.Forms.TextBox txtStudentDepartment;
        private System.Windows.Forms.TextBox txtStudentSeminar;
        private System.Windows.Forms.TextBox txtEnrollmentNo;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.OpenFileDialog openFileImage;
    }
}