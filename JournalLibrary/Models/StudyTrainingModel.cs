using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class StudyTrainingModel : TrainingModel
    {
        public int BookStudiedId { get; set; }

        public StudyTrainingModel() { }

        public StudyTrainingModel(double time, DateTime date, int bookId)
        {
            Time = time;
            Date = date;
            BookStudiedId = bookId;
        }
    }
}
