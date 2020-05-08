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
            this.dgvBooksStock = new System.Windows.Forms.DataGridView();
            this.dgvBookReturn_stock = new System.Windows.Forms.DataGridView();
            this.txtSearchBooksStock = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend_stock = new System.Windows.Forms.Button();
            this.txtContent_stock = new System.Windows.Forms.TextBox();
            this.txtEmail_stock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReturn_stock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooksStock
            // 
            this.dgvBooksStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksStock.Location = new System.Drawing.Point(279, 22);
            this.dgvBooksStock.Name = "dgvBooksStock";
            this.dgvBooksStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksStock.Size = new System.Drawing.Size(912, 242);
            this.dgvBooksStock.TabIndex = 0;
            this.dgvBooksStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooksStock_CellClick);
            // 
            // dgvBookReturn_stock
            // 
            this.dgvBookReturn_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookReturn_stock.Location = new System.Drawing.Point(279, 295);
            this.dgvBookReturn_stock.Name = "dgvBookReturn_stock";
            this.dgvBookReturn_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookReturn_stock.Size = new System.Drawing.Size(912, 302);
            this.dgvBookReturn_stock.TabIndex = 1;
            this.dgvBookReturn_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookReturn_CellClick);
            // 
            // txtSearchBooksStock
            // 
            this.txtSearchBooksStock.Location = new System.Drawing.Point(42, 22);
            this.txtSearchBooksStock.Name = "txtSearchBooksStock";
            this.txtSearchBooksStock.Size = new System.Drawing.Size(219, 20);
            this.txtSearchBooksStock.TabIndex = 2;
            this.txtSearchBooksStock.TextChanged += new System.EventHandler(this.txtSearchBooksStock_TextChanged);
            this.txtSearchBooksStock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBooksStock_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend_stock);
            this.panel1.Controls.Add(this.txtContent_stock);
            this.panel1.Controls.Add(this.txtEmail_stock);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 340);
            this.panel1.TabIndex = 3;
            // 
            // btnSend_stock
            // 
            this.btnSend_stock.Location = new System.Drawing.Point(21, 301);
            this.btnSend_stock.Name = "btnSend_stock";
            this.btnSend_stock.Size = new System.Drawing.Size(207, 23);
            this.btnSend_stock.TabIndex = 4;
            this.btnSend_stock.Text = "Send";
            this.btnSend_stock.UseVisualStyleBackColor = true;
            this.btnSend_stock.Click += new System.EventHandler(this.btnSend_stock_Click);
            // 
            // txtContent_stock
            // 
            this.txtContent_stock.Location = new System.Drawing.Point(21, 88);
            this.txtContent_stock.Multiline = true;
            this.txtContent_stock.Name = "txtContent_stock";
            this.txtContent_stock.Size = new System.Drawing.Size(204, 194);
            this.txtContent_stock.TabIndex = 3;
            // 
            // txtEmail_stock
            // 
            this.txtEmail_stock.Location = new System.Drawing.Point(21, 38);
            this.txtEmail_stock.Name = "txtEmail_stock";
            this.txtEmail_stock.Size = new System.Drawing.Size(204, 20);
            this.txtEmail_stock.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search book in stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "The results after searching book in stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "List of book was borrowed";
            // 
            // books_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearchBooksStock);
            this.Controls.Add(this.dgvBookReturn_stock);
            this.Controls.Add(this.dgvBooksStock);
            this.Name = "books_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Stock";
            this.Load += new System.EventHandler(this.books_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReturn_stock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooksStock;
        private System.Windows.Forms.DataGridView dgvBookReturn_stock;
        private System.Windows.Forms.TextBox txtSearchBooksStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend_stock;
        private System.Windows.Forms.TextBox txtContent_stock;
        private System.Windows.Forms.TextBox txtEmail_stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}