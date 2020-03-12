using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class BookModel : LibraryModel
    {
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public bool Read { get; set; }

        public BookModel() { }

        public BookModel(string name, string author, double price, bool read)
        {
            Title = name;
            AuthorName = author;
            Price = price;
            Read = read;
        }
    }
}
