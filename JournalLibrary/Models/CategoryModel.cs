using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class CategoryModel
    {
        int ID { get; set; }
        string CategoryName { get; set; }

        public CategoryModel() { }

        public CategoryModel(string name)
        {
            CategoryName = name;
        }
    }
}
