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
        private IOnlineCourseRequester callingForm;
        private OnlineCourseModel course;

        private List<CategoryModel> availableCategories = GlobalConfig.Connection.LoadAllCategories();
        private List<CategoryModel> selectedCategories = new List<CategoryModel>();

        public OnlineCourseForm(IOnlineCourseRequester caller)
        {
            InitializeComponent();

            this.Text = "Add New Course";

            callingForm = caller;

            availableCategories.Remove(availableCategories.Where(x => x.ID == 1).First());
            WireUpLists();
        }

        public OnlineCourseForm(IOnlineCourseRequester caller, OnlineCourseModel model)
        {
            course = model;
            callingForm = caller;

            InitializeComponent();

            this.Text = $"Edit { course.Title }";

            CourseTitleValue.Text = course.Title;
            CourseLinkValue.Text = course.CourseLink;

            availableCategories.Remove(availableCategories.Where(x => x.ID == 1).First());
            WireUpExistingCategories();
            WireUpLists();
        }

        private void WireUpLists()
        {
            AvailableCategoriesListBox.DataSource = null;
            AvailableCategoriesListBox.DataSource = availableCategories;
            AvailableCategoriesListBox.DisplayMember = "CategoryName";

            SelectedCategoriesListBox.DataSource = null;
            SelectedCategoriesListBox.DataSource = selectedCategories;
            SelectedCategoriesListBox.DisplayMember = "CategoryName";
        }

        private void WireUpExistingCategories()
        {
            selectedCategories = GlobalConfig.Connection.LoadCategoriesByOnlineCourse(course.ID);

            foreach (CategoryModel c in selectedCategories)
            {
                availableCategories.Remove(availableCategories.Where(x => x.ID == c.ID).First());
            }
        }

        private void SaveCourseButton_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                if (course == null)
                {
                    OnlineCourseModel c = new OnlineCourseModel();

                    c.Title = CourseTitleValue.Text;
                    c.CourseLink = CheckForFullLinkPath(CourseLinkValue.Text);

                    GlobalConfig.Connection.CreateOnlineCourseModel(c, selectedCategories);
                }
                else if (course != null)
                {
                    course.Title = CourseTitleValue.Text;
                    course.CourseLink = CourseLinkValue.Text;

                    GlobalConfig.Connection.UpdateOnlineCourseModel(course, selectedCategories);
                }

                callingForm.CourseComplete();

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

        private void AddToSelectedCategoriesButton_Click(object sender, EventArgs e)
        {
            if (AvailableCategoriesListBox.SelectedItem == null)
            {
                return;
            }
            else
            {
                selectedCategories.Add((CategoryModel)AvailableCategoriesListBox.SelectedItem);
                availableCategories.Remove((CategoryModel)AvailableCategoriesListBox.SelectedItem);
            }
            WireUpLists();
        }

        private void RemoveFromSelectedCategoriesButton_Click(object sender, EventArgs e)
        {
            if (SelectedCategoriesListBox.SelectedItem == null)
            {
                return;
            }
            else
            {
                selectedCategories.Remove((CategoryModel)AvailableCategoriesListBox.SelectedItem);
                availableCategories.Add((CategoryModel)AvailableCategoriesListBox.SelectedItem);
            }
            WireUpLists();
        }
    }
}
