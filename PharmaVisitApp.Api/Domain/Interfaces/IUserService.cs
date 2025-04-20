using PharmaVisitApp.Api.Domain.Entities;

namespace PharmaVisitApp.Api.Domain.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetAsync(string username, string password);
    }
}
