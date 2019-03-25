using JFDIList.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JFDIList.Domain.Interfaces
{
    public interface ITasksRepository
    {
        IList<TaskItem> List();
        TaskItem Insert(TaskItem task);
        TaskItem Update(TaskItem task);
    }
}
