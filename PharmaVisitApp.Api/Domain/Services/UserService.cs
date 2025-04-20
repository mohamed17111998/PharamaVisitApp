using Microsoft.EntityFrameworkCore;
using PharmaVisitApp.Api.Domain.Entities;
using PharmaVisitApp.Api.Domain.Helpers;
using PharmaVisitApp.Api.Domain.Interfaces;
using PharmaVisitApp.Api.Infrastructre;

namespace PharmaVisitApp.Api.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly PharmaVisitDbContext _context;
        public UserService(IServiceProvider serviceProvider, PharmaVisitDbContext context)
        {
            _serviceProvider = serviceProvider;
            _context = context;
        }
        public async Task<User?> GetAsync(string username, string password)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x =>x.Username.ToLower() == username.ToLower());
            if (user == null) return null;
            return user;
            bool passwordMatch = PasswordHelper.VerifyPasswordHash(password.Trim(), user.PasswordHash, user.PasswordSalt);
            return passwordMatch ? user : null;
        }

    }
}