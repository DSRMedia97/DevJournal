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
        private List<BookModel> selectedBooks = GlobalConfig.Connection.LoadAllBooks();
        private BookModel selectedBook = new BookModel();
        private double totalCost = 0;

        public BookViewerForm()
        {
            InitializeComponent();

            //CreateSampleData();
            WireUpLists();
            RefreshTotalCost();
        }

        private void CreateSampleData()
        {
            allAvailableBooks.Add(new BookModel("Gotham Knights", "Bruce Wayne", 10.40, false));
            allAvailableBooks.Add(new BookModel("Smallville", "Clark Kent", 4.95, true));
        }

        private void WireUpLists()
        {
            BookListBox.DataSource = null;
            BookListBox.DataSource = selectedBooks;
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
            RefreshSelectedBookList();
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
            RefreshSelectedBookList();
            WireUpLists();
        }

        //TODO - not scalable; increase in memory usage every time this runs.
        private void RefreshSelectedBookList()
        {
            selectedBooks.Clear();

            foreach (BookModel b in allAvailableBooks)
            {
                //if Unread Only checkbox is marked and the book is unread add it to the list
                if (UnreadOnlyCheckBox.Checked && !b.Read)
                {
                    selectedBooks.Add(b);
                }
                else if (!UnreadOnlyCheckBox.Checked)
                {
                    selectedBooks.Add(b);
                }
            }

            RefreshTotalCost();
        }

        private void RefreshTotalCost()
        {
            totalCost = 0f;

            foreach (BookModel b in selectedBooks)
            {
                totalCost += b.Price;    
            }

            TotalCostValue.Text = totalCost.ToString();
        }

        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void UnreadOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshSelectedBookList();
            WireUpLists();
        }
    }
}
