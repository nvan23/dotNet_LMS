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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.txtSearchStudentName = new System.Windows.Forms.TextBox();
            this.panelStudent_edit = new System.Windows.Forms.Panel();
            this.btnCancel_update = new System.Windows.Forms.Button();
            this.txtStudentSeminar_edit = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentEmail_edit = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtStudentContactNo_edit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentDepartment_edit = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtEnrollmentNo_edit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentName_edit = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnChooseFile_edit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBoxStudent_edit = new System.Windows.Forms.PictureBox();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.openFileImageEdit = new System.Windows.Forms.OpenFileDialog();
            this.btnSearchStudent = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panelStudent_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent_edit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(132, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 2);
            this.panel1.TabIndex = 24;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudent.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvStudent.Location = new System.Drawing.Point(12, 9);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudent.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(810, 554);
            this.dgvStudent.TabIndex = 20;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // txtSearchStudentName
            // 
            this.txtSearchStudentName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearchStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchStudentName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudentName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchStudentName.Location = new System.Drawing.Point(132, 13);
            this.txtSearchStudentName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtSearchStudentName.Multiline = true;
            this.txtSearchStudentName.Name = "txtSearchStudentName";
            this.txtSearchStudentName.Size = new System.Drawing.Size(350, 28);
            this.txtSearchStudentName.TabIndex = 21;
            // 
            // panelStudent_edit
            // 
            this.panelStudent_edit.Controls.Add(this.btnCancel_update);
            this.panelStudent_edit.Controls.Add(this.txtStudentSeminar_edit);
            this.panelStudent_edit.Controls.Add(this.panel7);
            this.panelStudent_edit.Controls.Add(this.label13);
            this.panelStudent_edit.Controls.Add(this.panel4);
            this.panelStudent_edit.Controls.Add(this.label1);
            this.panelStudent_edit.Controls.Add(this.txtStudentEmail_edit);
            this.panelStudent_edit.Controls.Add(this.panel5);
            this.panelStudent_edit.Controls.Add(this.txtStudentContactNo_edit);
            this.panelStudent_edit.Controls.Add(this.label2);
            this.panelStudent_edit.Controls.Add(this.txtStudentDepartment_edit);
            this.panelStudent_edit.Controls.Add(this.panel6);
            this.panelStudent_edit.Controls.Add(this.txtEnrollmentNo_edit);
            this.panelStudent_edit.Controls.Add(this.label8);
            this.panelStudent_edit.Controls.Add(this.txtStudentName_edit);
            this.panelStudent_edit.Controls.Add(this.panel8);
            this.panelStudent_edit.Controls.Add(this.label10);
            this.panelStudent_edit.Controls.Add(this.label11);
            this.panelStudent_edit.Controls.Add(this.panel9);
            this.panelStudent_edit.Controls.Add(this.btnChooseFile_edit);
            this.panelStudent_edit.Controls.Add(this.btnDelete);
            this.panelStudent_edit.Controls.Add(this.pictureBoxStudent_edit);
            this.panelStudent_edit.Controls.Add(this.btnUpdateStudent);
            this.panelStudent_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStudent_edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStudent_edit.Location = new System.Drawing.Point(828, 0);
            this.panelStudent_edit.Name = "panelStudent_edit";
            this.panelStudent_edit.Size = new System.Drawing.Size(428, 649);
            this.panelStudent_edit.TabIndex = 22;
            // 
            // btnCancel_update
            // 
            this.btnCancel_update.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnCancel_update.Location = new System.Drawing.Point(153, 12);
            this.btnCancel_update.Name = "btnCancel_update";
            this.btnCancel_update.Size = new System.Drawing.Size(125, 29);
            this.btnCancel_update.TabIndex = 73;
            this.btnCancel_update.Text = "Cancel";
            this.btnCancel_update.UseVisualStyleBackColor = false;
            this.btnCancel_update.Click += new System.EventHandler(this.btnCancel_update_Click);
            // 
            // txtStudentSeminar_edit
            // 
            this.txtStudentSeminar_edit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStudentSeminar_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentSeminar_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentSeminar_edit.Location = new System.Drawing.Point(238, 304);
            this.txtStudentSeminar_edit.Name = "txtStudentSeminar_edit";
            this.txtStudentSeminar_edit.Size = new System.Drawing.Size(162, 19);
            this.txtStudentSeminar_edit.TabIndex = 72;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(20, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(188, 1);
            this.panel7.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(17, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 21);
            this.label13.TabIndex = 55;
            this.label13.Text = "Full Name";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(20, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 1);
            this.panel4.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Student ID";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txtStudentEmail_edit
            // 
            this.txtStudentEmail_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtStudentEmail_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentEmail_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail_edit.Location = new System.Drawing.Point(20, 381);
            this.txtStudentEmail_edit.Name = "txtStudentEmail_edit";
            this.txtStudentEmail_edit.ReadOnly = true;
            this.txtStudentEmail_edit.Size = new System.Drawing.Size(388, 19);
            this.txtStudentEmail_edit.TabIndex = 71;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(23, 323);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 1);
            this.panel5.TabIndex = 60;
            // 
            // txtStudentContactNo_edit
            // 
            this.txtStudentContactNo_edit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStudentContactNo_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentContactNo_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentContactNo_edit.Location = new System.Drawing.Point(20, 243);
            this.txtStudentContactNo_edit.Name = "txtStudentContactNo_edit";
            this.txtStudentContactNo_edit.Size = new System.Drawing.Size(188, 19);
            this.txtStudentContactNo_edit.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Department";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtStudentDepartment_edit
            // 
            this.txtStudentDepartment_edit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStudentDepartment_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentDepartment_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentDepartment_edit.Location = new System.Drawing.Point(23, 305);
            this.txtStudentDepartment_edit.Name = "txtStudentDepartment_edit";
            this.txtStudentDepartment_edit.Size = new System.Drawing.Size(185, 19);
            this.txtStudentDepartment_edit.TabIndex = 69;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(238, 323);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(162, 1);
            this.panel6.TabIndex = 62;
            // 
            // txtEnrollmentNo_edit
            // 
            this.txtEnrollmentNo_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtEnrollmentNo_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnrollmentNo_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentNo_edit.Location = new System.Drawing.Point(20, 172);
            this.txtEnrollmentNo_edit.Name = "txtEnrollmentNo_edit";
            this.txtEnrollmentNo_edit.ReadOnly = true;
            this.txtEnrollmentNo_edit.Size = new System.Drawing.Size(188, 19);
            this.txtEnrollmentNo_edit.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(238, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Semester";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // txtStudentName_edit
            // 
            this.txtStudentName_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtStudentName_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentName_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName_edit.Location = new System.Drawing.Point(20, 96);
            this.txtStudentName_edit.Name = "txtStudentName_edit";
            this.txtStudentName_edit.ReadOnly = true;
            this.txtStudentName_edit.Size = new System.Drawing.Size(188, 19);
            this.txtStudentName_edit.TabIndex = 67;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(20, 261);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(188, 1);
            this.panel8.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(17, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 21);
            this.label10.TabIndex = 65;
            this.label10.Text = "Email";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(17, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 21);
            this.label11.TabIndex = 63;
            this.label11.Text = "Phone";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel9.Location = new System.Drawing.Point(20, 398);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(388, 1);
            this.panel9.TabIndex = 66;
            // 
            // btnChooseFile_edit
            // 
            this.btnChooseFile_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnChooseFile_edit.FlatAppearance.BorderSize = 0;
            this.btnChooseFile_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile_edit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChooseFile_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile_edit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChooseFile_edit.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnChooseFile_edit.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnChooseFile_edit.IconSize = 20;
            this.btnChooseFile_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseFile_edit.Location = new System.Drawing.Point(238, 230);
            this.btnChooseFile_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChooseFile_edit.Name = "btnChooseFile_edit";
            this.btnChooseFile_edit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChooseFile_edit.Rotation = 0D;
            this.btnChooseFile_edit.Size = new System.Drawing.Size(170, 31);
            this.btnChooseFile_edit.TabIndex = 54;
            this.btnChooseFile_edit.Text = "Choose File";
            this.btnChooseFile_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChooseFile_edit.UseVisualStyleBackColor = false;
            this.btnChooseFile_edit.Click += new System.EventHandler(this.btnChooseFile_edit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDelete.Location = new System.Drawing.Point(289, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 29);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBoxStudent_edit
            // 
            this.pictureBoxStudent_edit.Location = new System.Drawing.Point(238, 70);
            this.pictureBoxStudent_edit.Name = "pictureBoxStudent_edit";
            this.pictureBoxStudent_edit.Size = new System.Drawing.Size(170, 153);
            this.pictureBoxStudent_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudent_edit.TabIndex = 0;
            this.pictureBoxStudent_edit.TabStop = false;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnUpdateStudent.FlatAppearance.BorderSize = 0;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateStudent.Location = new System.Drawing.Point(17, 12);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(125, 29);
            this.btnUpdateStudent.TabIndex = 52;
            this.btnUpdateStudent.Text = "Save";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // openFileImageEdit
            // 
            this.openFileImageEdit.FileName = "openFileDialog1";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.btnSearchStudent.FlatAppearance.BorderSize = 0;
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchStudent.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchStudent.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchStudent.IconSize = 20;
            this.btnSearchStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchStudent.Location = new System.Drawing.Point(12, 13);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchStudent.Rotation = 0D;
            this.btnSearchStudent.Size = new System.Drawing.Size(138, 31);
            this.btnSearchStudent.TabIndex = 26;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchStudent);
            this.panel2.Controls.Add(this.txtSearchStudentName);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 50);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvStudent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(828, 599);
            this.panel3.TabIndex = 28;
            // 
            // view_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1256, 649);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelStudent_edit);
            this.Name = "view_student_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student Infomation";
            this.Load += new System.EventHandler(this.view_student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panelStudent_edit.ResumeLayout(false);
            this.panelStudent_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent_edit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchStudentName;
        private System.Windows.Forms.Panel panelStudent_edit;
        private System.Windows.Forms.PictureBox pictureBoxStudent_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.OpenFileDialog openFileImageEdit;
        private FontAwesome.Sharp.IconButton btnSearchStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateStudent;
        private FontAwesome.Sharp.IconButton btnChooseFile_edit;
        private System.Windows.Forms.TextBox txtStudentSeminar_edit;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentEmail_edit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtStudentContactNo_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentDepartment_edit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtEnrollmentNo_edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentName_edit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCancel_update;
    }
}