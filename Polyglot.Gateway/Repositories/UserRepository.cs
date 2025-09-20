using MongoDB.Driver;
using Polyglot.Core.Entities;
using Polyglot.Core.Interfaces;
using Polyglot.Gateway.Contexts;

namespace Polyglot.Gateway.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository(MongoDbContext context)
        {
            _users = context.Users;
        }

        public async Task AddAsync(User user)
        {
            await _users.InsertOneAsync(user);
        }

        public async Task<bool> ExistsAsync(string email)
        {
            return await _users.Find(u => u.Email == email).AnyAsync();
        }
    }
}
