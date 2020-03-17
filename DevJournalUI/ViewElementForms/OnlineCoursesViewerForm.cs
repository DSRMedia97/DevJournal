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
        private List<OnlineCourseModel> allCourses = GlobalConfig.Connection.LoadAllOnlineCourses();
        private OnlineCourseModel selectedCourse = new OnlineCourseModel();

        public OnlineCoursesViewerForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            CoursesListBox.DataSource = null;
            CoursesListBox.DataSource = allCourses;
            CoursesListBox.DisplayMember = "Title";
        }

        public void CourseComplete (OnlineCourseModel model)
        {
            allCourses.Add(model);
            WireUpLists();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            OnlineCourseForm frm = new OnlineCourseForm(this);
            frm.Show();
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
    }
}
