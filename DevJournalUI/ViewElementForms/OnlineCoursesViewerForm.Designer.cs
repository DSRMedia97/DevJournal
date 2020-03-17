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
            this.SuspendLayout();
            // 
            // CoursesListBox
            // 
            this.CoursesListBox.FormattingEnabled = true;
            this.CoursesListBox.Location = new System.Drawing.Point(12, 35);
            this.CoursesListBox.Name = "CoursesListBox";
            this.CoursesListBox.Size = new System.Drawing.Size(408, 212);
            this.CoursesListBox.TabIndex = 0;
            this.CoursesListBox.SelectedIndexChanged += new System.EventHandler(this.CoursesListBox_SelectedIndexChanged);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(147, 6);
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
            this.CourseLink.Location = new System.Drawing.Point(519, 61);
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
            this.CourseLinkLabel.Location = new System.Drawing.Point(447, 61);
            this.CourseLinkLabel.Name = "CourseLinkLabel";
            this.CourseLinkLabel.Size = new System.Drawing.Size(66, 13);
            this.CourseLinkLabel.TabIndex = 3;
            this.CourseLinkLabel.Text = "Course Link:";
            // 
            // OnlineCoursesViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.CourseLinkLabel);
            this.Controls.Add(this.CourseLink);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.CoursesListBox);
            this.Name = "OnlineCoursesViewerForm";
            this.Text = "OnlineCoursesViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CoursesListBox;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.LinkLabel CourseLink;
        private System.Windows.Forms.Label CourseLinkLabel;
    }
}