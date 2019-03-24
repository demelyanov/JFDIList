using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JFDIList.Domain.Interfaces;
using JFDIList.DTOs.Tasks;
using JFDIList.Services.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksService _tasksService;

        public TasksController(ITasksService tasksService) => _tasksService = tasksService;

        [HttpGet]
        public ActionResult<IEnumerable<TaskDto>> Get()
        {
            return null;
        }

        [HttpPost]
        public ActionResult<TaskDto> Post([FromBody] TaskDto model) {
            return NotFound();
        }

        [HttpPut]
        public ActionResult<TaskDto> Update([FromBody] TaskDto model)
        {
            return NotFound();
        }
    }
}