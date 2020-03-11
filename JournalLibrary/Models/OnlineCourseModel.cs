using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class OnlineCourseModel : LibraryModel
    {
        public string CourseName { get; set; }
        public string CourseLink { get; set; }

        public OnlineCourseModel() { }

        public OnlineCourseModel(string name, string link)
        {
            CourseName = name;
            CourseLink = link;
        }
    }
}
