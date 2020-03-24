using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using JournalLibrary;
using JournalLibrary.Models;
using DevJournalUI.Interfaces;
using DevJournalUI.EditElementForms;

namespace DevJournalUI.ViewElementForms
{
    public partial class OnlineCoursesViewerForm : Form, IOnlineCourseRequester
    {
        private List<OnlineCourseModel> selectedCourses = new List<OnlineCourseModel>();
        private OnlineCourseModel selectedCourse = new OnlineCourseModel();
        private List<CategoryModel> availableCategories = GlobalConfig.Connection.LoadAllCategories();

        public OnlineCoursesViewerForm()
        {
            InitializeComponent();

            WireUpDropdowns();
            WireUpLists();
        }

        private void WireUpDropdowns()
        {
            FilterCategoryComboBox.DataSource = null;
            FilterCategoryComboBox.DataSource = availableCategories;
            FilterCategoryComboBox.DisplayMember = "CategoryName";
            FilterCategoryComboBox.SelectedIndex = 0;
        }

        private void WireUpLists()
        {
            CoursesListBox.DataSource = null;
            CoursesListBox.DataSource = selectedCourses;
            CoursesListBox.DisplayMember = "Title";
        }

        private void RefreshSelectedCoursesList()
        {
            selectedCourses.Clear();

            CategoryModel category = (CategoryModel)FilterCategoryComboBox.SelectedItem;

            if (category == null)
            {
                category = new CategoryModel();
                category.ID = 1;
            }

            selectedCourses = GlobalConfig.Connection.LoadCoursesByCategory(category.ID);
        }

        public void CourseComplete ()
        {
            RefreshSelectedCoursesList();
            WireUpLists();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            OnlineCourseForm frm = new OnlineCourseForm(this);
            frm.Show();
        }

        private void EditSelectedCourseButton_Click(object sender, EventArgs e)
        {
            OnlineCourseForm form = new OnlineCourseForm(this, selectedCourse);
            form.Show();
        }

        private void CoursesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCourse = (OnlineCourseModel)CoursesListBox.SelectedItem;
            if (selectedCourse != null)
            {
                RefreshSelectedCourseLink();
            }
        }

        private void RefreshSelectedCourseLink()
        {
            CourseLink.Text = selectedCourse.CourseLink;
            CourseLink.LinkVisited = false;
        }

        private void CourseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectedCourse.CourseLink != null)
            {
                System.Diagnostics.Process.Start(selectedCourse.CourseLink);
            }
        }

        private void FilterCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelectedCoursesList();
            WireUpLists();
        }
    }
}
