namespace DevJournalUI.EditElementForms
{
    partial class TrainingPracticeForm
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
            this.DescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.UseExistingMaterialCheckBox = new System.Windows.Forms.CheckBox();
            this.OrLabel = new System.Windows.Forms.Label();
            this.DescriptionValue = new System.Windows.Forms.TextBox();
            this.LibraryListBox = new System.Windows.Forms.ListBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DatePracticedLabel = new System.Windows.Forms.Label();
            this.DatePracticedPicker = new System.Windows.Forms.DateTimePicker();
            this.HoursStudiedValue = new System.Windows.Forms.TextBox();
            this.HoursPracticedLabel = new System.Windows.Forms.Label();
            this.DescriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionGroupBox
            // 
            this.DescriptionGroupBox.Controls.Add(this.UseExistingMaterialCheckBox);
            this.DescriptionGroupBox.Controls.Add(this.OrLabel);
            this.DescriptionGroupBox.Controls.Add(this.DescriptionValue);
            this.DescriptionGroupBox.Controls.Add(this.LibraryListBox);
            this.DescriptionGroupBox.Controls.Add(this.DescriptionLabel);
            this.DescriptionGroupBox.Location = new System.Drawing.Point(17, 90);
            this.DescriptionGroupBox.Name = "DescriptionGroupBox";
            this.DescriptionGroupBox.Size = new System.Drawing.Size(326, 266);
            this.DescriptionGroupBox.TabIndex = 17;
            this.DescriptionGroupBox.TabStop = false;
            this.DescriptionGroupBox.Text = "Practice Material Description";
            // 
            // UseExistingMaterialCheckBox
            // 
            this.UseExistingMaterialCheckBox.AutoSize = true;
            this.UseExistingMaterialCheckBox.Enabled = false;
            this.UseExistingMaterialCheckBox.Location = new System.Drawing.Point(96, 58);
            this.UseExistingMaterialCheckBox.Name = "UseExistingMaterialCheckBox";
            this.UseExistingMaterialCheckBox.Size = new System.Drawing.Size(120, 17);
            this.UseExistingMaterialCheckBox.TabIndex = 6;
            this.UseExistingMaterialCheckBox.Text = "Use Existing Project";
            this.UseExistingMaterialCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Enabled = false;
            this.OrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrLabel.Location = new System.Drawing.Point(132, 42);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(41, 13);
            this.OrLabel.TabIndex = 10;
            this.OrLabel.Text = "- OR -";
            // 
            // DescriptionValue
            // 
            this.DescriptionValue.Location = new System.Drawing.Point(71, 19);
            this.DescriptionValue.Name = "DescriptionValue";
            this.DescriptionValue.Size = new System.Drawing.Size(249, 20);
            this.DescriptionValue.TabIndex = 9;
            // 
            // LibraryListBox
            // 
            this.LibraryListBox.Enabled = false;
            this.LibraryListBox.FormattingEnabled = true;
            this.LibraryListBox.Location = new System.Drawing.Point(9, 85);
            this.LibraryListBox.Name = "LibraryListBox";
            this.LibraryListBox.Size = new System.Drawing.Size(311, 173);
            this.LibraryListBox.TabIndex = 7;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 22);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Description:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(132, 362);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 16;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DatePracticedLabel
            // 
            this.DatePracticedLabel.AutoSize = true;
            this.DatePracticedLabel.Location = new System.Drawing.Point(65, 38);
            this.DatePracticedLabel.Name = "DatePracticedLabel";
            this.DatePracticedLabel.Size = new System.Drawing.Size(81, 13);
            this.DatePracticedLabel.TabIndex = 15;
            this.DatePracticedLabel.Text = "Date Practiced:";
            // 
            // DatePracticedPicker
            // 
            this.DatePracticedPicker.CustomFormat = "dd MMM yyyy";
            this.DatePracticedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePracticedPicker.Location = new System.Drawing.Point(152, 32);
            this.DatePracticedPicker.Name = "DatePracticedPicker";
            this.DatePracticedPicker.Size = new System.Drawing.Size(100, 20);
            this.DatePracticedPicker.TabIndex = 14;
            this.DatePracticedPicker.Value = new System.DateTime(2020, 3, 27, 15, 12, 14, 0);
            // 
            // HoursStudiedValue
            // 
            this.HoursStudiedValue.Location = new System.Drawing.Point(152, 58);
            this.HoursStudiedValue.Name = "HoursStudiedValue";
            this.HoursStudiedValue.Size = new System.Drawing.Size(100, 20);
            this.HoursStudiedValue.TabIndex = 13;
            // 
            // HoursPracticedLabel
            // 
            this.HoursPracticedLabel.AutoSize = true;
            this.HoursPracticedLabel.Location = new System.Drawing.Point(60, 61);
            this.HoursPracticedLabel.Name = "HoursPracticedLabel";
            this.HoursPracticedLabel.Size = new System.Drawing.Size(86, 13);
            this.HoursPracticedLabel.TabIndex = 12;
            this.HoursPracticedLabel.Text = "Hours Practiced:";
            // 
            // TrainingPracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 417);
            this.Controls.Add(this.DescriptionGroupBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DatePracticedLabel);
            this.Controls.Add(this.DatePracticedPicker);
            this.Controls.Add(this.HoursStudiedValue);
            this.Controls.Add(this.HoursPracticedLabel);
            this.Name = "TrainingPracticeForm";
            this.Text = "Enter Practice Information";
            this.DescriptionGroupBox.ResumeLayout(false);
            this.DescriptionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DescriptionGroupBox;
        private System.Windows.Forms.CheckBox UseExistingMaterialCheckBox;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.TextBox DescriptionValue;
        private System.Windows.Forms.ListBox LibraryListBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label DatePracticedLabel;
        private System.Windows.Forms.DateTimePicker DatePracticedPicker;
        private System.Windows.Forms.TextBox HoursStudiedValue;
        private System.Windows.Forms.Label HoursPracticedLabel;
    }
}