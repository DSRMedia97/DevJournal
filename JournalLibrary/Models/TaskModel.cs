using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class TaskModel : ProjectModel
    {
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public double EstimatedTimeToComplete { get; set; }
        public double ActualTimeToComplete { get; set; }
    }
}
