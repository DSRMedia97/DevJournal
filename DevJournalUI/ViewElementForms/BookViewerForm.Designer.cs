namespace DevJournalUI.ViewElementForms
{
    partial class BookViewerForm
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
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.NewBookButton = new System.Windows.Forms.Button();
            this.EditBookButton = new System.Windows.Forms.Button();
            this.SelectedBookTitleLabel = new System.Windows.Forms.Label();
            this.SelectedBookAuthorLabel = new System.Windows.Forms.Label();
            this.SelectedBookPriceLabel = new System.Windows.Forms.Label();
            this.SelectedBookReadLabel = new System.Windows.Forms.Label();
            this.SelectedBookAuthorValue = new System.Windows.Forms.Label();
            this.SelectedBookPriceValue = new System.Windows.Forms.Label();
            this.SelectedBookReadValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookListBox
            // 
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.Location = new System.Drawing.Point(37, 105);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(213, 225);
            this.BookListBox.TabIndex = 0;
            this.BookListBox.SelectedIndexChanged += new System.EventHandler(this.BookListBox_SelectedIndexChanged);
            // 
            // NewBookButton
            // 
            this.NewBookButton.Location = new System.Drawing.Point(92, 336);
            this.NewBookButton.Name = "NewBookButton";
            this.NewBookButton.Size = new System.Drawing.Size(98, 23);
            this.NewBookButton.TabIndex = 1;
            this.NewBookButton.Text = "Add New Book";
            this.NewBookButton.UseVisualStyleBackColor = true;
            this.NewBookButton.Click += new System.EventHandler(this.NewBookButton_Click);
            // 
            // EditBookButton
            // 
            this.EditBookButton.Location = new System.Drawing.Point(92, 365);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(98, 23);
            this.EditBookButton.TabIndex = 2;
            this.EditBookButton.Text = "Edit Selected";
            this.EditBookButton.UseVisualStyleBackColor = true;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click);
            // 
            // SelectedBookTitleLabel
            // 
            this.SelectedBookTitleLabel.AutoSize = true;
            this.SelectedBookTitleLabel.Location = new System.Drawing.Point(328, 105);
            this.SelectedBookTitleLabel.Name = "SelectedBookTitleLabel";
            this.SelectedBookTitleLabel.Size = new System.Drawing.Size(22, 13);
            this.SelectedBookTitleLabel.TabIndex = 3;
            this.SelectedBookTitleLabel.Text = "< >";
            // 
            // SelectedBookAuthorLabel
            // 
            this.SelectedBookAuthorLabel.AutoSize = true;
            this.SelectedBookAuthorLabel.Location = new System.Drawing.Point(328, 135);
            this.SelectedBookAuthorLabel.Name = "SelectedBookAuthorLabel";
            this.SelectedBookAuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.SelectedBookAuthorLabel.TabIndex = 4;
            this.SelectedBookAuthorLabel.Text = "Author:";
            // 
            // SelectedBookPriceLabel
            // 
            this.SelectedBookPriceLabel.AutoSize = true;
            this.SelectedBookPriceLabel.Location = new System.Drawing.Point(328, 148);
            this.SelectedBookPriceLabel.Name = "SelectedBookPriceLabel";
            this.SelectedBookPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.SelectedBookPriceLabel.TabIndex = 5;
            this.SelectedBookPriceLabel.Text = "Price";
            // 
            // SelectedBookReadLabel
            // 
            this.SelectedBookReadLabel.AutoSize = true;
            this.SelectedBookReadLabel.Location = new System.Drawing.Point(328, 161);
            this.SelectedBookReadLabel.Name = "SelectedBookReadLabel";
            this.SelectedBookReadLabel.Size = new System.Drawing.Size(36, 13);
            this.SelectedBookReadLabel.TabIndex = 6;
            this.SelectedBookReadLabel.Text = "Read:";
            // 
            // SelectedBookAuthorValue
            // 
            this.SelectedBookAuthorValue.AutoSize = true;
            this.SelectedBookAuthorValue.Location = new System.Drawing.Point(376, 135);
            this.SelectedBookAuthorValue.Name = "SelectedBookAuthorValue";
            this.SelectedBookAuthorValue.Size = new System.Drawing.Size(22, 13);
            this.SelectedBookAuthorValue.TabIndex = 7;
            this.SelectedBookAuthorValue.Text = "< >";
            // 
            // SelectedBookPriceValue
            // 
            this.SelectedBookPriceValue.AutoSize = true;
            this.SelectedBookPriceValue.Location = new System.Drawing.Point(376, 148);
            this.SelectedBookPriceValue.Name = "SelectedBookPriceValue";
            this.SelectedBookPriceValue.Size = new System.Drawing.Size(22, 13);
            this.SelectedBookPriceValue.TabIndex = 8;
            this.SelectedBookPriceValue.Text = "< >";
            // 
            // SelectedBookReadValue
            // 
            this.SelectedBookReadValue.AutoSize = true;
            this.SelectedBookReadValue.Location = new System.Drawing.Point(376, 161);
            this.SelectedBookReadValue.Name = "SelectedBookReadValue";
            this.SelectedBookReadValue.Size = new System.Drawing.Size(22, 13);
            this.SelectedBookReadValue.TabIndex = 9;
            this.SelectedBookReadValue.Text = "< >";
            // 
            // BookViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.SelectedBookReadValue);
            this.Controls.Add(this.SelectedBookPriceValue);
            this.Controls.Add(this.SelectedBookAuthorValue);
            this.Controls.Add(this.SelectedBookReadLabel);
            this.Controls.Add(this.SelectedBookPriceLabel);
            this.Controls.Add(this.SelectedBookAuthorLabel);
            this.Controls.Add(this.SelectedBookTitleLabel);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.NewBookButton);
            this.Controls.Add(this.BookListBox);
            this.Name = "BookViewerForm";
            this.Text = "BookViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookListBox;
        private System.Windows.Forms.Button NewBookButton;
        private System.Windows.Forms.Button EditBookButton;
        private System.Windows.Forms.Label SelectedBookTitleLabel;
        private System.Windows.Forms.Label SelectedBookAuthorLabel;
        private System.Windows.Forms.Label SelectedBookPriceLabel;
        private System.Windows.Forms.Label SelectedBookReadLabel;
        private System.Windows.Forms.Label SelectedBookAuthorValue;
        private System.Windows.Forms.Label SelectedBookPriceValue;
        private System.Windows.Forms.Label SelectedBookReadValue;
    }
}