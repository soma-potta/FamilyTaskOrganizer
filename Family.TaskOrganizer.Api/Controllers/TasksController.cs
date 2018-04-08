using Family.TaskOrganizer.Api.Models;
using Family.TaskOrganizer.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Family.TaskOrganizer.Api.Controllers
{
    [Route("api/v1")]
    public class TasksController : Controller
    {
        private ITasksService _tasksService;

        public TasksController(ITasksService tasksService)
        {
            _tasksService = tasksService;
        }

        [HttpPost]
        [Route("boards/{Guid: boardId}/tasks/add")]
        public void Post([FromBody]Task task)
        {
            //validate access to the board id

            //add task to board
            _tasksService.AddTask();
        }
    }
}
