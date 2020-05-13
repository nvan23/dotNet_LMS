namespace LibraryManagementSystem
{
    partial class books_stock
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
            this.dgvBook_stock = new System.Windows.Forms.DataGridView();
            this.txtSearchBooksStock = new System.Windows.Forms.TextBox();
            this.txtContent_stock = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchStudent = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSend_stock = new FontAwesome.Sharp.IconButton();
            this.txtEmail_stock = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvBookReturn_stock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook_stock)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReturn_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBook_stock
            // 
            this.dgvBook_stock.AllowUserToAddRows = false;
            this.dgvBook_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBook_stock.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBook_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvBook_stock.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBook_stock.Location = new System.Drawing.Point(9, 6);
            this.dgvBook_stock.Name = "dgvBook_stock";
            this.dgvBook_stock.ReadOnly = true;
            this.dgvBook_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook_stock.Size = new System.Drawing.Size(773, 238);
            this.dgvBook_stock.TabIndex = 1;
            this.dgvBook_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooksStock_CellClick);
            // 
            // txtSearchBooksStock
            // 
            this.txtSearchBooksStock.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearchBooksStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBooksStock.Location = new System.Drawing.Point(145, 15);
            this.txtSearchBooksStock.Multiline = true;
            this.txtSearchBooksStock.Name = "txtSearchBooksStock";
            this.txtSearchBooksStock.Size = new System.Drawing.Size(603, 26);
            this.txtSearchBooksStock.TabIndex = 2;
            this.txtSearchBooksStock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBooksStock_KeyUp);
            // 
            // txtContent_stock
            // 
            this.txtContent_stock.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContent_stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent_stock.Location = new System.Drawing.Point(14, 54);
            this.txtContent_stock.Multiline = true;
            this.txtContent_stock.Name = "txtContent_stock";
            this.txtContent_stock.Size = new System.Drawing.Size(261, 349);
            this.txtContent_stock.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchStudent);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSend_stock);
            this.panel2.Controls.Add(this.txtSearchBooksStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 50);
            this.panel2.TabIndex = 5;
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
            this.btnSearchStudent.Location = new System.Drawing.Point(9, 9);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchStudent.Rotation = 0D;
            this.btnSearchStudent.Size = new System.Drawing.Size(133, 31);
            this.btnSearchStudent.TabIndex = 32;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(129, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 2);
            this.panel3.TabIndex = 31;
            // 
            // btnSend_stock
            // 
            this.btnSend_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSend_stock.FlatAppearance.BorderSize = 0;
            this.btnSend_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend_stock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSend_stock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend_stock.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSend_stock.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSend_stock.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnSend_stock.IconSize = 20;
            this.btnSend_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend_stock.Location = new System.Drawing.Point(802, 9);
            this.btnSend_stock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend_stock.Name = "btnSend_stock";
            this.btnSend_stock.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSend_stock.Rotation = 0D;
            this.btnSend_stock.Size = new System.Drawing.Size(261, 31);
            this.btnSend_stock.TabIndex = 32;
            this.btnSend_stock.Text = "Send Mail";
            this.btnSend_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSend_stock.UseVisualStyleBackColor = false;
            this.btnSend_stock.Click += new System.EventHandler(this.btnSend_stock_Click);
            // 
            // txtEmail_stock
            // 
            this.txtEmail_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            this.txtEmail_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail_stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail_stock.ForeColor = System.Drawing.Color.Black;
            this.txtEmail_stock.Location = new System.Drawing.Point(14, 10);
            this.txtEmail_stock.Multiline = true;
            this.txtEmail_stock.Name = "txtEmail_stock";
            this.txtEmail_stock.ReadOnly = true;
            this.txtEmail_stock.Size = new System.Drawing.Size(261, 31);
            this.txtEmail_stock.TabIndex = 33;
            this.txtEmail_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1075, 2);
            this.panel5.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtEmail_stock);
            this.panel1.Controls.Add(this.txtContent_stock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(788, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 596);
            this.panel1.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(27, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Content Email";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Controls.Add(this.dgvBook_stock);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 250);
            this.panel4.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 302);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(788, 2);
            this.panel6.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvBookReturn_stock);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 304);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(788, 344);
            this.panel7.TabIndex = 37;
            // 
            // dgvBookReturn_stock
            // 
            this.dgvBookReturn_stock.AllowUserToAddRows = false;
            this.dgvBookReturn_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookReturn_stock.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBookReturn_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookReturn_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookReturn_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookReturn_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookReturn_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvBookReturn_stock.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBookReturn_stock.Location = new System.Drawing.Point(9, 6);
            this.dgvBookReturn_stock.Name = "dgvBookReturn_stock";
            this.dgvBookReturn_stock.ReadOnly = true;
            this.dgvBookReturn_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookReturn_stock.Size = new System.Drawing.Size(773, 338);
            this.dgvBookReturn_stock.TabIndex = 2;
            this.dgvBookReturn_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookReturn_CellClick);
            // 
            // books_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1075, 648);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Name = "books_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Stock";
            this.Load += new System.EventHandler(this.books_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook_stock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReturn_stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBook_stock;
        private System.Windows.Forms.TextBox txtSearchBooksStock;
        private System.Windows.Forms.TextBox txtContent_stock;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSearchStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail_stock;
        private FontAwesome.Sharp.IconButton btnSend_stock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvBookReturn_stock;
        private System.Windows.Forms.Label label10;
    }
}