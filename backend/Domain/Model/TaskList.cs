using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JFDIList.Domain.Model
{
    public class TaskList
    {
        [ForeignKey("TaskItem")]
        public int TaskId { get; set; }
        public TaskItem Task { get; set; }
        public int ListId { get; set; }
        public List List { get; set; }
    }
}
