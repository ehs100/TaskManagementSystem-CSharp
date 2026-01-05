
using Microsoft.AspNetCore.Mvc;
using TaskManager.Core.Service;
using TaskManager.Core.Domain;

namespace TaskManager.Api.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class TasksController : ControllerBase
        {
            private readonly TaskService _service;

            public TasksController(TaskService service)
            {
                _service = service;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                return Ok(_service.GetAll());
            }

        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            var created = _service.Create(task.Title, task.Description, task.DueDate);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var task = _service.GetById(id);
            if (task == null)
                return NotFound();

            return Ok(task);
        }



        [HttpPut("{id}/toggle")]
            public IActionResult ToggleDone(string id)
            {
                var success = _service.ToggleDone(id);
                return success ? Ok() : NotFound();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(string id)
            {
                _service.Delete(id);
                return Ok();
            }
        }
    }



