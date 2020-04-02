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
        double EstTime = 0;

        public CreateProjectForm()
        {
            InitializeComponent();

            RefreshListData();
            CalculateEstTimeToComplete();
            RefreshEstTimeDisplay();
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
            TaskListBox.DisplayMember = "ShortDescription";
        }

        private void CalculateEstTimeToComplete()
        {
            foreach (TaskModel tm in Project.Tasks)
            {
                EstTime += tm.EstimatedTimeToComplete;
            }
        }

        private void RefreshEstTimeDisplay()
        {
            if(EstTime != 0)
            {
                EstimatedTimeValue.Text = EstTime.ToString();
            }
        }

        public void TaskComplete(TaskModel model)
        {
            Project.Tasks.Add(model);
            RefreshListData();
            EstTime += model.EstimatedTimeToComplete;
            RefreshEstTimeDisplay();
        }
    }
}
