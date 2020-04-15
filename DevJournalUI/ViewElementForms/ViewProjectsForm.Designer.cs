namespace DevJournalUI.ViewElementForms
{
    partial class ViewProjectsForm
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
            this.ProjectsListBox = new System.Windows.Forms.ListBox();
            this.OpenProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.Location = new System.Drawing.Point(29, 58);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.Size = new System.Drawing.Size(218, 264);
            this.ProjectsListBox.TabIndex = 0;
            // 
            // OpenProjectButton
            // 
            this.OpenProjectButton.Location = new System.Drawing.Point(89, 328);
            this.OpenProjectButton.Name = "OpenProjectButton";
            this.OpenProjectButton.Size = new System.Drawing.Size(97, 23);
            this.OpenProjectButton.TabIndex = 1;
            this.OpenProjectButton.Text = "Open Project";
            this.OpenProjectButton.UseVisualStyleBackColor = true;
            // 
            // ViewProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenProjectButton);
            this.Controls.Add(this.ProjectsListBox);
            this.Name = "ViewProjectsForm";
            this.Text = "ViewProjectsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProjectsListBox;
        private System.Windows.Forms.Button OpenProjectButton;
    }
}