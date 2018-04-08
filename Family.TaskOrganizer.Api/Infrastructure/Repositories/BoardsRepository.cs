using MongoDB.Driver;

namespace Family.TaskOrganizer.Api.Infrastructure.Repositories
{
    public class BoardsRepository : IRepository<BoardsRepository>
    {
        private IDbClient<MongoClient> _dbClient;

        public BoardsRepository(IDbClient<MongoClient> dbClient)
        {
            _dbClient = dbClient;
        }
    }
}
