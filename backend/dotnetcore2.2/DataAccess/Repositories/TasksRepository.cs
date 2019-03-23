using JFDIList.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JFDIList.DataAccess.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly JfdiDbContext _context;

        public TasksRepository(JfdiDbContext context) => _context = context;
    }
}
