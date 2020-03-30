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
            this.HoursLabel = new System.Windows.Forms.Label();
            this.HoursValue = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
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
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(80, 62);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(38, 13);
            this.HoursLabel.TabIndex = 0;
            this.HoursLabel.Text = "Hours:";
            // 
            // HoursValue
            // 
            this.HoursValue.Location = new System.Drawing.Point(137, 59);
            this.HoursValue.Name = "HoursValue";
            this.HoursValue.Size = new System.Drawing.Size(100, 20);
            this.HoursValue.TabIndex = 1;
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "dd MMM yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(137, 33);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(100, 20);
            this.DatePicker.TabIndex = 2;
            this.DatePicker.Value = new System.DateTime(2020, 3, 27, 15, 12, 14, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(80, 39);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date:";
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
            this.DescriptionGroupBox.Text = "Error";
            // 
            // TrainingStudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 408);
            this.Controls.Add(this.DescriptionGroupBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.HoursValue);
            this.Controls.Add(this.HoursLabel);
            this.Name = "TrainingStudyForm";
            this.Text = "Error";
            this.DescriptionGroupBox.ResumeLayout(false);
            this.DescriptionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.TextBox HoursValue;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label DateLabel;
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