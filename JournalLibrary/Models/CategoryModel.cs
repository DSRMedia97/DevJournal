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
        public List<TrainingModel> Trainings { get; set; } = new List<TrainingModel>();
        public List<int> BookIds { get; set; } = new List<int>();

        public CategoryModel() { }

        public CategoryModel(string name)
        {
            CategoryName = name;
        }

        public CategoryModel(string name, List<TrainingModel> trainings, List<int> bookIds)
        {
            CategoryName = name;
            Trainings = trainings;
            BookIds = bookIds;
        }

        public double TotalStudyTime()
        {
            double output = 0;

            foreach (StudyTrainingModel studyTraining in Trainings)
            {
                output += studyTraining.Time;
            }

            return output;
        }
    }
}
