using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalLibrary.Models
{
    public class ProjectModel
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public DateTime CompleteByDate { get; set; }
        public DateTime CompletedOnDate { get; set; }
        public bool completed { get; set; }
        public List<TaskModel> Tasks { get; set; } = new List<TaskModel>();
    }
}
