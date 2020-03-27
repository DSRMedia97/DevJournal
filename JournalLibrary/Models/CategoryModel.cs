﻿using System;
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

        public CategoryModel() { }

        /// <summary>
        /// Basic Category constructor for lists
        /// </summary>
        /// <param name="name">Name of the Category.</param>
        public CategoryModel(string name)
        {
            CategoryName = name;
        }

        public CategoryModel(string name, List<TrainingModel> trainings)
        {
            CategoryName = name;
            Trainings = trainings;
        }

        public double GetTotalStudyHours()
        {
            double output = 0;

            if (Trainings != null)
            {
                foreach (StudyTrainingModel sm in Trainings)
                {
                    output += sm.Time;
                }
            }

            return output;
        }

        public double GetTotalPracticeHours()
        {
            double output = 0;

            if (Trainings != null)
            {
                foreach (PracticeTrainingModel pm in Trainings)
                {
                    output += pm.Time;
                }
            }

            return output;
        }
    }
}
