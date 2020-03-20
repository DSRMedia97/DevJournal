using System;
using System.Collections.Generic;
using System.Configuration;
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
        private List<BookModel> selectedBooks = new List<BookModel>();
        private BookModel selectedBook = new BookModel();
        private List<CategoryModel> availableCategories = GlobalConfig.Connection.LoadAllCategories();
        private double totalCost = 0;

        public BookViewerForm()
        {
            InitializeComponent();

            this.Text = "Book Library";

            RefreshSelectedBookList();
            WireUpDropDowns();
            WireUpLists();
        }

        private void WireUpDropDowns()
        {
            FilterCategoryDropdown.DataSource = null;
            FilterCategoryDropdown.DataSource = availableCategories;
            FilterCategoryDropdown.DisplayMember = "CategoryName";
            FilterCategoryDropdown.SelectedIndex = 0;
        }

        private void WireUpLists()
        {
            BookListBox.DataSource = null;
            BookListBox.DataSource = selectedBooks;
            BookListBox.DisplayMember = "Title";
        }

        private void NewBookButton_Click(object sender, EventArgs e)
        {
            BookForm frm = new BookForm(this);
            frm.Show();
        }

        public void BookComplete()
        {
            RefreshSelectedBookList();
            WireUpLists();
        }

        private void EditBookButton_Click(object sender, EventArgs e)
        {
            BookForm frm = new BookForm(this, selectedBook);
            frm.Show();
        }

        private void RefreshSelectedBookList()
        {
            selectedBooks.Clear();

            CategoryModel category = (CategoryModel)FilterCategoryDropdown.SelectedItem;
            
            if (category == null)
            {
                category = new CategoryModel();
                category.ID = 1;
            }
            selectedBooks = GlobalConfig.Connection.LoadBooksByCategory(category.ID, UnreadOnlyCheckBox.Checked);

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
            SelectedBookTitleLabel.Text = selectedBook.Title;
            SelectedBookAuthorValue.Text = selectedBook.AuthorName;
            SelectedBookPriceValue.Text = $"${ selectedBook.Price.ToString()}";
            SelectedBookReadValue.Checked = selectedBook.Read;
        }

        private void UnreadOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshSelectedBookList();
            WireUpLists();
        }

        private void FilterCategoryDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelectedBookList();
            WireUpLists();
        }
    }
}
