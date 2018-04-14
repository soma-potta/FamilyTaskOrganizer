using System;
using System.Threading.Tasks;
using Family.TaskOrganizer.Api.Infrastructure;
using Family.TaskOrganizer.Api.Infrastructure.Repositories;
using Family.TaskOrganizer.Api.Models;

namespace Family.TaskOrganizer.Api.Services
{
    public class WorkItemsService : IWorkItemsService
    {
        private IBoardsRepository _boardsRepository;

        public WorkItemsService(IBoardsRepository boardsRepository)
        {
            _boardsRepository = boardsRepository;
        }

        public void AddWorkItem(Guid boardId, WorkItem workItem)
        {
            _boardsRepository.AddWorkItem(boardId, workItem);
        }
    }
}
