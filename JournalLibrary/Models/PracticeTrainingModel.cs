using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    class PracticeTrainingModel : TrainingModel
    {
        public string ProjectName { get; set; } // eventually swap this for ProjectModel

        public PracticeTrainingModel() { }

        public PracticeTrainingModel(double time, DateTime date, string name)
        {
            Time = time;
            Date = date;
            ProjectName = name;
        }
    }
}
