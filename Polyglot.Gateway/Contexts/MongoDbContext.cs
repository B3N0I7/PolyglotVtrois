using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Polyglot.Core.Entities;
using Polyglot.Gateway.Configurations;

namespace Polyglot.Gateway.Contexts
{
    public class MongoDbContext
    {
        public IMongoDatabase Database { get; }

        public MongoDbContext(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            Database = client.GetDatabase(settings.Value.DatabaseName);

        }

        public IMongoCollection<User> Users => Database.GetCollection<User>("Users");
    }
}
