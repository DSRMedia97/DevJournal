namespace DevJournalUI.EditElementForms
{
    partial class TrainingStudyForm
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
            this.HoursStudiedLabel = new System.Windows.Forms.Label();
            this.HoursStudiedValue = new System.Windows.Forms.TextBox();
            this.DateStudiedPicker = new System.Windows.Forms.DateTimePicker();
            this.DateStudiedLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.LibraryComboBox = new System.Windows.Forms.ComboBox();
            this.UseExistingMaterialCheckBox = new System.Windows.Forms.CheckBox();
            this.LibraryListBox = new System.Windows.Forms.ListBox();
            this.DescriptionValue = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.DescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoursStudiedLabel
            // 
            this.HoursStudiedLabel.AutoSize = true;
            this.HoursStudiedLabel.Location = new System.Drawing.Point(64, 62);
            this.HoursStudiedLabel.Name = "HoursStudiedLabel";
            this.HoursStudiedLabel.Size = new System.Drawing.Size(77, 13);
            this.HoursStudiedLabel.TabIndex = 0;
            this.HoursStudiedLabel.Text = "Hours Studied:";
            // 
            // HoursStudiedValue
            // 
            this.HoursStudiedValue.Location = new System.Drawing.Point(147, 59);
            this.HoursStudiedValue.Name = "HoursStudiedValue";
            this.HoursStudiedValue.Size = new System.Drawing.Size(100, 20);
            this.HoursStudiedValue.TabIndex = 1;
            // 
            // DateStudiedPicker
            // 
            this.DateStudiedPicker.CustomFormat = "dd MMM yyyy";
            this.DateStudiedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStudiedPicker.Location = new System.Drawing.Point(147, 33);
            this.DateStudiedPicker.Name = "DateStudiedPicker";
            this.DateStudiedPicker.Size = new System.Drawing.Size(100, 20);
            this.DateStudiedPicker.TabIndex = 2;
            this.DateStudiedPicker.Value = new System.DateTime(2020, 3, 27, 15, 12, 14, 0);
            // 
            // DateStudiedLabel
            // 
            this.DateStudiedLabel.AutoSize = true;
            this.DateStudiedLabel.Location = new System.Drawing.Point(64, 39);
            this.DateStudiedLabel.Name = "DateStudiedLabel";
            this.DateStudiedLabel.Size = new System.Drawing.Size(72, 13);
            this.DateStudiedLabel.TabIndex = 3;
            this.DateStudiedLabel.Text = "Date Studied:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(127, 363);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // LibraryComboBox
            // 
            this.LibraryComboBox.Enabled = false;
            this.LibraryComboBox.FormattingEnabled = true;
            this.LibraryComboBox.Items.AddRange(new object[] {
            " ",
            "Books",
            "Online Courses"});
            this.LibraryComboBox.Location = new System.Drawing.Point(95, 81);
            this.LibraryComboBox.Name = "LibraryComboBox";
            this.LibraryComboBox.Size = new System.Drawing.Size(121, 21);
            this.LibraryComboBox.TabIndex = 5;
            this.LibraryComboBox.SelectedIndexChanged += new System.EventHandler(this.LibraryComboBox_SelectedIndexChanged);
            // 
            // UseExistingMaterialCheckBox
            // 
            this.UseExistingMaterialCheckBox.AutoSize = true;
            this.UseExistingMaterialCheckBox.Location = new System.Drawing.Point(84, 58);
            this.UseExistingMaterialCheckBox.Name = "UseExistingMaterialCheckBox";
            this.UseExistingMaterialCheckBox.Size = new System.Drawing.Size(141, 17);
            this.UseExistingMaterialCheckBox.TabIndex = 6;
            this.UseExistingMaterialCheckBox.Text = "Use Existing Library Item";
            this.UseExistingMaterialCheckBox.UseVisualStyleBackColor = true;
            this.UseExistingMaterialCheckBox.CheckedChanged += new System.EventHandler(this.UseExistingMaterialCheckBox_CheckedChanged);
            // 
            // LibraryListBox
            // 
            this.LibraryListBox.Enabled = false;
            this.LibraryListBox.FormattingEnabled = true;
            this.LibraryListBox.Location = new System.Drawing.Point(9, 111);
            this.LibraryListBox.Name = "LibraryListBox";
            this.LibraryListBox.Size = new System.Drawing.Size(311, 147);
            this.LibraryListBox.TabIndex = 7;
            this.LibraryListBox.SelectedIndexChanged += new System.EventHandler(this.LibraryListBox_SelectedIndexChanged);
            // 
            // DescriptionValue
            // 
            this.DescriptionValue.Location = new System.Drawing.Point(71, 19);
            this.DescriptionValue.Name = "DescriptionValue";
            this.DescriptionValue.Size = new System.Drawing.Size(249, 20);
            this.DescriptionValue.TabIndex = 9;
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
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrLabel.Location = new System.Drawing.Point(132, 42);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(41, 13);
            this.OrLabel.TabIndex = 10;
            this.OrLabel.Text = "- OR -";
            // 
            // DescriptionGroupBox
            // 
            this.DescriptionGroupBox.Controls.Add(this.UseExistingMaterialCheckBox);
            this.DescriptionGroupBox.Controls.Add(this.OrLabel);
            this.DescriptionGroupBox.Controls.Add(this.LibraryComboBox);
            this.DescriptionGroupBox.Controls.Add(this.DescriptionValue);
            this.DescriptionGroupBox.Controls.Add(this.LibraryListBox);
            this.DescriptionGroupBox.Controls.Add(this.DescriptionLabel);
            this.DescriptionGroupBox.Location = new System.Drawing.Point(12, 91);
            this.DescriptionGroupBox.Name = "DescriptionGroupBox";
            this.DescriptionGroupBox.Size = new System.Drawing.Size(326, 266);
            this.DescriptionGroupBox.TabIndex = 11;
            this.DescriptionGroupBox.TabStop = false;
            this.DescriptionGroupBox.Text = "Study Material Description";
            // 
            // TrainingStudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 408);
            this.Controls.Add(this.DescriptionGroupBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DateStudiedLabel);
            this.Controls.Add(this.DateStudiedPicker);
            this.Controls.Add(this.HoursStudiedValue);
            this.Controls.Add(this.HoursStudiedLabel);
            this.Name = "TrainingStudyForm";
            this.Text = "Enter Study Information";
            this.DescriptionGroupBox.ResumeLayout(false);
            this.DescriptionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoursStudiedLabel;
        private System.Windows.Forms.TextBox HoursStudiedValue;
        private System.Windows.Forms.DateTimePicker DateStudiedPicker;
        private System.Windows.Forms.Label DateStudiedLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox LibraryComboBox;
        private System.Windows.Forms.CheckBox UseExistingMaterialCheckBox;
        private System.Windows.Forms.ListBox LibraryListBox;
        private System.Windows.Forms.TextBox DescriptionValue;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.GroupBox DescriptionGroupBox;
    }
}