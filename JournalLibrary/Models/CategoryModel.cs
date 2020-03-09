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
        public double Hours { get; set; }
        public List<int> BookIds { get; set; } = new List<int>();

        public CategoryModel() { }

        public CategoryModel(string name)
        {
            CategoryName = name;
        }

        public CategoryModel(string name, double hours, List<int> bookIds)
        {
            CategoryName = name;
            Hours = hours;
            BookIds = bookIds;
        }

        public void AddHours(double timeToAdd)
        {
            Hours += timeToAdd;
        }
    }
}
