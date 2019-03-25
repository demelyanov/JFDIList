using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JFDIList.DTOs.Tasks
{
    public class TaskDto
    {
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }
        public DateTime? TaskDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Done { get; set; }
        public bool Important { get; set; }
        public bool Urgently { get; set; }
    }
}
