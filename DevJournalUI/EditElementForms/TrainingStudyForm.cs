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
using JournalLibrary;

namespace DevJournalUI.EditElementForms
{
    public partial class TrainingStudyForm : Form
    {
        private ITrainingRequester callingForm;
        private LibraryModel selectedLibraryItem = new LibraryModel();
        private List<BookModel> BooksByCategory = new List<BookModel>();
        private List<OnlineCourseModel> CoursesByCategory = new List<OnlineCourseModel>();
        private TrainingModel model = new TrainingModel();

        private double HoursStudied = 0;

        public TrainingStudyForm(ITrainingRequester caller, int categoryId)
        {
            InitializeComponent();
            BooksByCategory = GlobalConfig.Connection.LoadBooksByCategory(categoryId, false);
            CoursesByCategory = GlobalConfig.Connection.LoadCoursesByCategory(categoryId);

            callingForm = caller;
            model.CategoryId = categoryId;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidFormData())
            {
                model.Date = DateStudiedPicker.Value;
                model.Time = HoursStudied;
                model.TrainingDescription = DescriptionValue.Text;
                model.TrainingType = TrainingModel.Type.Studying;

                if (UseExistingMaterialCheckBox.Checked)
                {
                    model.MaterialId = selectedLibraryItem.ID;
                    if (LibraryComboBox.SelectedIndex == 1)
                    {
                        model.TrainingSource = TrainingModel.Source.Book;
                    }
                    else if (LibraryComboBox.SelectedIndex == 2)
                    {
                        model.TrainingSource = TrainingModel.Source.OnlineCourse;
                    }
                }

                GlobalConfig.Connection.CreateStudyTrainingModel(model);

                callingForm.TrainingComplete(model);
                this.Close();
            }
        }

        private bool ValidFormData()
        {
            bool output = false;

            bool validDate = false;
            bool validHours = false;
            bool validDescription = false;
            bool validLibraryReference = false;

            string errorMessage = "";

            if (DateStudiedPicker.Value != null)
            {
                validDate = true;
            }
            else
            {
                errorMessage += "Date is not valid. ";
            }
            if (double.TryParse(HoursStudiedValue.Text, out HoursStudied))
            {
                validHours = true;
            }
            else
            {
                errorMessage += "Hours does not contain a valid number. ";
            }
            if (DescriptionValue.Text.Length > 0)
            {
                validDescription = true;
            }
            else
            {
                errorMessage += "Description cannot be blank. ";
            }
            if ((UseExistingMaterialCheckBox.Checked && selectedLibraryItem != null) || !UseExistingMaterialCheckBox.Checked)
            {
                validLibraryReference = true;
            }
            else
            {
                errorMessage += "Select an item from the Library. ";
            }

            if (validDate && validHours && validDescription && validLibraryReference)
            {
                output = true;
            }
            else
            {
                MessageBox.Show(errorMessage, "Errors Found");
            }

            return output;
        }

        private void UseExistingMaterialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LibraryComboBox.Enabled = UseExistingMaterialCheckBox.Checked;
            LibraryListBox.Enabled = UseExistingMaterialCheckBox.Checked;
            LibraryComboBox.SelectedIndex = 0;
            DescriptionValue.Text = "";
        }

        private void LibraryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpListBox();
        }

        private void WireUpListBox()
        {
            LibraryListBox.DataSource = null;

            if (LibraryComboBox.SelectedIndex == 0)
            {
                LibraryListBox.DataSource = null;
            }
            else if (LibraryComboBox.SelectedIndex == 1)
            {
                LibraryListBox.DataSource = BooksByCategory;
            }
            else if (LibraryComboBox.SelectedIndex == 2)
            {
                LibraryListBox.DataSource = CoursesByCategory;
            }

            LibraryListBox.DisplayMember = "Title";
        }

        private void LibraryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(UseExistingMaterialCheckBox.Checked)
            {
                selectedLibraryItem = (LibraryModel)LibraryListBox.SelectedItem;
                if (selectedLibraryItem != null)
                {
                    if (LibraryComboBox.SelectedIndex == 1)
                    {
                        DescriptionValue.Text = $"Read: { selectedLibraryItem.Title }";
                    }
                    else if (LibraryComboBox.SelectedIndex == 2)
                    {
                        DescriptionValue.Text = $"Watched: { selectedLibraryItem.Title }";
                    } 
                }
                else
                {
                    DescriptionValue.Text = "";
                }
            }
        }
    }
}
