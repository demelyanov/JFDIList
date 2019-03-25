using JFDIList.Domain.Interfaces;
using JFDIList.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JFDIList.DataAccess.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly JfdiDbContext _context;

        public TasksRepository(JfdiDbContext context) => _context = context;

        public TaskItem Insert(TaskItem task)
        {
            task.CreatedDate = DateTime.UtcNow;
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return task;
        }
        public TaskItem Update(TaskItem task)
        {
            var origTask = _context.Tasks.Find(task.Id);
            if (null == origTask)
                return null;
            _context.Entry<TaskItem>(origTask).CurrentValues.SetValues(task);
            _context.SaveChanges();
            return origTask;
        }

        public IList<TaskItem> List()
        {
            return _context.Tasks.ToList();
        }
    }
}
