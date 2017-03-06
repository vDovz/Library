namespace LibraryClients
{
    partial class MainForm
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
            this.BorrowGrid = new System.Windows.Forms.DataGridView();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BookGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.ButonBorrow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowGrid
            // 
            this.BorrowGrid.AllowUserToDeleteRows = false;
            this.BorrowGrid.AllowUserToResizeColumns = false;
            this.BorrowGrid.AllowUserToResizeRows = false;
            this.BorrowGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.Genre,
            this.Year});
            this.BorrowGrid.Location = new System.Drawing.Point(22, 87);
            this.BorrowGrid.Name = "BorrowGrid";
            this.BorrowGrid.Size = new System.Drawing.Size(263, 220);
            this.BorrowGrid.TabIndex = 3;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.Width = 75;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.Width = 75;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "All books";
            // 
            // BookGrid
            // 
            this.BookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.BookGrid.Location = new System.Drawing.Point(22, 376);
            this.BookGrid.Name = "BookGrid";
            this.BookGrid.Size = new System.Drawing.Size(263, 105);
            this.BookGrid.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Author";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Genre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Year";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(307, 87);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(283, 29);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.Location = new System.Drawing.Point(307, 150);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(283, 29);
            this.textBoxGenre.TabIndex = 7;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(307, 212);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(283, 29);
            this.textBoxYear.TabIndex = 8;
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReturn.Location = new System.Drawing.Point(307, 270);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(116, 37);
            this.ButtonReturn.TabIndex = 9;
            this.ButtonReturn.Text = "Return";
            this.ButtonReturn.UseVisualStyleBackColor = true;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // ButonBorrow
            // 
            this.ButonBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButonBorrow.Location = new System.Drawing.Point(470, 270);
            this.ButonBorrow.Name = "ButonBorrow";
            this.ButonBorrow.Size = new System.Drawing.Size(120, 37);
            this.ButonBorrow.TabIndex = 10;
            this.ButonBorrow.Text = "Borrow";
            this.ButonBorrow.UseVisualStyleBackColor = true;
            this.ButonBorrow.Click += new System.EventHandler(this.ButonBorrow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(303, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(303, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(303, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Year";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdate.Location = new System.Drawing.Point(111, 501);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(91, 38);
            this.ButtonUpdate.TabIndex = 14;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Borrowed book";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(410, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "History";
            // 
            // gridHistory
            // 
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5});
            this.gridHistory.Location = new System.Drawing.Point(307, 376);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.Size = new System.Drawing.Size(283, 105);
            this.gridHistory.TabIndex = 17;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Author";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Genre";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Year";
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Action";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 572);
            this.Controls.Add(this.gridHistory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButonBorrow);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.BookGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BorrowGrid);
            this.Name = "MainForm";
            this.Text = "E-Library";
            ((System.ComponentModel.ISupportInitialize)(this.BorrowGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BookGrid;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Button ButonBorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BorrowGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

