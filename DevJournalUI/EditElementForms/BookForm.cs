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
    public partial class BookForm : Form
    {
        private IBookRequester callingForm;
        private BookModel book;

        /// <summary>
        /// Constructor for adding a new book with no existing data.
        /// </summary>
        /// <param name="caller">The form creating the BookForm object.</param>
        public BookForm(IBookRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
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

                    GlobalConfig.Connection.CreateBookModel(b);

                    callingForm.BookComplete(b);

                    this.Close();
                }
                else if (book != null)
                {
                    book.BookName = TitleTextBox.Text;
                    book.AuthorName = AuthorTextBox.Text;
                    book.Price = double.Parse(PriceTextBox.Text);
                    book.Read = ReadCheckBoxValue.Checked;

                    GlobalConfig.Connection.UpdateBookModel(book);

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
            
            //Title can't be blank and can't contain commas
            if(TitleTextBox.Text.Length > 0 && !TitleTextBox.Text.Contains(","))
            {
                validTitle = true;
            }
            else
            {
                //TODO - error handling
            }

            //Author name can't be blank and can't contain commas
            if (AuthorTextBox.Text.Length > 0 && !AuthorTextBox.Text.Contains(","))
            {
                validAuthor = true;
            }
            else
            {
                //TODO - error handling
            }

            //Price has to be a valid number, not alphanumeric
            if (double.TryParse(PriceTextBox.Text, out price))
            {
                validPrice = true;
            }
            else
            {
                //TODO - error handling
            }

            //if all fields pass checks then update output
            if (validTitle && validAuthor && validPrice)
            {
                output = true;
            }
            return output;
        }
    }
}
