using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JFDIList.Domain.Model
{
    public class TaskTag
    {
        [ForeignKey("TaskItem")]
        public int TaskId { get; set; }
        public TaskItem Task { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
