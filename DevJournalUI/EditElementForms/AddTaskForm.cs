﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JournalLibrary.Models;
using DevJournalUI.Interfaces;

namespace DevJournalUI.EditElementForms
{
    public partial class AddTaskForm : Form
    {
        private ITaskRequester callingForm;

        private TaskModel model = new TaskModel();

        private bool updateModel = false;

        public AddTaskForm(ITaskRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        public AddTaskForm(ITaskRequester caller, TaskModel incomingModel)
        {
            InitializeComponent();

            callingForm = caller;
            model = incomingModel;
            updateModel = true;

            this.Text = $"Edit { incomingModel.ShortDescription }";
            TaskNameValue.Text = incomingModel.ShortDescription;
            DescriptionValue.Text = incomingModel.Description;
            EstimatedTimeValue.Text = incomingModel.EstimatedTimeToComplete.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //ValidateData

            //Complete data model
            model.ShortDescription = TaskNameValue.Text;
            model.Description = DescriptionValue.Text;
            model.EstimatedTimeToComplete = double.Parse(EstimatedTimeValue.Text);

            if (!updateModel)
            {
                //Call calling form complete
                callingForm.TaskComplete(model); 
            }
            else if (updateModel)
            {
                callingForm.TaskUpdate(model);
            }

            //Close Form
            this.Close();
        }
    }
}
