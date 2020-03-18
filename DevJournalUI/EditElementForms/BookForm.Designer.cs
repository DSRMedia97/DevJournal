namespace DevJournalUI.EditElementForms
{
    partial class BookForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BookSubmitButton = new System.Windows.Forms.Button();
            this.ReadLabel = new System.Windows.Forms.Label();
            this.ReadCheckBoxValue = new System.Windows.Forms.CheckBox();
            this.AvailableCategoriesListBox = new System.Windows.Forms.ListBox();
            this.SelectedCategoriesListBox = new System.Windows.Forms.ListBox();
            this.CategoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedCategoriesLabel = new System.Windows.Forms.Label();
            this.AvailableCategoriesLabel = new System.Windows.Forms.Label();
            this.RemoveFromSelectedButton = new System.Windows.Forms.Button();
            this.AddToSelectedButton = new System.Windows.Forms.Button();
            this.CategoriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(28, 34);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(79, 31);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(79, 57);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorTextBox.TabIndex = 3;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(28, 60);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(79, 83);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(28, 86);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 13);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price:";
            // 
            // BookSubmitButton
            // 
            this.BookSubmitButton.Location = new System.Drawing.Point(79, 166);
            this.BookSubmitButton.Name = "BookSubmitButton";
            this.BookSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.BookSubmitButton.TabIndex = 6;
            this.BookSubmitButton.Text = "Save Book";
            this.BookSubmitButton.UseVisualStyleBackColor = true;
            this.BookSubmitButton.Click += new System.EventHandler(this.BookSubmitButton_Click);
            // 
            // ReadLabel
            // 
            this.ReadLabel.AutoSize = true;
            this.ReadLabel.Location = new System.Drawing.Point(28, 112);
            this.ReadLabel.Name = "ReadLabel";
            this.ReadLabel.Size = new System.Drawing.Size(36, 13);
            this.ReadLabel.TabIndex = 7;
            this.ReadLabel.Text = "Read:";
            // 
            // ReadCheckBoxValue
            // 
            this.ReadCheckBoxValue.AutoSize = true;
            this.ReadCheckBoxValue.Location = new System.Drawing.Point(79, 112);
            this.ReadCheckBoxValue.Name = "ReadCheckBoxValue";
            this.ReadCheckBoxValue.Size = new System.Drawing.Size(15, 14);
            this.ReadCheckBoxValue.TabIndex = 8;
            this.ReadCheckBoxValue.UseVisualStyleBackColor = true;
            // 
            // AvailableCategoriesListBox
            // 
            this.AvailableCategoriesListBox.FormattingEnabled = true;
            this.AvailableCategoriesListBox.Location = new System.Drawing.Point(6, 37);
            this.AvailableCategoriesListBox.Name = "AvailableCategoriesListBox";
            this.AvailableCategoriesListBox.Size = new System.Drawing.Size(115, 134);
            this.AvailableCategoriesListBox.TabIndex = 9;
            // 
            // SelectedCategoriesListBox
            // 
            this.SelectedCategoriesListBox.FormattingEnabled = true;
            this.SelectedCategoriesListBox.Location = new System.Drawing.Point(182, 37);
            this.SelectedCategoriesListBox.Name = "SelectedCategoriesListBox";
            this.SelectedCategoriesListBox.Size = new System.Drawing.Size(120, 134);
            this.SelectedCategoriesListBox.TabIndex = 10;
            // 
            // CategoriesGroupBox
            // 
            this.CategoriesGroupBox.Controls.Add(this.SelectedCategoriesLabel);
            this.CategoriesGroupBox.Controls.Add(this.AvailableCategoriesLabel);
            this.CategoriesGroupBox.Controls.Add(this.RemoveFromSelectedButton);
            this.CategoriesGroupBox.Controls.Add(this.AddToSelectedButton);
            this.CategoriesGroupBox.Controls.Add(this.AvailableCategoriesListBox);
            this.CategoriesGroupBox.Controls.Add(this.SelectedCategoriesListBox);
            this.CategoriesGroupBox.Location = new System.Drawing.Point(211, 12);
            this.CategoriesGroupBox.Name = "CategoriesGroupBox";
            this.CategoriesGroupBox.Size = new System.Drawing.Size(308, 177);
            this.CategoriesGroupBox.TabIndex = 11;
            this.CategoriesGroupBox.TabStop = false;
            this.CategoriesGroupBox.Text = "Edit Categories";
            // 
            // SelectedCategoriesLabel
            // 
            this.SelectedCategoriesLabel.AutoSize = true;
            this.SelectedCategoriesLabel.Location = new System.Drawing.Point(182, 17);
            this.SelectedCategoriesLabel.Name = "SelectedCategoriesLabel";
            this.SelectedCategoriesLabel.Size = new System.Drawing.Size(105, 13);
            this.SelectedCategoriesLabel.TabIndex = 14;
            this.SelectedCategoriesLabel.Text = "Selected Categories:";
            // 
            // AvailableCategoriesLabel
            // 
            this.AvailableCategoriesLabel.AutoSize = true;
            this.AvailableCategoriesLabel.Location = new System.Drawing.Point(7, 18);
            this.AvailableCategoriesLabel.Name = "AvailableCategoriesLabel";
            this.AvailableCategoriesLabel.Size = new System.Drawing.Size(106, 13);
            this.AvailableCategoriesLabel.TabIndex = 13;
            this.AvailableCategoriesLabel.Text = "Available Categories:";
            // 
            // RemoveFromSelectedButton
            // 
            this.RemoveFromSelectedButton.Location = new System.Drawing.Point(127, 93);
            this.RemoveFromSelectedButton.Name = "RemoveFromSelectedButton";
            this.RemoveFromSelectedButton.Size = new System.Drawing.Size(49, 23);
            this.RemoveFromSelectedButton.TabIndex = 12;
            this.RemoveFromSelectedButton.Text = "<<";
            this.RemoveFromSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveFromSelectedButton.Click += new System.EventHandler(this.RemoveFromSelectedButton_Click);
            // 
            // AddToSelectedButton
            // 
            this.AddToSelectedButton.Location = new System.Drawing.Point(127, 64);
            this.AddToSelectedButton.Name = "AddToSelectedButton";
            this.AddToSelectedButton.Size = new System.Drawing.Size(49, 23);
            this.AddToSelectedButton.TabIndex = 11;
            this.AddToSelectedButton.Text = ">>";
            this.AddToSelectedButton.UseVisualStyleBackColor = true;
            this.AddToSelectedButton.Click += new System.EventHandler(this.AddToSelectedButton_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 211);
            this.Controls.Add(this.CategoriesGroupBox);
            this.Controls.Add(this.ReadCheckBoxValue);
            this.Controls.Add(this.ReadLabel);
            this.Controls.Add(this.BookSubmitButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "BookForm";
            this.Text = "Edit Book";
            this.CategoriesGroupBox.ResumeLayout(false);
            this.CategoriesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button BookSubmitButton;
        private System.Windows.Forms.Label ReadLabel;
        private System.Windows.Forms.CheckBox ReadCheckBoxValue;
        private System.Windows.Forms.ListBox AvailableCategoriesListBox;
        private System.Windows.Forms.ListBox SelectedCategoriesListBox;
        private System.Windows.Forms.GroupBox CategoriesGroupBox;
        private System.Windows.Forms.Label SelectedCategoriesLabel;
        private System.Windows.Forms.Label AvailableCategoriesLabel;
        private System.Windows.Forms.Button RemoveFromSelectedButton;
        private System.Windows.Forms.Button AddToSelectedButton;
    }
}

