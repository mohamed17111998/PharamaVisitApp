using System.Security.Cryptography;

namespace PharmaVisitApp.Api.Domain.Helpers
{
    public static class PasswordHelper
    {
        public static (byte[] hash, byte[] salt) CreatePasswordHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                byte[] passwordSalt = hmac.Key;
                byte[] passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return new(passwordHash, passwordHash);
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(storedHash);
            }
        }
    }
}
