using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public partial class TrainingModel
    {
        public int Id { get; set; }
        public int materialId { get; set; }
        public double Time { get; set; }
        public DateTime Date { get; set; } = new DateTime();
        //replace source with materialId - foriegn key reference to project or book / course 
        //would still need Source to know which table to look into for additional data
        public Source TrainingSource { get; set; }

        public enum Source
        {
            Project, 
            Book,
            YouTube
        }
    }
}
