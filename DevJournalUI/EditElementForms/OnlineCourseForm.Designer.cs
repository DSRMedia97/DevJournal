namespace DevJournalUI.EditElementForms
{
    partial class OnlineCourseForm
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
            this.CourseTitleValue = new System.Windows.Forms.TextBox();
            this.CourseTitleLabel = new System.Windows.Forms.Label();
            this.CourseLinkLabel = new System.Windows.Forms.Label();
            this.CourseLinkValue = new System.Windows.Forms.TextBox();
            this.SaveCourseButton = new System.Windows.Forms.Button();
            this.CategoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedCategoriesListBox = new System.Windows.Forms.ListBox();
            this.RemoveFromSelectedCategoriesButton = new System.Windows.Forms.Button();
            this.AddToSelectedCategoriesButton = new System.Windows.Forms.Button();
            this.AvailableCategoriesListBox = new System.Windows.Forms.ListBox();
            this.CategoriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseTitleValue
            // 
            this.CourseTitleValue.Location = new System.Drawing.Point(81, 12);
            this.CourseTitleValue.Name = "CourseTitleValue";
            this.CourseTitleValue.Size = new System.Drawing.Size(376, 20);
            this.CourseTitleValue.TabIndex = 0;
            // 
            // CourseTitleLabel
            // 
            this.CourseTitleLabel.AutoSize = true;
            this.CourseTitleLabel.Location = new System.Drawing.Point(9, 15);
            this.CourseTitleLabel.Name = "CourseTitleLabel";
            this.CourseTitleLabel.Size = new System.Drawing.Size(66, 13);
            this.CourseTitleLabel.TabIndex = 1;
            this.CourseTitleLabel.Text = "Course Title:";
            // 
            // CourseLinkLabel
            // 
            this.CourseLinkLabel.AutoSize = true;
            this.CourseLinkLabel.Location = new System.Drawing.Point(9, 41);
            this.CourseLinkLabel.Name = "CourseLinkLabel";
            this.CourseLinkLabel.Size = new System.Drawing.Size(66, 13);
            this.CourseLinkLabel.TabIndex = 3;
            this.CourseLinkLabel.Text = "Course Link:";
            // 
            // CourseLinkValue
            // 
            this.CourseLinkValue.Location = new System.Drawing.Point(81, 38);
            this.CourseLinkValue.Name = "CourseLinkValue";
            this.CourseLinkValue.Size = new System.Drawing.Size(376, 20);
            this.CourseLinkValue.TabIndex = 2;
            // 
            // SaveCourseButton
            // 
            this.SaveCourseButton.Location = new System.Drawing.Point(176, 283);
            this.SaveCourseButton.Name = "SaveCourseButton";
            this.SaveCourseButton.Size = new System.Drawing.Size(110, 23);
            this.SaveCourseButton.TabIndex = 4;
            this.SaveCourseButton.Text = "Save Course";
            this.SaveCourseButton.UseVisualStyleBackColor = true;
            this.SaveCourseButton.Click += new System.EventHandler(this.SaveCourseButton_Click);
            // 
            // CategoriesGroupBox
            // 
            this.CategoriesGroupBox.Controls.Add(this.SelectedCategoriesListBox);
            this.CategoriesGroupBox.Controls.Add(this.RemoveFromSelectedCategoriesButton);
            this.CategoriesGroupBox.Controls.Add(this.AddToSelectedCategoriesButton);
            this.CategoriesGroupBox.Controls.Add(this.AvailableCategoriesListBox);
            this.CategoriesGroupBox.Location = new System.Drawing.Point(13, 72);
            this.CategoriesGroupBox.Name = "CategoriesGroupBox";
            this.CategoriesGroupBox.Size = new System.Drawing.Size(444, 205);
            this.CategoriesGroupBox.TabIndex = 5;
            this.CategoriesGroupBox.TabStop = false;
            this.CategoriesGroupBox.Text = "Assign Categories";
            // 
            // SelectedCategoriesListBox
            // 
            this.SelectedCategoriesListBox.FormattingEnabled = true;
            this.SelectedCategoriesListBox.Location = new System.Drawing.Point(260, 20);
            this.SelectedCategoriesListBox.Name = "SelectedCategoriesListBox";
            this.SelectedCategoriesListBox.Size = new System.Drawing.Size(175, 173);
            this.SelectedCategoriesListBox.TabIndex = 3;
            // 
            // RemoveFromSelectedCategoriesButton
            // 
            this.RemoveFromSelectedCategoriesButton.Location = new System.Drawing.Point(188, 108);
            this.RemoveFromSelectedCategoriesButton.Name = "RemoveFromSelectedCategoriesButton";
            this.RemoveFromSelectedCategoriesButton.Size = new System.Drawing.Size(66, 23);
            this.RemoveFromSelectedCategoriesButton.TabIndex = 2;
            this.RemoveFromSelectedCategoriesButton.Text = "<<";
            this.RemoveFromSelectedCategoriesButton.UseVisualStyleBackColor = true;
            this.RemoveFromSelectedCategoriesButton.Click += new System.EventHandler(this.RemoveFromSelectedCategoriesButton_Click);
            // 
            // AddToSelectedCategoriesButton
            // 
            this.AddToSelectedCategoriesButton.Location = new System.Drawing.Point(188, 78);
            this.AddToSelectedCategoriesButton.Name = "AddToSelectedCategoriesButton";
            this.AddToSelectedCategoriesButton.Size = new System.Drawing.Size(66, 23);
            this.AddToSelectedCategoriesButton.TabIndex = 1;
            this.AddToSelectedCategoriesButton.Text = ">>";
            this.AddToSelectedCategoriesButton.UseVisualStyleBackColor = true;
            this.AddToSelectedCategoriesButton.Click += new System.EventHandler(this.AddToSelectedCategoriesButton_Click);
            // 
            // AvailableCategoriesListBox
            // 
            this.AvailableCategoriesListBox.FormattingEnabled = true;
            this.AvailableCategoriesListBox.Location = new System.Drawing.Point(7, 20);
            this.AvailableCategoriesListBox.Name = "AvailableCategoriesListBox";
            this.AvailableCategoriesListBox.Size = new System.Drawing.Size(175, 173);
            this.AvailableCategoriesListBox.TabIndex = 0;
            // 
            // OnlineCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 318);
            this.Controls.Add(this.CategoriesGroupBox);
            this.Controls.Add(this.SaveCourseButton);
            this.Controls.Add(this.CourseLinkLabel);
            this.Controls.Add(this.CourseLinkValue);
            this.Controls.Add(this.CourseTitleLabel);
            this.Controls.Add(this.CourseTitleValue);
            this.Name = "OnlineCourseForm";
            this.Text = "OnlineCourseForm";
            this.CategoriesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseTitleValue;
        private System.Windows.Forms.Label CourseTitleLabel;
        private System.Windows.Forms.Label CourseLinkLabel;
        private System.Windows.Forms.TextBox CourseLinkValue;
        private System.Windows.Forms.Button SaveCourseButton;
        private System.Windows.Forms.GroupBox CategoriesGroupBox;
        private System.Windows.Forms.ListBox SelectedCategoriesListBox;
        private System.Windows.Forms.Button RemoveFromSelectedCategoriesButton;
        private System.Windows.Forms.Button AddToSelectedCategoriesButton;
        private System.Windows.Forms.ListBox AvailableCategoriesListBox;
    }
}