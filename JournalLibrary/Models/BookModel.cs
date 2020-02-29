using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class BookModel
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public List<CategoryModel> Categories { get; set; }
        public double Price { get; set; }
        public bool Read { get; set; }

        public BookModel() { }

        public BookModel( string name, string author, double price, bool read )
        {
            BookName = name;
            AuthorName = author;
            Price = price;
            Read = read;
        }
    }
}
