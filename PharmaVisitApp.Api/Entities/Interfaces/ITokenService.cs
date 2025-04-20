namespace PharmaVisitApp.Api.Entities.Interfaces
{
    public interface ITokenService
    {
        Task SaveAsync(string token);
        Task<string> GetAsync();
        void Remove();
    }
}
