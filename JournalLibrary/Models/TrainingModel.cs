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
    }
}
