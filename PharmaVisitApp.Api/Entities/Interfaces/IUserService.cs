using PharmaVisitApp.Api.Entities.Entities;

namespace PharmaVisitApp.Api.Entities.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetAsync(string username, string password);
        Task CreateAdmin();
    }
}
