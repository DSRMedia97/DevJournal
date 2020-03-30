using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevJournalUI.EditElementForms;
using DevJournalUI.Interfaces;
using JournalLibrary;
using JournalLibrary.Models;

namespace DevJournalUI.ViewElementForms
{
    public partial class DevOverviewForm : Form, ICategoryRequester, ITrainingRequester
    {
        private List<CategoryModel> categoryModels = GlobalConfig.Connection.LoadAllCategoriesFull();
        private CategoryModel selectedCategory = new CategoryModel();
        private TrainingModel selectedTraining = new TrainingModel();

        public DevOverviewForm()
        {
            InitializeComponent();
            RefreshGraphCollection();
            WireUpCategoryList();
        }

        public void CategoryComplete(CategoryModel model)
        {
            categoryModels.Add(model);
            RefreshGraphCollection();
            WireUpCategoryList();
        }

        public void TrainingComplete(TrainingModel model)
        {
            selectedCategory.Trainings.Add(model);
            RefreshGraphCollection();
            UpdateCategoryData();
        }

        private void WireUpCategoryList()
        {
            CategoryListBox.DataSource = null;
            CategoryListBox.DataSource = categoryModels;
            CategoryListBox.DisplayMember = "CategoryName";
            CategoryListBox.SelectedIndex = 0;
        }

        private void WireUpTrainingList()
        {
            RecentActivityListBox.DataSource = null;
            RecentActivityListBox.DataSource = selectedCategory.Trainings;
            RecentActivityListBox.DisplayMember = "TrainingDescription";
        }

        private void RefreshGraphCollection()
        {
            CategoryChart.Series["StudyTime"].Points.Clear();
            CategoryChart.Series["PracticeTime"].Points.Clear();

            foreach (CategoryModel cm in categoryModels)
            {
                if (cm.ID != 1)
                {
                    CategoryChart.Series["StudyTime"].Points.AddXY(cm.CategoryName, cm.GetTotalStudyHours().ToString());
                    CategoryChart.Series["PracticeTime"].Points.AddXY(cm.CategoryName, cm.GetTotalPracticeHours().ToString()); 
                }
            }
        }

        private void toolStripMenuExitOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewBooksToolStripLibraryItem_Click(object sender, EventArgs e)
        {
            Form frm = new BookViewerForm();
            frm.Show();
        }

        private void viewOnlineCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new OnlineCoursesViewerForm();
            form.Show();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            Form form = new CategoryForm(this);
            form.Show();
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CategoryListBox.SelectedIndex == 0)
            {
                CategoryDetailGroupBox.Enabled = false;
            }
            else
            {
                CategoryDetailGroupBox.Enabled = true;
                selectedCategory = (CategoryModel)CategoryListBox.SelectedItem;
                UpdateCategoryData();
            }
        }

        private void UpdateCategoryData()
        {
            CategoryDetailGroupBox.Text = selectedCategory.CategoryName;
            StudyTimeTotalValue.Text = selectedCategory.GetTotalStudyHours().ToString();
            PracticeTimeTotalValue.Text = selectedCategory.GetTotalPracticeHours().ToString();
            WireUpTrainingList();
        }

        private void AddStudyTimeButton_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                Form form = new TrainingStudyForm(this, selectedCategory.ID, TrainingModel.Type.Studying);
                form.Show();
            }
            else
            {
                MessageBox.Show("No category selected!","Error");
            }
        }

        private void RecentActivityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTraining = (TrainingModel)RecentActivityListBox.SelectedItem;
            RefreshSessionDetails();
        }

        private void RefreshSessionDetails()
        {
            if (selectedTraining != null)
            {
                SessionHoursValue.Text = selectedTraining.Time.ToString();
                SessionDateValue.Text = selectedTraining.Date.ToString("dd MMM yyyy");
            }
            else
            {
                SessionHoursValue.Text = "Not Available";
                SessionDateValue.Text = "Not Available";
            }
        }

        private void AddPracticeTimeSession_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                Form form = new TrainingStudyForm(this, selectedCategory.ID, TrainingModel.Type.Practicing);
                form.Show();
            }
            else
            {
                MessageBox.Show("No category selected!", "Error");
            }
        }
    }
}
