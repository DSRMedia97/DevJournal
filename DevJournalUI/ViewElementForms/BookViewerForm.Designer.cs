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
            this.SelectedBookReadValue = new System.Windows.Forms.CheckBox();
            this.UnreadOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalCostValue = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.FilterListGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterCategoryLabel = new System.Windows.Forms.Label();
            this.FilterCategoryDropdown = new System.Windows.Forms.ComboBox();
            this.SelectedBookDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterListGroupBox.SuspendLayout();
            this.SelectedBookDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookListBox
            // 
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.Location = new System.Drawing.Point(10, 94);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(320, 225);
            this.BookListBox.TabIndex = 0;
            this.BookListBox.SelectedIndexChanged += new System.EventHandler(this.BookListBox_SelectedIndexChanged);
            // 
            // NewBookButton
            // 
            this.NewBookButton.Location = new System.Drawing.Point(65, 325);
            this.NewBookButton.Name = "NewBookButton";
            this.NewBookButton.Size = new System.Drawing.Size(98, 23);
            this.NewBookButton.TabIndex = 1;
            this.NewBookButton.Text = "Add New Book";
            this.NewBookButton.UseVisualStyleBackColor = true;
            this.NewBookButton.Click += new System.EventHandler(this.NewBookButton_Click);
            // 
            // EditBookButton
            // 
            this.EditBookButton.Location = new System.Drawing.Point(426, 262);
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
            this.SelectedBookTitleLabel.Location = new System.Drawing.Point(22, 18);
            this.SelectedBookTitleLabel.MaximumSize = new System.Drawing.Size(260, 0);
            this.SelectedBookTitleLabel.Name = "SelectedBookTitleLabel";
            this.SelectedBookTitleLabel.Size = new System.Drawing.Size(22, 13);
            this.SelectedBookTitleLabel.TabIndex = 3;
            this.SelectedBookTitleLabel.Text = "< >";
            // 
            // SelectedBookAuthorLabel
            // 
            this.SelectedBookAuthorLabel.AutoSize = true;
            this.SelectedBookAuthorLabel.Location = new System.Drawing.Point(22, 48);
            this.SelectedBookAuthorLabel.Name = "SelectedBookAuthorLabel";
            this.SelectedBookAuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.SelectedBookAuthorLabel.TabIndex = 4;
            this.SelectedBookAuthorLabel.Text = "Author:";
            // 
            // SelectedBookPriceLabel
            // 
            this.SelectedBookPriceLabel.AutoSize = true;
            this.SelectedBookPriceLabel.Location = new System.Drawing.Point(22, 61);
            this.SelectedBookPriceLabel.Name = "SelectedBookPriceLabel";
            this.SelectedBookPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.SelectedBookPriceLabel.TabIndex = 5;
            this.SelectedBookPriceLabel.Text = "Price";
            // 
            // SelectedBookReadLabel
            // 
            this.SelectedBookReadLabel.AutoSize = true;
            this.SelectedBookReadLabel.Location = new System.Drawing.Point(22, 78);
            this.SelectedBookReadLabel.Name = "SelectedBookReadLabel";
            this.SelectedBookReadLabel.Size = new System.Drawing.Size(36, 13);
            this.SelectedBookReadLabel.TabIndex = 6;
            this.SelectedBookReadLabel.Text = "Read:";
            // 
            // SelectedBookAuthorValue
            // 
            this.SelectedBookAuthorValue.AutoSize = true;
            this.SelectedBookAuthorValue.Location = new System.Drawing.Point(70, 48);
            this.SelectedBookAuthorValue.Name = "SelectedBookAuthorValue";
            this.SelectedBookAuthorValue.Size = new System.Drawing.Size(22, 13);
            this.SelectedBookAuthorValue.TabIndex = 7;
            this.SelectedBookAuthorValue.Text = "< >";
            // 
            // SelectedBookPriceValue
            // 
            this.SelectedBookPriceValue.AutoSize = true;
            this.SelectedBookPriceValue.Location = new System.Drawing.Point(70, 61);
            this.SelectedBookPriceValue.Name = "SelectedBookPriceValue";
            this.SelectedBookPriceValue.Size = new System.Drawing.Size(22, 13);
            this.SelectedBookPriceValue.TabIndex = 8;
            this.SelectedBookPriceValue.Text = "< >";
            // 
            // SelectedBookReadValue
            // 
            this.SelectedBookReadValue.AutoSize = true;
            this.SelectedBookReadValue.Enabled = false;
            this.SelectedBookReadValue.Location = new System.Drawing.Point(73, 77);
            this.SelectedBookReadValue.Name = "SelectedBookReadValue";
            this.SelectedBookReadValue.Size = new System.Drawing.Size(15, 14);
            this.SelectedBookReadValue.TabIndex = 10;
            this.SelectedBookReadValue.UseVisualStyleBackColor = true;
            // 
            // UnreadOnlyCheckBox
            // 
            this.UnreadOnlyCheckBox.AutoSize = true;
            this.UnreadOnlyCheckBox.Location = new System.Drawing.Point(44, 46);
            this.UnreadOnlyCheckBox.Name = "UnreadOnlyCheckBox";
            this.UnreadOnlyCheckBox.Size = new System.Drawing.Size(118, 17);
            this.UnreadOnlyCheckBox.TabIndex = 11;
            this.UnreadOnlyCheckBox.Text = "Unread Books Only";
            this.UnreadOnlyCheckBox.UseVisualStyleBackColor = true;
            this.UnreadOnlyCheckBox.CheckedChanged += new System.EventHandler(this.UnreadOnlyCheckBox_CheckedChanged);
            // 
            // TotalCostValue
            // 
            this.TotalCostValue.AutoSize = true;
            this.TotalCostValue.Location = new System.Drawing.Point(267, 330);
            this.TotalCostValue.Name = "TotalCostValue";
            this.TotalCostValue.Size = new System.Drawing.Size(22, 13);
            this.TotalCostValue.TabIndex = 13;
            this.TotalCostValue.Text = "< >";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(203, 330);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.TotalCostLabel.TabIndex = 12;
            this.TotalCostLabel.Text = "Total Cost:";
            // 
            // FilterListGroupBox
            // 
            this.FilterListGroupBox.Controls.Add(this.FilterCategoryLabel);
            this.FilterListGroupBox.Controls.Add(this.FilterCategoryDropdown);
            this.FilterListGroupBox.Controls.Add(this.UnreadOnlyCheckBox);
            this.FilterListGroupBox.Location = new System.Drawing.Point(10, 16);
            this.FilterListGroupBox.Name = "FilterListGroupBox";
            this.FilterListGroupBox.Size = new System.Drawing.Size(213, 72);
            this.FilterListGroupBox.TabIndex = 16;
            this.FilterListGroupBox.TabStop = false;
            this.FilterListGroupBox.Text = "Filters";
            // 
            // FilterCategoryLabel
            // 
            this.FilterCategoryLabel.AutoSize = true;
            this.FilterCategoryLabel.Location = new System.Drawing.Point(7, 22);
            this.FilterCategoryLabel.Name = "FilterCategoryLabel";
            this.FilterCategoryLabel.Size = new System.Drawing.Size(67, 13);
            this.FilterCategoryLabel.TabIndex = 13;
            this.FilterCategoryLabel.Text = "By Category:";
            // 
            // FilterCategoryDropdown
            // 
            this.FilterCategoryDropdown.FormattingEnabled = true;
            this.FilterCategoryDropdown.Location = new System.Drawing.Point(80, 19);
            this.FilterCategoryDropdown.Name = "FilterCategoryDropdown";
            this.FilterCategoryDropdown.Size = new System.Drawing.Size(127, 21);
            this.FilterCategoryDropdown.TabIndex = 12;
            this.FilterCategoryDropdown.SelectedIndexChanged += new System.EventHandler(this.FilterCategoryDropdown_SelectedIndexChanged);
            // 
            // SelectedBookDetailsGroupBox
            // 
            this.SelectedBookDetailsGroupBox.Controls.Add(this.SelectedBookAuthorLabel);
            this.SelectedBookDetailsGroupBox.Controls.Add(this.SelectedBookTitleLabel);
            this.SelectedBookDetailsGroupBox.Controls.Add(this.SelectedBookPriceLabel);
            this.SelectedBookDetailsGroupBox.Controls.Add(this.SelectedBookReadLabel);
            this.SelectedBookDetailsGroupBox.Controls.Add(this.SelectedBookAuthorValue);
            this.SelectedBookDetailsGroupBox.Controls.Add(this.SelectedBookPriceValue);
            this.SelectedBookDetailsGroupBox.Controls.Add(this.SelectedBookReadValue);
            this.SelectedBookDetailsGroupBox.Location = new System.Drawing.Point(336, 94);
            this.SelectedBookDetailsGroupBox.Name = "SelectedBookDetailsGroupBox";
            this.SelectedBookDetailsGroupBox.Size = new System.Drawing.Size(284, 162);
            this.SelectedBookDetailsGroupBox.TabIndex = 17;
            this.SelectedBookDetailsGroupBox.TabStop = false;
            this.SelectedBookDetailsGroupBox.Text = "Current Book";
            // 
            // BookViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 368);
            this.Controls.Add(this.SelectedBookDetailsGroupBox);
            this.Controls.Add(this.FilterListGroupBox);
            this.Controls.Add(this.TotalCostValue);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.NewBookButton);
            this.Controls.Add(this.BookListBox);
            this.Name = "BookViewerForm";
            this.Text = "BookViewerForm";
            this.FilterListGroupBox.ResumeLayout(false);
            this.FilterListGroupBox.PerformLayout();
            this.SelectedBookDetailsGroupBox.ResumeLayout(false);
            this.SelectedBookDetailsGroupBox.PerformLayout();
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
        private System.Windows.Forms.CheckBox SelectedBookReadValue;
        private System.Windows.Forms.CheckBox UnreadOnlyCheckBox;
        private System.Windows.Forms.Label TotalCostValue;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.GroupBox FilterListGroupBox;
        private System.Windows.Forms.GroupBox SelectedBookDetailsGroupBox;
        private System.Windows.Forms.Label FilterCategoryLabel;
        private System.Windows.Forms.ComboBox FilterCategoryDropdown;
    }
}