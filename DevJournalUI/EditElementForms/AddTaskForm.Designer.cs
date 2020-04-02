namespace DevJournalUI.EditElementForms
{
    partial class AddTaskForm
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionValue = new System.Windows.Forms.TextBox();
            this.EstimatedTimeLabel = new System.Windows.Forms.Label();
            this.EstimatedTimeValue = new System.Windows.Forms.TextBox();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.TaskNameValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(105, 164);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 56);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionValue
            // 
            this.DescriptionValue.Location = new System.Drawing.Point(12, 72);
            this.DescriptionValue.Multiline = true;
            this.DescriptionValue.Name = "DescriptionValue";
            this.DescriptionValue.Size = new System.Drawing.Size(271, 62);
            this.DescriptionValue.TabIndex = 1;
            // 
            // EstimatedTimeLabel
            // 
            this.EstimatedTimeLabel.AutoSize = true;
            this.EstimatedTimeLabel.Location = new System.Drawing.Point(15, 141);
            this.EstimatedTimeLabel.Name = "EstimatedTimeLabel";
            this.EstimatedTimeLabel.Size = new System.Drawing.Size(150, 13);
            this.EstimatedTimeLabel.TabIndex = 3;
            this.EstimatedTimeLabel.Text = "Estimated Hours To Complete:";
            // 
            // EstimatedTimeValue
            // 
            this.EstimatedTimeValue.Location = new System.Drawing.Point(171, 138);
            this.EstimatedTimeValue.Name = "EstimatedTimeValue";
            this.EstimatedTimeValue.Size = new System.Drawing.Size(112, 20);
            this.EstimatedTimeValue.TabIndex = 2;
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(15, 13);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(65, 13);
            this.TaskNameLabel.TabIndex = 4;
            this.TaskNameLabel.Text = "Task Name:";
            // 
            // TaskNameValue
            // 
            this.TaskNameValue.Location = new System.Drawing.Point(12, 29);
            this.TaskNameValue.Name = "TaskNameValue";
            this.TaskNameValue.Size = new System.Drawing.Size(271, 20);
            this.TaskNameValue.TabIndex = 0;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 198);
            this.Controls.Add(this.TaskNameValue);
            this.Controls.Add(this.TaskNameLabel);
            this.Controls.Add(this.EstimatedTimeValue);
            this.Controls.Add(this.EstimatedTimeLabel);
            this.Controls.Add(this.DescriptionValue);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SubmitButton);
            this.Name = "AddTaskForm";
            this.Text = "Create a Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionValue;
        private System.Windows.Forms.Label EstimatedTimeLabel;
        private System.Windows.Forms.TextBox EstimatedTimeValue;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.TextBox TaskNameValue;
    }
}