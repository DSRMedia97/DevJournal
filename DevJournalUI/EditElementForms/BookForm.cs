using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JournalLibrary.Models;

namespace DevJournalUI.EditElementForms
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        public BookForm(BookModel model)
        {
            InitializeComponent();

            this.TitleTextBox.Text = model.BookName;
            this.AuthorTextBox.Text = model.AuthorName;
            this.PriceTextBox.Text = model.Price.ToString();
        }
    }
}
