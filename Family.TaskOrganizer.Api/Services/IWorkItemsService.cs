using System;
using Family.TaskOrganizer.Api.Models;

namespace Family.TaskOrganizer.Api.Services
{
    public interface IWorkItemsService
    {
        void AddWorkItem(Guid boardId, WorkItem task);
    }
}