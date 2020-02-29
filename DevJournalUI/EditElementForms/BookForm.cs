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

        public BookForm(IBookRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        public BookForm(IBookRequester caller, BookModel model)
        {
            book = model;

            InitializeComponent();

            this.TitleTextBox.Text = book.BookName;
            this.AuthorTextBox.Text = book.AuthorName;
            this.PriceTextBox.Text = book.Price.ToString();

            callingForm = caller;
        }

        private void BookSubmitButton_Click(object sender, EventArgs e)
        {
            //TODO - Form validation
            if (book == null)
            {
                BookModel b = new BookModel();

                b.BookName = TitleTextBox.Text;
                b.AuthorName = AuthorTextBox.Text;
                b.Price = double.Parse(PriceTextBox.Text);
                b.Read = false;

                GlobalConfig.Connection.CreateBookModel(b);

                callingForm.BookComplete(b);

                this.Close();
            }
            else if (book != null)
            {
                book.BookName = TitleTextBox.Text;
                book.AuthorName = AuthorTextBox.Text;
                book.Price = double.Parse(PriceTextBox.Text);


            }
        }
    }
}
