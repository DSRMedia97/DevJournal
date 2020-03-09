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
    public partial class BookForm : Form, ICategoryRequester
    {
        private IBookRequester callingForm;
        private BookModel book;

        private List<CategoryModel> availableCategories = GlobalConfig.Connection.LoadAllCategories();
        private List<CategoryModel> selectedCategories = new List<CategoryModel>();

        /// <summary>
        /// Constructor for adding a new book with no existing data.
        /// </summary>
        /// <param name="caller">The form creating the BookForm object.</param>
        public BookForm(IBookRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpLists();
        }

        /// <summary>
        /// Constructor for editing a BookModel that contains existing data.
        /// </summary>
        /// <param name="caller">The form creating the BookForm object.</param>
        /// <param name="model">The BookModel that is to be edited.</param>
        public BookForm(IBookRequester caller, BookModel model)
        {
            book = model;

            InitializeComponent();

            TitleTextBox.Text = book.BookName;
            AuthorTextBox.Text = book.AuthorName;
            PriceTextBox.Text = book.Price.ToString();
            ReadCheckBoxValue.Checked = book.Read;

            callingForm = caller;

            WireUpCategories();
            WireUpLists();
        }

        private void WireUpCategories()
        {
            foreach (CategoryModel c in availableCategories)
            {
                if (c.BookIds.Contains(book.ID))
                {
                    selectedCategories.Add(c);
                }
            }
            foreach (CategoryModel c in selectedCategories)
            {
                availableCategories.Remove(availableCategories.Where(x => x.ID == c.ID).First());
            }
        }

        private void WireUpLists()
        {
            AvailableCategoriesListBox.DataSource = null;
            SelectedCategoriesListBox.DataSource = null;

            AvailableCategoriesListBox.DataSource = availableCategories;
            AvailableCategoriesListBox.DisplayMember = "CategoryName";

            SelectedCategoriesListBox.DataSource = selectedCategories;
            SelectedCategoriesListBox.DisplayMember = "CategoryName";
        }

        public void CategoryComplete(CategoryModel model)
        {
            selectedCategories.Add(model);
            WireUpLists();
        }

        private void BookSubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidFormData())
            {
                if (book == null)
                {
                    BookModel b = new BookModel();

                    b.BookName = TitleTextBox.Text;
                    b.AuthorName = AuthorTextBox.Text;
                    b.Price = double.Parse(PriceTextBox.Text);
                    b.Read = ReadCheckBoxValue.Checked;

                    GlobalConfig.Connection.CreateBookModel(b, selectedCategories);

                    callingForm.BookComplete(b);

                    this.Close();
                }
                else if (book != null)
                {
                    book.BookName = TitleTextBox.Text;
                    book.AuthorName = AuthorTextBox.Text;
                    book.Price = double.Parse(PriceTextBox.Text);
                    book.Read = ReadCheckBoxValue.Checked;

                    GlobalConfig.Connection.UpdateBookModel(book, selectedCategories);

                    callingForm.BookUpdate(book);

                    this.Close();
                } 
            }
        }

        private bool ValidFormData()
        {
            bool output = false;
            bool validTitle = false;
            bool validAuthor = false;
            double price = 0;
            bool validPrice = false;

            string errorMessage = "";
            
            //Title can't be blank and can't contain commas
            if(TitleTextBox.Text.Length > 0 && !TitleTextBox.Text.Contains(","))
            {
                validTitle = true;
            }
            else
            {
                errorMessage += "Title cannot be blank and cannot contain commas. ";
            }

            //Author name can't be blank and can't contain commas
            if (AuthorTextBox.Text.Length > 0 && !AuthorTextBox.Text.Contains(","))
            {
                validAuthor = true;
            }
            else
            {
                errorMessage += "Author name cannot be blank and cannot contain commas. ";
            }

            //Price has to be a valid number, not alphanumeric
            if (double.TryParse(PriceTextBox.Text, out price))
            {
                validPrice = true;
            }
            else
            {
                errorMessage += "Price is not in the correct format. ";
            }

            //if all fields pass checks then update output
            if (validTitle && validAuthor && validPrice)
            {
                output = true;
            }
            else
            {
                MessageBox.Show($"{ errorMessage }", "Formatting Error");
            }
            return output;
        }

        private void AddNewCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm(this);
            frm.Show();
        }

        private void AddToSelectedButton_Click(object sender, EventArgs e)
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

        private void RemoveFromSelectedButton_Click(object sender, EventArgs e)
        {
            if (SelectedCategoriesListBox.SelectedItem == null)
            {
                return;
            }
            else
            {
                selectedCategories.Remove((CategoryModel)SelectedCategoriesListBox.SelectedItem);
                availableCategories.Add((CategoryModel)SelectedCategoriesListBox.SelectedItem);
            }
            WireUpLists();
        }
    }
}
