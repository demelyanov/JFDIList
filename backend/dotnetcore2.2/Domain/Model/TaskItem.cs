using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JFDIList.Domain.Model
{
    public class TaskItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Task { get; set; }
        public DateTime? TaskDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public IEnumerable<TaskTag> TagsTask { get; set; }
    }
}
