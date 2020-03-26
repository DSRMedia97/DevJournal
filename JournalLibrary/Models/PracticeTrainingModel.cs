using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class PracticeTrainingModel : TrainingModel
    {
        public PracticeTrainingModel() { }

        public PracticeTrainingModel(int categoryId, double time, DateTime date, string description)
        {
            CategoryId = categoryId;
            Time = time;
            Date = date;
            TrainingDescription = description;
        }
    }
}
