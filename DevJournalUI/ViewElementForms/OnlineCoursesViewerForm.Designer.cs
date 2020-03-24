namespace DevJournalUI.ViewElementForms
{
    partial class OnlineCoursesViewerForm
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
            this.CoursesListBox = new System.Windows.Forms.ListBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.CourseLink = new System.Windows.Forms.LinkLabel();
            this.CourseLinkLabel = new System.Windows.Forms.Label();
            this.EditSelectedCourseButton = new System.Windows.Forms.Button();
            this.FiltersGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.FilterCategoryLabel = new System.Windows.Forms.Label();
            this.FiltersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoursesListBox
            // 
            this.CoursesListBox.FormattingEnabled = true;
            this.CoursesListBox.Location = new System.Drawing.Point(12, 72);
            this.CoursesListBox.Name = "CoursesListBox";
            this.CoursesListBox.Size = new System.Drawing.Size(408, 212);
            this.CoursesListBox.TabIndex = 0;
            this.CoursesListBox.SelectedIndexChanged += new System.EventHandler(this.CoursesListBox_SelectedIndexChanged);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(136, 290);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(118, 23);
            this.AddCourseButton.TabIndex = 1;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // CourseLink
            // 
            this.CourseLink.AutoEllipsis = true;
            this.CourseLink.AutoSize = true;
            this.CourseLink.Location = new System.Drawing.Point(519, 98);
            this.CourseLink.Name = "CourseLink";
            this.CourseLink.Size = new System.Drawing.Size(19, 13);
            this.CourseLink.TabIndex = 2;
            this.CourseLink.TabStop = true;
            this.CourseLink.Text = "<>";
            this.CourseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CourseLink_LinkClicked);
            // 
            // CourseLinkLabel
            // 
            this.CourseLinkLabel.AutoSize = true;
            this.CourseLinkLabel.Location = new System.Drawing.Point(447, 98);
            this.CourseLinkLabel.Name = "CourseLinkLabel";
            this.CourseLinkLabel.Size = new System.Drawing.Size(66, 13);
            this.CourseLinkLabel.TabIndex = 3;
            this.CourseLinkLabel.Text = "Course Link:";
            // 
            // EditSelectedCourseButton
            // 
            this.EditSelectedCourseButton.Location = new System.Drawing.Point(450, 133);
            this.EditSelectedCourseButton.Name = "EditSelectedCourseButton";
            this.EditSelectedCourseButton.Size = new System.Drawing.Size(118, 23);
            this.EditSelectedCourseButton.TabIndex = 4;
            this.EditSelectedCourseButton.Text = "Edit Selected";
            this.EditSelectedCourseButton.UseVisualStyleBackColor = true;
            this.EditSelectedCourseButton.Click += new System.EventHandler(this.EditSelectedCourseButton_Click);
            // 
            // FiltersGroupBox
            // 
            this.FiltersGroupBox.Controls.Add(this.FilterCategoryComboBox);
            this.FiltersGroupBox.Controls.Add(this.FilterCategoryLabel);
            this.FiltersGroupBox.Location = new System.Drawing.Point(12, 13);
            this.FiltersGroupBox.Name = "FiltersGroupBox";
            this.FiltersGroupBox.Size = new System.Drawing.Size(200, 53);
            this.FiltersGroupBox.TabIndex = 5;
            this.FiltersGroupBox.TabStop = false;
            this.FiltersGroupBox.Text = "Filters";
            // 
            // FilterCategoryComboBox
            // 
            this.FilterCategoryComboBox.FormattingEnabled = true;
            this.FilterCategoryComboBox.Location = new System.Drawing.Point(73, 17);
            this.FilterCategoryComboBox.Name = "FilterCategoryComboBox";
            this.FilterCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.FilterCategoryComboBox.TabIndex = 1;
            this.FilterCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterCategoryComboBox_SelectedIndexChanged);
            // 
            // FilterCategoryLabel
            // 
            this.FilterCategoryLabel.AutoSize = true;
            this.FilterCategoryLabel.Location = new System.Drawing.Point(7, 20);
            this.FilterCategoryLabel.Name = "FilterCategoryLabel";
            this.FilterCategoryLabel.Size = new System.Drawing.Size(67, 13);
            this.FilterCategoryLabel.TabIndex = 0;
            this.FilterCategoryLabel.Text = "By Category:";
            // 
            // OnlineCoursesViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.FiltersGroupBox);
            this.Controls.Add(this.EditSelectedCourseButton);
            this.Controls.Add(this.CourseLinkLabel);
            this.Controls.Add(this.CourseLink);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.CoursesListBox);
            this.Name = "OnlineCoursesViewerForm";
            this.Text = "OnlineCoursesViewerForm";
            this.FiltersGroupBox.ResumeLayout(false);
            this.FiltersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CoursesListBox;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.LinkLabel CourseLink;
        private System.Windows.Forms.Label CourseLinkLabel;
        private System.Windows.Forms.Button EditSelectedCourseButton;
        private System.Windows.Forms.GroupBox FiltersGroupBox;
        private System.Windows.Forms.ComboBox FilterCategoryComboBox;
        private System.Windows.Forms.Label FilterCategoryLabel;
    }
}