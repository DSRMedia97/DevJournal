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
            this.SuspendLayout();
            // 
            // CoursesListBox
            // 
            this.CoursesListBox.FormattingEnabled = true;
            this.CoursesListBox.Location = new System.Drawing.Point(12, 35);
            this.CoursesListBox.Name = "CoursesListBox";
            this.CoursesListBox.Size = new System.Drawing.Size(408, 212);
            this.CoursesListBox.TabIndex = 0;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(134, 274);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(118, 23);
            this.AddCourseButton.TabIndex = 1;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // OnlineCoursesViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.CoursesListBox);
            this.Name = "OnlineCoursesViewerForm";
            this.Text = "OnlineCoursesViewerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CoursesListBox;
        private System.Windows.Forms.Button AddCourseButton;
    }
}