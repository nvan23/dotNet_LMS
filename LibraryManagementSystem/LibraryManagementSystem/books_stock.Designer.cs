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
            this.dgvBookReturn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooksStock
            // 
            this.dgvBooksStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksStock.Location = new System.Drawing.Point(158, 22);
            this.dgvBooksStock.Name = "dgvBooksStock";
            this.dgvBooksStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksStock.Size = new System.Drawing.Size(1077, 242);
            this.dgvBooksStock.TabIndex = 0;
            this.dgvBooksStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooksStock_CellClick);
            // 
            // dgvBookReturn
            // 
            this.dgvBookReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookReturn.Location = new System.Drawing.Point(158, 295);
            this.dgvBookReturn.Name = "dgvBookReturn";
            this.dgvBookReturn.Size = new System.Drawing.Size(1077, 302);
            this.dgvBookReturn.TabIndex = 1;
            // 
            // books_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 631);
            this.Controls.Add(this.dgvBookReturn);
            this.Controls.Add(this.dgvBooksStock);
            this.Name = "books_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Stock";
            this.Load += new System.EventHandler(this.books_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooksStock;
        private System.Windows.Forms.DataGridView dgvBookReturn;
    }
}