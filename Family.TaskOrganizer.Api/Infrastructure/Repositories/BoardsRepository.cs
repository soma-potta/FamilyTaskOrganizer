using System;
using Family.TaskOrganizer.Api.Models;
using MongoDB.Driver;

namespace Family.TaskOrganizer.Api.Infrastructure.Repositories
{
    public class BoardsRepository : IBoardsRepository
    {
        private readonly IMongoClient _mongoClient;
        private const string DbName = "TaskManagerDb";
        private const string CollectionName = "Boards";

        public BoardsRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        }

        private IMongoCollection<Board> GetBoardsCollection()
        {
            var database = _mongoClient.GetDatabase(DbName);
            var boardsCollection = database.GetCollection<Board>(CollectionName);
            return boardsCollection;
        }

        public void AddWorkItem(Guid boardId, WorkItem workItem)
        {
            var boards = GetBoardsCollection();

            var board =  boards.Find(x => x.Name == "Vacation").FirstOrDefault();
            board.WorkItems.Add(workItem);
        }
    }
}
