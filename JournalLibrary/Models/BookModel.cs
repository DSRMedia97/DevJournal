using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    class BookModel
    {
        int ID { get; set; }
        string BookName { get; set; }
        string AuthorName { get; set; }
        List<CategoryModel> Categories { get; set; }
        double Price { get; set; }
        bool Read { get; set; }
    }
}
