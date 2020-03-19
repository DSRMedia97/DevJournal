using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JournalLibrary;
using JournalLibrary.Models;
using DevJournalUI.Interfaces;

namespace DevJournalUI.EditElementForms
{
    public partial class OnlineCourseForm : Form
    {
        IOnlineCourseRequester callingForm;

        public OnlineCourseForm(IOnlineCourseRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                OnlineCourseModel course = new OnlineCourseModel();

                course.Title = CourseTitleValue.Text;
                course.CourseLink = CheckForFullLinkPath(CourseLinkValue.Text);

                //GlobalConfig.Connection.CreateOnlineCourseModel(course);

                callingForm.CourseComplete(course);

                this.Close();
            }
        }

        private bool ValidData()
        {
            bool output = false;

            bool validTitle = false;
            bool validLinkLength = false;

            string errorMessage = "";

            if (CourseTitleValue.Text.Length > 0)
            {
                validTitle = true;
            }
            else
            {
                errorMessage += "Title cannot be blank. ";
            }

            //"http://" is 7 characters -- link must include at least this string
            if (CourseLinkValue.Text.Length > 8)
            {
                validLinkLength = true;
            }
            else
            {
                errorMessage += "Course link is not valid. ";
            }

            if (validTitle && validLinkLength)
            {
                output = true;
            }
            else
            {
                MessageBox.Show($"{ errorMessage }", "Formatting Error");
            }

            return output;
        }

        private string CheckForFullLinkPath(string link)
        {
            string output = "";

            if (link.Substring(0,7) != "http://" && link.Substring(0,8) != "https://")
            {
                output = "http://" + link;
            }
            else
            {
                output = link;
            }

            return output;
        }
    }
}
