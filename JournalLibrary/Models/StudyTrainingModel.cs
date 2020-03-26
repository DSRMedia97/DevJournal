using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class StudyTrainingModel : TrainingModel
    {
        public LibraryModel StudyMaterial { get; set; }

        public StudyTrainingModel() { }

        /// <summary>
        /// Constructor when the material studied is known and stored
        /// </summary>
        /// <param name="categoryId">Category this study session belongs to.</param>
        /// <param name="time">Approximate time in hours spent studying.</param>
        /// <param name="date">Date the study session occurred.</param>
        /// <param name="studyMaterial">The material that was studied (book or online course).</param>
        public StudyTrainingModel(int categoryId, double time, DateTime date, LibraryModel studyMaterial)
        {
            CategoryId = categoryId;
            Time = time;
            Date = date;
            StudyMaterial = studyMaterial;
        }

        /// <summary>
        /// Constructor when the study session was more ambiguous and the material studied is either not known or not saved.
        /// </summary>
        /// <param name="categoryId">Category this study session belongs to.</param>
        /// <param name="time">Approximate time in hours spent studying.</param>
        /// <param name="date">Date the study session occured.</param>
        /// <param name="description">Description of what was studied during this time.</param>
        public StudyTrainingModel(int categoryId, double time, DateTime date, string description)
        {
            CategoryId = categoryId;
            Time = time;
            Date = date;
            TrainingDescription = description;
        }
    }
}
