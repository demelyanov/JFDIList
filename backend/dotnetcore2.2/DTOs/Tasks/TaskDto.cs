using System;
using System.Collections.Generic;
using System.Text;

namespace JFDIList.DTOs.Tasks
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public DateTime? TaskDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
