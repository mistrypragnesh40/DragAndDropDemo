using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDropDemo.Models
{
    public class TaskModel
    {
        public string TaskName { get; set; }
        public int TaskStatus { get; set; }
        public int TaskId { get; set; }
    }

    public enum TaskStatusOption
    {
        NewTask,
        InProgress,
        InReview,
        Done
    }
}
