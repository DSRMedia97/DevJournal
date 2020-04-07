using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevJournalUI.Interfaces;
using JournalLibrary.Models;

namespace DevJournalUI.EditElementForms
{
    public partial class CreateProjectForm : Form, ITaskRequester
    {
        private ProjectModel Project = new ProjectModel();
        private TaskModel selectedTask;
        private double EstTime = 0;

        public CreateProjectForm()
        {
            InitializeComponent();

            RefreshListData();
            CalculateEstTimeToComplete();
            EnableFormButtons();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            Form form = new AddTaskForm(this);
            form.Show();
        }

        private void RefreshListData()
        {
            TaskListBox.DataSource = null;
            TaskListBox.DataSource = Project.Tasks;
            TaskListBox.DisplayMember = "ProjectName";
        }

        private void EnableFormButtons()
        {
            if (Project.Tasks.Count() > 0)
            {
                EditTaskButton.Enabled = true;
                DeleteTaskButton.Enabled = true;
            }
            else
            {
                EditTaskButton.Enabled = false;
                DeleteTaskButton.Enabled = false;
            }
        }

        private void CalculateEstTimeToComplete()
        {
            EstTime = 0;

            foreach (TaskModel tm in Project.Tasks)
            {
                EstTime += tm.EstimatedTimeToComplete;
            }

            EstimatedTimeValue.Text = EstTime.ToString();
        }

        public void TaskComplete(TaskModel model)
        {
            Project.Tasks.Add(model);
            RefreshListData();
            CalculateEstTimeToComplete();
            EnableFormButtons();
        }

        public void TaskUpdate(TaskModel model)
        {
            RefreshListData();
            CalculateEstTimeToComplete();
        }

        private void TaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex >= 0)
            {
                selectedTask = (TaskModel)TaskListBox.SelectedItem;
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (selectedTask != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Remove task \"{ selectedTask.ProjectName }\" from Project?", "Remove task?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Project.Tasks.Remove(selectedTask);
                    RefreshListData();
                    CalculateEstTimeToComplete();
                    EnableFormButtons();
                } 
            }
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            Form form = new AddTaskForm(this, selectedTask);
            form.Show();
        }
    }
}
