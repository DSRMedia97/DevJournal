using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public CategoryModel() { }

        public CategoryModel(string name)
        {
            CategoryName = name;
        }
    }
}
