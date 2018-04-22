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
        [Route("boards/{boardId}/tasks/add")]
        public ActionResult Post(Guid boardId, [FromBody]WorkItem workItem)
        {
            //validate access to the board id

            //validate request body through an action filter

            //add task to board
            _workItemsService.AddWorkItem(boardId, workItem);
            return Ok();
        }
    }
}
