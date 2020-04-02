using System;
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
        ITaskRequester callingForm;

        TaskModel model = new TaskModel();

        public AddTaskForm(ITaskRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //ValidateData

            //Complete data model
            model.ShortDescription = TaskNameValue.Text;
            model.Description = DescriptionValue.Text;
            model.EstimatedTimeToComplete = double.Parse(EstimatedTimeValue.Text);

            //Call calling form complete
            callingForm.TaskComplete(model);

            //Close Form
            this.Close();
        }
    }
}
