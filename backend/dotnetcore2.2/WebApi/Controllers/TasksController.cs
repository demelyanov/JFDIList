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
            return Ok(_tasksService.List());
        }

        [HttpPost]
        public ActionResult<TaskDto> Post([FromBody] TaskDto model)
        {
            var result = _tasksService.Save(model);
            if (null == result)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<TaskDto> Update(int id, [FromBody] TaskDto model)
        {
            return NotFound();
        }

        [HttpPost]
        [Route("done/{id}")]
        public ActionResult<TaskDto> SetTaskState(int id, [FromBody] bool done)
        {
            return NotFound();
        }
    }
}