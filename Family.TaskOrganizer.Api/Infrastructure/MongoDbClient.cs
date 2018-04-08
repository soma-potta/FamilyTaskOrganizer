using System.Collections.Generic;
using System.Security.Authentication;
using MongoDB.Driver;

namespace Family.TaskOrganizer.Api.Infrastructure
{
    public class MongoDbClient : IDbClient<MongoClient>
    {
        private string _host = "";
        private string _dbName = "";
        private string _password = "";
        private string _username = "";

        public MongoClient GetClient()
        {
            MongoClientSettings settings = new MongoClientSettings
            {
                Server = new MongoServerAddress(_host, 10255),
                UseSsl = true,
                SslSettings = new SslSettings {EnabledSslProtocols = SslProtocols.Tls12}
            };

            MongoIdentity identity = new MongoInternalIdentity(_dbName, _username);
            MongoIdentityEvidence evidence = new PasswordEvidence(_password);
        
            settings.Credentials = new List<MongoCredential>()
            {
                new MongoCredential("SCRAM-SHA-1", identity, evidence)
            };

            return new MongoClient(settings);
        }
    }
}
