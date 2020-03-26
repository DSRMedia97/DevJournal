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
    public partial class DevOverviewForm : Form, ICategoryRequester
    {
        private List<CategoryModel> categoryModels = GlobalConfig.Connection.LoadAllCategories();
        private CategoryModel selectedCategory = new CategoryModel();
        private List<StudyTrainingModel> allStudyTrainings = new List<StudyTrainingModel>();
        private List<PracticeTrainingModel> allPracticeTrainings = new List<PracticeTrainingModel>();

        public DevOverviewForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void CategoryComplete(CategoryModel model)
        {
            categoryModels.Add(model);

            WireUpLists();
        }

        private void WireUpLists()
        {
            CategoryListBox.DataSource = null;
            CategoryListBox.DataSource = categoryModels;
            CategoryListBox.DisplayMember = "CategoryName";
            CategoryListBox.SelectedIndex = 0;
        }

        private void toolStripMenuExitOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewBooksToolStripLibraryItem_Click(object sender, EventArgs e)
        {
            Form frm = new BookViewerForm();
            //frm.TopLevel = false;
            //tabPage1.Controls.Add(frm);
            //frm.Dock = DockStyle.Fill;
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
    }
}
