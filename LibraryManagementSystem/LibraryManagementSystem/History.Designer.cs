namespace LibraryManagementSystem
{
    partial class History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_history_search = new FontAwesome.Sharp.IconButton();
            this.txt_history_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_history_user = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_history_search);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_history_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_history_search
            // 
            this.btn_history_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.btn_history_search.FlatAppearance.BorderSize = 0;
            this.btn_history_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history_search.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_history_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history_search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_history_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_history_search.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btn_history_search.IconSize = 20;
            this.btn_history_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_history_search.Location = new System.Drawing.Point(12, 13);
            this.btn_history_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_history_search.Name = "btn_history_search";
            this.btn_history_search.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_history_search.Rotation = 0D;
            this.btn_history_search.Size = new System.Drawing.Size(138, 31);
            this.btn_history_search.TabIndex = 29;
            this.btn_history_search.Text = "Search";
            this.btn_history_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_history_search.UseVisualStyleBackColor = false;
            this.btn_history_search.Click += new System.EventHandler(this.btn_history_search_click);
            // 
            // txt_history_search
            // 
            this.txt_history_search.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_history_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_history_search.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_history_search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_history_search.Location = new System.Drawing.Point(151, 17);
            this.txt_history_search.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txt_history_search.Multiline = true;
            this.txt_history_search.Name = "txt_history_search";
            this.txt_history_search.Size = new System.Drawing.Size(350, 28);
            this.txt_history_search.TabIndex = 27;
            this.txt_history_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_up_search_click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(132, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 2);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_history_user);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 544);
            this.panel3.TabIndex = 1;
            // 
            // dgv_history_user
            // 
            this.dgv_history_user.AllowUserToAddRows = false;
            this.dgv_history_user.AllowUserToOrderColumns = true;
            this.dgv_history_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_history_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_history_user.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_history_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_history_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_history_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_history_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history_user.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_history_user.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_history_user.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_history_user.Location = new System.Drawing.Point(12, 6);
            this.dgv_history_user.MultiSelect = false;
            this.dgv_history_user.Name = "dgv_history_user";
            this.dgv_history_user.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_history_user.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_history_user.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_history_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_history_user.Size = new System.Drawing.Size(926, 526);
            this.dgv_history_user.TabIndex = 21;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(950, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_history_search;
        private System.Windows.Forms.TextBox txt_history_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_history_user;
    }
}