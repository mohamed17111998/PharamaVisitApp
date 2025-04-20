using Microsoft.EntityFrameworkCore;
using PharmaVisitApp.Api.Entities.Entities;
using PharmaVisitApp.Api.Entities.Interfaces;
using PharmaVisitApp.Api.Infrastructre;
using System.Security.Cryptography;

namespace PharmaVisitApp.Api.Entities.Services
{
    public class UserService : IUserService
    {
        private readonly PharmaVisitDbContext _context;
        public UserService(PharmaVisitDbContext context)
        {
            _context = context;
        }
        public async Task<User?> GetAsync(string username, string password)
        {
            return await _context.Users.SingleOrDefaultAsync(x=> x.Username.Equals(username, StringComparison.CurrentCultureIgnoreCase) &&
            CryptographicOperations.FixedTimeEquals(Convert.FromBase64String(x.PasswordHash), Convert.FromBase64String(password)));
        }

        public async Task CreateAdmin()
        {
            (string salt, string hash) password = getPassword("Admin!@(23*)");
            User user = new User("admin", "admin", "admin", "admin@gmail.com", null, null, null, password.salt, password.hash, "S1", 
                Guid.Parse("b1e7692d-9d0f-4f25-a352-67515b7fbeb4"), null, true, new List<Geo>());
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        private (string salt, string hash) getPassword(string password)
        {
            // Generate a 128-bit salt (16 bytes)
            byte[] saltBytes = RandomNumberGenerator.GetBytes(16);

            // Derive a 256-bit subkey (32 bytes) using PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100_000, HashAlgorithmName.SHA256);
            byte[] hashBytes = pbkdf2.GetBytes(32);

            // Convert to base64 for storage
            string salt = Convert.ToBase64String(saltBytes);
            string hash = Convert.ToBase64String(hashBytes);

            return new(salt, hash);
        }
    }
}