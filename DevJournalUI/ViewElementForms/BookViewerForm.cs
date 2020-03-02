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
        private List<BookModel> allAvailableBooks = GlobalConfig.Connection.LoadAllBooks();
        private List<BookModel> selectedBooks = new List<BookModel>();
        private BookModel selectedBook = new BookModel();
        private List<CategoryModel> availableCategories = new List<CategoryModel>();
        private double totalCost = 0;

        public BookViewerForm()
        {
            InitializeComponent();

            RefreshCategories();
            RefreshSelectedBookList();
            WireUpLists();
        }

        private void WireUpLists()
        {
            BookListBox.DataSource = null;
            BookListBox.DataSource = selectedBooks;
            BookListBox.DisplayMember = "BookName";
        }

        private void RefreshCategories()
        {
            availableCategories = GlobalConfig.Connection.LoadAllCategories();
            FilterCategoryDropdown.DataSource = null;
            FilterCategoryDropdown.DataSource = availableCategories;
            FilterCategoryDropdown.DisplayMember = "CategoryName";
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
            allAvailableBooks[allAvailableBooks.FindIndex(x => x.ID == model.ID)] = model;
            RefreshSelectedBookList();
            WireUpLists();
        }

        //TODO - not scalable; increase in memory usage every time this runs.
        private void RefreshSelectedBookList()
        {
            selectedBooks.Clear();

            CategoryModel category = (CategoryModel)FilterCategoryDropdown.SelectedItem;

            //When "Unread Only" is left unmarked we want all books regardless of read status
            if (!UnreadOnlyCheckBox.Checked)
            {
                //If there is a category selected in the dropdown and it's not 1 ("All") then add books that match the category id.
                if (category !=null && category.ID != 1)
                {
                    foreach (BookModel b in allAvailableBooks)
                    {
                        foreach (CategoryModel c in b.Categories)
                        {
                            if (c.ID == category.ID)
                            {
                                selectedBooks.Add(b);
                            }
                        }
                    }
                }
                //If there is no category selected or the category is 1 ("All") then add all available books.
                else if (category == null || category.ID == 1)
                {
                    foreach (BookModel b in allAvailableBooks)
                    {
                        selectedBooks.Add(b);
                    }
                }
            }
            //We need to check read status in operations
            else if (UnreadOnlyCheckBox.Checked)
            {
                if (category != null && category.ID != 1)
                {
                    foreach (BookModel b in allAvailableBooks)
                    {
                        if (!b.Read)
                        {
                            foreach (CategoryModel c in b.Categories)
                            {
                                if (c.ID == category.ID)
                                {
                                    selectedBooks.Add(b);
                                }
                            } 
                        }
                    }
                }
                //If there is no category selected or the category is 1 ("All") then add all available books.
                else if (category == null || category.ID == 1)
                {
                    foreach (BookModel b in allAvailableBooks)
                    {
                        if (!b.Read)
                        {
                            selectedBooks.Add(b); 
                        }
                    }
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
            CategoriesValue.Text = selectedBook.FullCategoryValue;
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
