using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public partial class TrainingModel
    {
        public int Id { get; set; }
        public string TrainingDescription { get; set; }
        public int CategoryId { get; set; }
        public double Time { get; set; }
        public DateTime Date { get; set; } = new DateTime();
        public int MaterialId { get; set; }
        public Type TrainingType { get; set; }
        public Source TrainingSource { get; set; }

        public enum Type
        {
            Studying,
            Practicing
        }

        public enum Source
        {
            Book,
            OnlineCourse,
            Project
        }
    }
}
