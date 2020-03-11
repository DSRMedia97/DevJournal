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

namespace DevJournalUI.ViewElementForms
{
    public partial class DevOverviewForm : Form
    {
        private List<CategoryModel> categories = GlobalConfig.Connection.LoadAllCategories();
        private CategoryModel selectedCategory = new CategoryModel();

        public DevOverviewForm()
        {
            InitializeComponent();

            WireUpListBox();
        }

        private void WireUpListBox()
        {
            categoriesListBox.DataSource = null;

            categoriesListBox.DataSource = categories;
            categoriesListBox.DisplayMember = "CategoryName";
        }

        private void RefreshCategoryData()
        {
            label1.Text = selectedCategory.TotalStudyTime().ToString();
        }

        private void toolStripMenuExitOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewBooksToolStripLibraryItem_Click(object sender, EventArgs e)
        {
            Form frm = new BookViewerForm();
            frm.TopLevel = false;
            tabPage1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = (CategoryModel)categoriesListBox.SelectedItem;

            RefreshCategoryData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TrainingModel trainingModel = new StudyTrainingModel(double.Parse(HoursStudiedTextBox.Text), DateTime.Parse(dateTimePicker1.Text), int.Parse(BookReadTextBox.Text), TrainingModel.Source.Book);
            selectedCategory.Trainings.Add(trainingModel);
        }
    }
}
