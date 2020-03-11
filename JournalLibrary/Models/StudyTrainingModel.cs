using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class StudyTrainingModel : TrainingModel
    {
        public int StudyMaterialId { get; set; }

        public StudyTrainingModel() { }

        public StudyTrainingModel(double time, DateTime date, int materialID, Source source)
        {
            Time = time;
            Date = date;
            StudyMaterialId = materialID;
            trainingSource = source;
        }
    }
}
