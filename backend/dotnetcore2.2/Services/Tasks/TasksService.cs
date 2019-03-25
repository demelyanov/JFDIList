using AutoMapper;
using JFDIList.Domain.Interfaces;
using JFDIList.Domain.Model;
using JFDIList.DTOs.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace JFDIList.Services.Tasks
{
    public class TasksService : ITasksService
    {
        private readonly ITasksRepository _tasksRepository;
        private readonly IMapper _mapper;

        public TasksService(ITasksRepository tasksRepository, IMapper mapper)
        {
            _tasksRepository = tasksRepository;
            _mapper = mapper;
        }

        public TaskDto Save(TaskDto task)
        {
            var taskItem = _mapper.Map<TaskItem>(task);
            if (0 == taskItem.Id)
                taskItem = _tasksRepository.Insert(taskItem);
            else
                taskItem = _tasksRepository.Update(taskItem);
            return _mapper.Map<TaskDto>(taskItem);
        }

        public IList<TaskDto> List()
        {
            return _mapper.Map<IList<TaskDto>>(_tasksRepository.List());
        }
    }
}
