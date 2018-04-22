using System;
using Family.TaskOrganizer.Api.Models;

namespace Family.TaskOrganizer.Api.Infrastructure.Repositories
{
    public interface IBoardsRepository
    {
       void AddWorkItem(Guid boardId, WorkItem workItem);
    }
}
