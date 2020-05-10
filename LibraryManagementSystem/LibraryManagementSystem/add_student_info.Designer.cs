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
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChooseFile = new FontAwesome.Sharp.IconButton();
            this.btnSave_student = new System.Windows.Forms.Button();
            this.btnNew_student = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtStudentContactNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtStudentDepartment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentSeminar = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileImage
            // 
            this.openFileImage.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnSave_student);
            this.panel1.Controls.Add(this.btnNew_student);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnChooseFile.FlatAppearance.BorderSize = 0;
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChooseFile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChooseFile.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnChooseFile.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnChooseFile.IconSize = 20;
            this.btnChooseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseFile.Location = new System.Drawing.Point(179, 5);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChooseFile.Rotation = 0D;
            this.btnChooseFile.Size = new System.Drawing.Size(239, 33);
            this.btnChooseFile.TabIndex = 55;
            this.btnChooseFile.Text = "Choose File To Upload";
            this.btnChooseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave_student
            // 
            this.btnSave_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnSave_student.FlatAppearance.BorderSize = 0;
            this.btnSave_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_student.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave_student.Location = new System.Drawing.Point(150, 11);
            this.btnSave_student.Name = "btnSave_student";
            this.btnSave_student.Size = new System.Drawing.Size(141, 33);
            this.btnSave_student.TabIndex = 16;
            this.btnSave_student.Text = "Save";
            this.btnSave_student.UseVisualStyleBackColor = false;
            this.btnSave_student.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNew_student
            // 
            this.btnNew_student.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNew_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew_student.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(248)))));
            this.btnNew_student.Location = new System.Drawing.Point(12, 11);
            this.btnNew_student.Name = "btnNew_student";
            this.btnNew_student.Size = new System.Drawing.Size(132, 33);
            this.btnNew_student.TabIndex = 17;
            this.btnNew_student.Text = "New";
            this.btnNew_student.UseVisualStyleBackColor = false;
            this.btnNew_student.Click += new System.EventHandler(this.btnNew_student_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 2);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.txtStudentContactNo);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtStudentEmail);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtStudentDepartment);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtStudentSeminar);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.txtStudentName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtEnrollmentNo);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 557);
            this.panel3.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnChooseFile);
            this.panel10.Controls.Add(this.pictureBoxStudent);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(604, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(430, 557);
            this.panel10.TabIndex = 56;
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Location = new System.Drawing.Point(3, 45);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(415, 388);
            this.pictureBoxStudent.TabIndex = 16;
            this.pictureBoxStudent.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(12, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Phone";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(15, 361);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(399, 1);
            this.panel8.TabIndex = 48;
            // 
            // txtStudentContactNo
            // 
            this.txtStudentContactNo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStudentContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentContactNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentContactNo.Location = new System.Drawing.Point(17, 338);
            this.txtStudentContactNo.Name = "txtStudentContactNo";
            this.txtStudentContactNo.Size = new System.Drawing.Size(384, 20);
            this.txtStudentContactNo.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(12, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Email";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStudentEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.Location = new System.Drawing.Point(17, 413);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(384, 20);
            this.txtStudentEmail.TabIndex = 43;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel9.Location = new System.Drawing.Point(15, 436);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(399, 1);
            this.panel9.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Department";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(15, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 1);
            this.panel4.TabIndex = 42;
            // 
            // txtStudentDepartment
            // 
            this.txtStudentDepartment.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStudentDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentDepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentDepartment.Location = new System.Drawing.Point(17, 188);
            this.txtStudentDepartment.Name = "txtStudentDepartment";
            this.txtStudentDepartment.Size = new System.Drawing.Size(384, 20);
            this.txtStudentDepartment.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Semester";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // txtStudentSeminar
            // 
            this.txtStudentSeminar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStudentSeminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentSeminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentSeminar.Location = new System.Drawing.Point(17, 263);
            this.txtStudentSeminar.Name = "txtStudentSeminar";
            this.txtStudentSeminar.Size = new System.Drawing.Size(384, 20);
            this.txtStudentSeminar.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(15, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 1);
            this.panel6.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 24);
            this.label13.TabIndex = 35;
            this.label13.Text = "Name";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(15, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(399, 1);
            this.panel7.TabIndex = 36;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(17, 34);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(384, 20);
            this.txtStudentName.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Student ID";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEnrollmentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnrollmentNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentNo.Location = new System.Drawing.Point(17, 109);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(384, 20);
            this.txtEnrollmentNo.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(15, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 1);
            this.panel5.TabIndex = 34;
            // 
            // add_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1034, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "add_student_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.add_student_info_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Button btnSave_student;
        private System.Windows.Forms.Button btnNew_student;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtStudentContactNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtStudentDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentSeminar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEnrollmentNo;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnChooseFile;
        private System.Windows.Forms.Panel panel10;
    }
}