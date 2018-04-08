using Family.TaskOrganizer.Api.Infrastructure;
using Family.TaskOrganizer.Api.Infrastructure.Repositories;

namespace Family.TaskOrganizer.Api.Services
{
    public class TasksService : ITasksService
    {
        private IRepository<BoardsRepository> _boardsRepository;

        public TasksService(IRepository<BoardsRepository> boardsRepository)
        {
            _boardsRepository = boardsRepository;
        }

        public void AddTask()
        {
            throw new System.NotImplementedException();
        }
    }
}
