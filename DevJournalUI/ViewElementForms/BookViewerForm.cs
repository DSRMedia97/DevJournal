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
    public partial class BookViewerForm : Form, IBookRequester
    {
        private List<BookModel> allAvailableBooks = GlobalConfig.Connection.LoadAllBooks();
        private BookModel selectedBook = new BookModel();

        public BookViewerForm()
        {
            InitializeComponent();

            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            allAvailableBooks.Add(new BookModel("Gotham Knights", "Bruce Wayne", 10.40, false));
            allAvailableBooks.Add(new BookModel("Smallville", "Clark Kent", 4.95, true));
        }

        private void WireUpLists()
        {
            BookListBox.DataSource = null;
            BookListBox.DataSource = allAvailableBooks;
            BookListBox.DisplayMember = "BookName";
        }

        private void NewBookButton_Click(object sender, EventArgs e)
        {
            BookForm frm = new BookForm(this);
            frm.Text = "Add New Book";
            frm.Show();
        }

        public void BookComplete(BookModel model)
        {
            allAvailableBooks.Add(model);

            WireUpLists();
        }

        private void EditBookButton_Click(object sender, EventArgs e)
        {
            BookForm frm = new BookForm(this, selectedBook);
            frm.Text = "Edit Book";
            frm.Show();
        }

        public void BookUpdate(BookModel model)
        {
            WireUpLists();
        }

        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO - app will crash if it fails to cast to BookModel
            selectedBook = (BookModel)BookListBox.SelectedItem;
            if(selectedBook != null)
            {
                RefreshSelectedBookData();
            }
        }

        private void RefreshSelectedBookData()
        {
            SelectedBookTitleLabel.Text = selectedBook.BookName;
            SelectedBookAuthorValue.Text = selectedBook.AuthorName;
            SelectedBookPriceValue.Text = $"${ selectedBook.Price.ToString()}";
            SelectedBookReadValue.Checked = selectedBook.Read;
        }
    }
}
