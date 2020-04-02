namespace DevJournalUI.EditElementForms
{
    partial class CreateProjectForm
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
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.ProjectNameValue = new System.Windows.Forms.TextBox();
            this.EstimatedHoursLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EstimatedDateLabel = new System.Windows.Forms.Label();
            this.TasksGroupBox = new System.Windows.Forms.GroupBox();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.EstimatedTimeValue = new System.Windows.Forms.Label();
            this.TasksGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(12, 30);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(74, 13);
            this.ProjectNameLabel.TabIndex = 0;
            this.ProjectNameLabel.Text = "Project Name:";
            // 
            // TaskListBox
            // 
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.Location = new System.Drawing.Point(6, 19);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(282, 186);
            this.TaskListBox.TabIndex = 1;
            // 
            // ProjectNameValue
            // 
            this.ProjectNameValue.Location = new System.Drawing.Point(92, 27);
            this.ProjectNameValue.Name = "ProjectNameValue";
            this.ProjectNameValue.Size = new System.Drawing.Size(300, 20);
            this.ProjectNameValue.TabIndex = 2;
            // 
            // EstimatedHoursLabel
            // 
            this.EstimatedHoursLabel.AutoSize = true;
            this.EstimatedHoursLabel.Location = new System.Drawing.Point(65, 69);
            this.EstimatedHoursLabel.Name = "EstimatedHoursLabel";
            this.EstimatedHoursLabel.Size = new System.Drawing.Size(146, 13);
            this.EstimatedHoursLabel.TabIndex = 3;
            this.EstimatedHoursLabel.Text = "Estimated Hours to Complete:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // EstimatedDateLabel
            // 
            this.EstimatedDateLabel.AutoSize = true;
            this.EstimatedDateLabel.Location = new System.Drawing.Point(62, 98);
            this.EstimatedDateLabel.Name = "EstimatedDateLabel";
            this.EstimatedDateLabel.Size = new System.Drawing.Size(149, 13);
            this.EstimatedDateLabel.TabIndex = 6;
            this.EstimatedDateLabel.Text = "Estimated Date of Completion:";
            // 
            // TasksGroupBox
            // 
            this.TasksGroupBox.Controls.Add(this.EditTaskButton);
            this.TasksGroupBox.Controls.Add(this.AddTaskButton);
            this.TasksGroupBox.Controls.Add(this.TaskListBox);
            this.TasksGroupBox.Location = new System.Drawing.Point(15, 126);
            this.TasksGroupBox.Name = "TasksGroupBox";
            this.TasksGroupBox.Size = new System.Drawing.Size(377, 217);
            this.TasksGroupBox.TabIndex = 7;
            this.TasksGroupBox.TabStop = false;
            this.TasksGroupBox.Text = "Tasks";
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.Location = new System.Drawing.Point(294, 102);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(75, 23);
            this.EditTaskButton.TabIndex = 3;
            this.EditTaskButton.Text = "Edit Task";
            this.EditTaskButton.UseVisualStyleBackColor = true;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(294, 73);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(75, 23);
            this.AddTaskButton.TabIndex = 2;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(155, 349);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // EstimatedTimeValue
            // 
            this.EstimatedTimeValue.AutoSize = true;
            this.EstimatedTimeValue.Location = new System.Drawing.Point(217, 69);
            this.EstimatedTimeValue.Name = "EstimatedTimeValue";
            this.EstimatedTimeValue.Size = new System.Drawing.Size(98, 13);
            this.EstimatedTimeValue.TabIndex = 9;
            this.EstimatedTimeValue.Text = "<Based On Tasks>";
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 389);
            this.Controls.Add(this.EstimatedTimeValue);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.TasksGroupBox);
            this.Controls.Add(this.EstimatedDateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EstimatedHoursLabel);
            this.Controls.Add(this.ProjectNameValue);
            this.Controls.Add(this.ProjectNameLabel);
            this.Name = "CreateProjectForm";
            this.Text = "Create a Project";
            this.TasksGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.TextBox ProjectNameValue;
        private System.Windows.Forms.Label EstimatedHoursLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label EstimatedDateLabel;
        private System.Windows.Forms.GroupBox TasksGroupBox;
        private System.Windows.Forms.Button EditTaskButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label EstimatedTimeValue;
    }
}