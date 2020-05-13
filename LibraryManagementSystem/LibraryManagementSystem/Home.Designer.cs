namespace LibraryManagementSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnHistory = new FontAwesome.Sharp.IconButton();
            this.btnStock = new FontAwesome.Sharp.IconButton();
            this.btnReturnBook = new FontAwesome.Sharp.IconButton();
            this.btnIssueBook = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnBooks = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconMaximize = new FontAwesome.Sharp.IconButton();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.iconBtnView = new FontAwesome.Sharp.IconButton();
            this.btnCreateBook = new FontAwesome.Sharp.IconButton();
            this.lblCurrentChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileImageEdit = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.btn_logout);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(257, 913);
            this.panelMenu.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAccount);
            this.panel4.Controls.Add(this.btnHistory);
            this.panel4.Controls.Add(this.btnStock);
            this.panel4.Controls.Add(this.btnReturnBook);
            this.panel4.Controls.Add(this.btnIssueBook);
            this.panel4.Controls.Add(this.btnUsers);
            this.panel4.Controls.Add(this.btnBooks);
            this.panel4.Controls.Add(this.btnDashboard);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 593);
            this.panel4.TabIndex = 10;
            // 
            // btnAccount
            // 
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnAccount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnAccount.IconSize = 32;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 518);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnAccount.Rotation = 0D;
            this.btnAccount.Size = new System.Drawing.Size(257, 74);
            this.btnAccount.TabIndex = 15;
            this.btnAccount.Text = "My Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_CLick);
            // 
            // btnHistory
            // 
            this.btnHistory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnHistory.IconSize = 32;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 444);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnHistory.Rotation = 0D;
            this.btnHistory.Size = new System.Drawing.Size(257, 74);
            this.btnHistory.TabIndex = 14;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_CLick);
            // 
            // btnStock
            // 
            this.btnStock.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.btnStock.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnStock.IconSize = 32;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 370);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnStock.Rotation = 0D;
            this.btnStock.Size = new System.Drawing.Size(257, 74);
            this.btnStock.TabIndex = 13;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_CLick);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReturnBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnReturnBook.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnReturnBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnReturnBook.IconSize = 32;
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(0, 296);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnReturnBook.Rotation = 0D;
            this.btnReturnBook.Size = new System.Drawing.Size(257, 74);
            this.btnReturnBook.TabIndex = 12;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnIssueBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnIssueBook.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnIssueBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnIssueBook.IconSize = 32;
            this.btnIssueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBook.Location = new System.Drawing.Point(0, 222);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnIssueBook.Rotation = 0D;
            this.btnIssueBook.Size = new System.Drawing.Size(257, 74);
            this.btnIssueBook.TabIndex = 11;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_CLick);
            // 
            // btnUsers
            // 
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnUsers.IconSize = 32;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 148);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnUsers.Rotation = 0D;
            this.btnUsers.Size = new System.Drawing.Size(257, 74);
            this.btnUsers.TabIndex = 10;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBooks.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnBooks.IconSize = 32;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 74);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnBooks.Rotation = 0D;
            this.btnBooks.Size = new System.Drawing.Size(257, 74);
            this.btnBooks.TabIndex = 9;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnDashboard.Rotation = 0D;
            this.btnDashboard.Size = new System.Drawing.Size(257, 74);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(175)))), ((int)(((byte)(44)))));
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnLogin.IconSize = 32;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 172);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnLogin.Rotation = 0D;
            this.btnLogin.Size = new System.Drawing.Size(257, 74);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login Now";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_CLick);
            // 
            // btn_logout
            // 
            this.btn_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_logout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btn_logout.IconSize = 32;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 839);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btn_logout.Rotation = 0D;
            this.btn_logout.Size = new System.Drawing.Size(257, 74);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btnLogout_CLick);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelLogo.Controls.Add(this.pictureBoxAvatar);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.panelLogo.Size = new System.Drawing.Size(257, 172);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.Image")));
            this.pictureBoxAvatar.Location = new System.Drawing.Point(48, 13);
            this.pictureBoxAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(138, 143);
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            this.pictureBoxAvatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelTitleBar.Controls.Add(this.iconMaximize);
            this.panelTitleBar.Controls.Add(this.iconMinimize);
            this.panelTitleBar.Controls.Add(this.iconExit);
            this.panelTitleBar.Controls.Add(this.iconBtnView);
            this.panelTitleBar.Controls.Add(this.btnCreateBook);
            this.panelTitleBar.Controls.Add(this.lblCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTitleBar.Location = new System.Drawing.Point(257, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1105, 70);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.BackColor = System.Drawing.SystemColors.HighlightText;
            this.iconMaximize.FlatAppearance.BorderSize = 0;
            this.iconMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMaximize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMaximize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximize.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMaximize.IconSize = 30;
            this.iconMaximize.Location = new System.Drawing.Point(1023, 13);
            this.iconMaximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Rotation = 0D;
            this.iconMaximize.Size = new System.Drawing.Size(32, 33);
            this.iconMaximize.TabIndex = 22;
            this.iconMaximize.UseVisualStyleBackColor = false;
            this.iconMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.SystemColors.HighlightText;
            this.iconMinimize.FlatAppearance.BorderSize = 0;
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMinimize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconMinimize.IconSize = 30;
            this.iconMinimize.Location = new System.Drawing.Point(985, 13);
            this.iconMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Rotation = 0D;
            this.iconMinimize.Size = new System.Drawing.Size(32, 33);
            this.iconMinimize.TabIndex = 21;
            this.iconMinimize.UseVisualStyleBackColor = false;
            this.iconMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.iconExit.FlatAppearance.BorderSize = 0;
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconExit.IconSize = 30;
            this.iconExit.Location = new System.Drawing.Point(1061, 13);
            this.iconExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconExit.Name = "iconExit";
            this.iconExit.Rotation = 0D;
            this.iconExit.Size = new System.Drawing.Size(32, 33);
            this.iconExit.TabIndex = 20;
            this.iconExit.UseVisualStyleBackColor = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // iconBtnView
            // 
            this.iconBtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.iconBtnView.FlatAppearance.BorderSize = 0;
            this.iconBtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnView.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnView.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconBtnView.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconBtnView.IconColor = System.Drawing.SystemColors.HighlightText;
            this.iconBtnView.IconSize = 20;
            this.iconBtnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnView.Location = new System.Drawing.Point(385, 33);
            this.iconBtnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconBtnView.Name = "iconBtnView";
            this.iconBtnView.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnView.Rotation = 0D;
            this.iconBtnView.Size = new System.Drawing.Size(120, 31);
            this.iconBtnView.TabIndex = 19;
            this.iconBtnView.Text = "View";
            this.iconBtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnView.UseVisualStyleBackColor = false;
            this.iconBtnView.Click += new System.EventHandler(this.iconBtnView_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.btnCreateBook.FlatAppearance.BorderSize = 0;
            this.btnCreateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBook.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCreateBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateBook.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCreateBook.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateBook.IconSize = 20;
            this.btnCreateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBook.Location = new System.Drawing.Point(259, 33);
            this.btnCreateBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCreateBook.Rotation = 0D;
            this.btnCreateBook.Size = new System.Drawing.Size(120, 31);
            this.btnCreateBook.TabIndex = 18;
            this.btnCreateBook.Text = "Create";
            this.btnCreateBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateBook.UseVisualStyleBackColor = false;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // lblCurrentChildForm
            // 
            this.lblCurrentChildForm.AutoSize = true;
            this.lblCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.lblCurrentChildForm.Location = new System.Drawing.Point(77, 41);
            this.lblCurrentChildForm.Name = "lblCurrentChildForm";
            this.lblCurrentChildForm.Size = new System.Drawing.Size(47, 17);
            this.lblCurrentChildForm.TabIndex = 1;
            this.lblCurrentChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.iconCurrentChildForm.IconSize = 37;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(33, 30);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(37, 39);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(257, 70);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1105, 2);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(257, 72);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1105, 841);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1104, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 840);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 840);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 1);
            this.panel1.TabIndex = 0;
            // 
            // openFileImageEdit
            // 
            this.openFileImageEdit.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(257, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 841);
            this.panel3.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1362, 913);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCreateBook;
        private System.Windows.Forms.OpenFileDialog openFileImageEdit;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconBtnView;
        private FontAwesome.Sharp.IconButton btn_logout;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnReturnBook;
        private FontAwesome.Sharp.IconButton btnIssueBook;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnBooks;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnHistory;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconMaximize;
        private FontAwesome.Sharp.IconButton iconMinimize;
    }
}