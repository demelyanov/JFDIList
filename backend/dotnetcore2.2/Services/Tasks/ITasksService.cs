using JFDIList.DTOs.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace JFDIList.Services.Tasks
{
    public interface ITasksService
    {
        IList<TaskDto> List();
        TaskDto Save(TaskDto task);
    }
}
