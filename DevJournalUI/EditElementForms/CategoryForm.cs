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
using JournalLibrary.DataConnectors;
using JournalLibrary.Models;
using DevJournalUI.Interfaces;

namespace DevJournalUI.EditElementForms
{
    public partial class CategoryForm : Form
    {
        ICategoryRequester callingForm;

        public CategoryForm(ICategoryRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                //Create CategoryModel
                CategoryModel model = new CategoryModel();
                model.CategoryName = CategoryNameValue.Text;

                //Save new category to DB
                GlobalConfig.Connection.CreateCategoryModel(model);

                //Return new category to Book
                callingForm.CategoryComplete(model);

                this.Close(); 
            }
            else
            {
                MessageBox.Show("Category names cannot be blank and cannot contain commas.", "Incorrect Category Name");
            }
        }

        private bool ValidData()
        {
            bool output = false;

            if (CategoryNameValue.Text != "" && !CategoryNameValue.Text.Contains(","))
            {
                output = true;
            }

            return output;
        }
    }
}
