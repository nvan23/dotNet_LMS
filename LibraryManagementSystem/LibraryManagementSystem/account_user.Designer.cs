namespace LibraryManagementSystem
{
    partial class account_user
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave_student = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChooseFile = new FontAwesome.Sharp.IconButton();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btn_view_cancel = new System.Windows.Forms.Button();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.txt_user_full_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_user_account_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_user_department = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_user_card_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_user_contact = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_account_male = new System.Windows.Forms.RadioButton();
            this.button_account_female = new System.Windows.Forms.RadioButton();
            this.txt_user_email = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbo_block = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_role = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 2);
            this.panel2.TabIndex = 8;
            // 
            // btnSave_student
            // 
            this.btnSave_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnSave_student.FlatAppearance.BorderSize = 0;
            this.btnSave_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_student.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave_student.Location = new System.Drawing.Point(17, 9);
            this.btnSave_student.Name = "btnSave_student";
            this.btnSave_student.Size = new System.Drawing.Size(141, 33);
            this.btnSave_student.TabIndex = 16;
            this.btnSave_student.Text = "Save";
            this.btnSave_student.UseVisualStyleBackColor = false;
            this.btnSave_student.Click += new System.EventHandler(this.btn_update);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnChooseFile);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btn_view_cancel);
            this.panel1.Controls.Add(this.btnSave_student);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 50);
            this.panel1.TabIndex = 7;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnChooseFile.Location = new System.Drawing.Point(604, 9);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChooseFile.Rotation = 0D;
            this.btnChooseFile.Size = new System.Drawing.Size(231, 33);
            this.btnChooseFile.TabIndex = 55;
            this.btnChooseFile.Text = "Choose File To Update";
            this.btnChooseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.view_user_choose_file);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePassword.Location = new System.Drawing.Point(841, 8);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(181, 33);
            this.btnChangePassword.TabIndex = 75;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btn_change_password);
            // 
            // btn_view_cancel
            // 
            this.btn_view_cancel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_view_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btn_view_cancel.Location = new System.Drawing.Point(175, 9);
            this.btn_view_cancel.Name = "btn_view_cancel";
            this.btn_view_cancel.Size = new System.Drawing.Size(125, 33);
            this.btn_view_cancel.TabIndex = 74;
            this.btn_view_cancel.Text = "Cancel";
            this.btn_view_cancel.UseVisualStyleBackColor = false;
            this.btn_view_cancel.Click += new System.EventHandler(this.btn_cancel);
            // 
            // openFileImage
            // 
            this.openFileImage.FileName = "openFileDialog1";
            // 
            // txt_user_full_name
            // 
            this.txt_user_full_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_user_full_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.txt_user_full_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user_full_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_full_name.Location = new System.Drawing.Point(21, 111);
            this.txt_user_full_name.Multiline = true;
            this.txt_user_full_name.Name = "txt_user_full_name";
            this.txt_user_full_name.Size = new System.Drawing.Size(462, 29);
            this.txt_user_full_name.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(18, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Full Name";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // txt_user_account_name
            // 
            this.txt_user_account_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_user_account_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.txt_user_account_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user_account_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_account_name.Location = new System.Drawing.Point(21, 38);
            this.txt_user_account_name.Multiline = true;
            this.txt_user_account_name.Name = "txt_user_account_name";
            this.txt_user_account_name.Size = new System.Drawing.Size(462, 29);
            this.txt_user_account_name.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(18, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 24);
            this.label13.TabIndex = 35;
            this.label13.Text = "Account Name";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(21, 298);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(462, 1);
            this.panel6.TabIndex = 40;
            // 
            // txt_user_department
            // 
            this.txt_user_department.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_user_department.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_user_department.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user_department.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_department.Location = new System.Drawing.Point(23, 264);
            this.txt_user_department.Multiline = true;
            this.txt_user_department.Name = "txt_user_department";
            this.txt_user_department.Size = new System.Drawing.Size(460, 33);
            this.txt_user_department.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(18, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Department";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // txt_user_card_id
            // 
            this.txt_user_card_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_user_card_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.txt_user_card_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user_card_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_card_id.Location = new System.Drawing.Point(21, 190);
            this.txt_user_card_id.Multiline = true;
            this.txt_user_card_id.Name = "txt_user_card_id";
            this.txt_user_card_id.Size = new System.Drawing.Size(190, 29);
            this.txt_user_card_id.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(18, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cart ID";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(18, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Email";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // txt_user_contact
            // 
            this.txt_user_contact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_user_contact.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_user_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user_contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_contact.Location = new System.Drawing.Point(239, 186);
            this.txt_user_contact.Multiline = true;
            this.txt_user_contact.Name = "txt_user_contact";
            this.txt_user_contact.Size = new System.Drawing.Size(244, 32);
            this.txt_user_contact.TabIndex = 44;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(237, 220);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(246, 1);
            this.panel8.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(234, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Contact";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pictureBoxUser);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(604, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(430, 557);
            this.panel10.TabIndex = 56;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUser.Location = new System.Drawing.Point(3, 45);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(415, 388);
            this.pictureBoxUser.TabIndex = 16;
            this.pictureBoxUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Gender";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // button_account_male
            // 
            this.button_account_male.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_account_male.AutoSize = true;
            this.button_account_male.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account_male.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_account_male.Location = new System.Drawing.Point(23, 500);
            this.button_account_male.Name = "button_account_male";
            this.button_account_male.Size = new System.Drawing.Size(64, 22);
            this.button_account_male.TabIndex = 58;
            this.button_account_male.TabStop = true;
            this.button_account_male.Text = "Male";
            this.button_account_male.UseVisualStyleBackColor = true;
            // 
            // button_account_female
            // 
            this.button_account_female.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_account_female.AutoSize = true;
            this.button_account_female.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account_female.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_account_female.Location = new System.Drawing.Point(130, 500);
            this.button_account_female.Name = "button_account_female";
            this.button_account_female.Size = new System.Drawing.Size(81, 22);
            this.button_account_female.TabIndex = 59;
            this.button_account_female.TabStop = true;
            this.button_account_female.Text = "Female";
            this.button_account_female.UseVisualStyleBackColor = true;
            // 
            // txt_user_email
            // 
            this.txt_user_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_user_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.txt_user_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_email.Location = new System.Drawing.Point(21, 416);
            this.txt_user_email.Multiline = true;
            this.txt_user_email.Name = "txt_user_email";
            this.txt_user_email.Size = new System.Drawing.Size(462, 29);
            this.txt_user_email.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbo_block);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbo_role);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_user_email);
            this.panel3.Controls.Add(this.button_account_female);
            this.panel3.Controls.Add(this.button_account_male);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.txt_user_contact);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_user_card_id);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_user_department);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txt_user_account_name);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_user_full_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 557);
            this.panel3.TabIndex = 9;
            // 
            // cbo_block
            // 
            this.cbo_block.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbo_block.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_block.FormattingEnabled = true;
            this.cbo_block.Location = new System.Drawing.Point(234, 340);
            this.cbo_block.Name = "cbo_block";
            this.cbo_block.Size = new System.Drawing.Size(249, 28);
            this.cbo_block.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(239, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 86;
            this.label3.Text = "Block";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // cbo_role
            // 
            this.cbo_role.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbo_role.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_role.FormattingEnabled = true;
            this.cbo_role.Location = new System.Drawing.Point(19, 340);
            this.cbo_role.Name = "cbo_role";
            this.cbo_role.Size = new System.Drawing.Size(192, 28);
            this.cbo_role.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(19, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 24);
            this.label11.TabIndex = 84;
            this.label11.Text = "Role";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // account_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1034, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "account_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account ";
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave_student;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileImage;
        private System.Windows.Forms.Button btn_view_cancel;
        private System.Windows.Forms.TextBox txt_user_full_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_user_account_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_user_department;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_user_card_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_user_contact;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton btnChooseFile;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton button_account_male;
        private System.Windows.Forms.RadioButton button_account_female;
        private System.Windows.Forms.TextBox txt_user_email;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ComboBox cbo_block;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_role;
        private System.Windows.Forms.Label label11;
    }
}