using System;
using Family.TaskOrganizer.Api.Models;
using Family.TaskOrganizer.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Family.TaskOrganizer.Api.Controllers
{
    [Route("api/v1")]
    public class WorkItemsController : Controller
    {
        private readonly IWorkItemsService _workItemsService;

        public WorkItemsController(IWorkItemsService workItemsService)
        {
            _workItemsService = workItemsService;
        }

        [HttpPost]
        [Route("boards/{Guid: boardId}/tasks/add")]
        public void Post([FromBody]WorkItem workItem)
        {
            //validate access to the board id

            //validate request body through an action filter

            //add task to board
            var boardId = Guid.Empty;
            _workItemsService.AddWorkItem(boardId, workItem);
        }
    }
}
