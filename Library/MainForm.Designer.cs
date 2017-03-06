namespace Library
{
    partial class PersonalForm
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
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.SearchGrid = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.Location = new System.Drawing.Point(452, 166);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(161, 32);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = " Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Author";
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Location = new System.Drawing.Point(22, 87);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(590, 20);
            this.TextBoxGenre.TabIndex = 11;
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Location = new System.Drawing.Point(22, 134);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(590, 20);
            this.TextBoxYear.TabIndex = 10;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(22, 166);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(161, 32);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.Location = new System.Drawing.Point(22, 43);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(590, 20);
            this.TextBoxAuthor.TabIndex = 8;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRemove.Location = new System.Drawing.Point(244, 166);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(161, 32);
            this.ButtonRemove.TabIndex = 17;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // SearchGrid
            // 
            this.SearchGrid.AllowUserToOrderColumns = true;
            this.SearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.Genre,
            this.Year});
            this.SearchGrid.Location = new System.Drawing.Point(26, 244);
            this.SearchGrid.Name = "SearchGrid";
            this.SearchGrid.Size = new System.Drawing.Size(586, 187);
            this.SearchGrid.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(22, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Search result";
            // 
            // Author
            // 
            this.Author.FillWeight = 200F;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.Width = 180;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.Width = 180;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.Width = 180;
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 452);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SearchGrid);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxGenre);
            this.Controls.Add(this.TextBoxYear);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxAuthor);
            this.Controls.Add(this.ButtonSearch);
            this.Name = "PersonalForm";
            this.Text = "Application for personal";
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.DataGridView SearchGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    }
}

