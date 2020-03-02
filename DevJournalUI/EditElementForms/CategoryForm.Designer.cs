namespace DevJournalUI.EditElementForms
{
    partial class CategoryForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CategoryNameValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(53, 36);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(157, 36);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(13, 13);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(83, 13);
            this.CategoryNameLabel.TabIndex = 3;
            this.CategoryNameLabel.Text = "Category Name:";
            // 
            // CategoryNameValue
            // 
            this.CategoryNameValue.Location = new System.Drawing.Point(102, 10);
            this.CategoryNameValue.Name = "CategoryNameValue";
            this.CategoryNameValue.Size = new System.Drawing.Size(182, 20);
            this.CategoryNameValue.TabIndex = 4;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 73);
            this.Controls.Add(this.CategoryNameValue);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Name = "CategoryForm";
            this.Text = "Add New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.TextBox CategoryNameValue;
    }
}