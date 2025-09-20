using Polyglot.Core.Entities;

namespace Polyglot.Core.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<bool> ExistsAsync(string email);
    }
}
