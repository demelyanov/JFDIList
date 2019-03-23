using JFDIList.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JFDIList.Services.Tasks
{
    public class TasksService : ITasksService
    {
        private readonly ITasksRepository _tasksRepository;

        public TasksService(ITasksRepository tasksRepository) => _tasksRepository = tasksRepository;
    }
}
