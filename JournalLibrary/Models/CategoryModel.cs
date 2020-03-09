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
        public double StudyHours { get; set; }
        public double PracticeHours { get; set; }
        public List<int> BookIds { get; set; } = new List<int>();

        public CategoryModel() { }

        public CategoryModel(string name)
        {
            CategoryName = name;
            StudyHours = 0;
            PracticeHours = 0;
        }

        public CategoryModel(string name, double studyHours, double practiceHours, List<int> bookIds)
        {
            CategoryName = name;
            StudyHours = studyHours;
            PracticeHours = practiceHours;
            BookIds = bookIds;
        }

        public double TotalHours()
        {
            return PracticeHours + StudyHours;
        }
    }
}
