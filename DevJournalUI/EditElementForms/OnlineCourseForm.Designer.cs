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
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseTitleValue
            // 
            this.CourseTitleValue.Location = new System.Drawing.Point(81, 12);
            this.CourseTitleValue.Name = "CourseTitleValue";
            this.CourseTitleValue.Size = new System.Drawing.Size(330, 20);
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
            this.CourseLinkValue.Size = new System.Drawing.Size(330, 20);
            this.CourseLinkValue.TabIndex = 2;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(160, 64);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(110, 23);
            this.AddCourseButton.TabIndex = 4;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // OnlineCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 101);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.CourseLinkLabel);
            this.Controls.Add(this.CourseLinkValue);
            this.Controls.Add(this.CourseTitleLabel);
            this.Controls.Add(this.CourseTitleValue);
            this.Name = "OnlineCourseForm";
            this.Text = "OnlineCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseTitleValue;
        private System.Windows.Forms.Label CourseTitleLabel;
        private System.Windows.Forms.Label CourseLinkLabel;
        private System.Windows.Forms.TextBox CourseLinkValue;
        private System.Windows.Forms.Button AddCourseButton;
    }
}