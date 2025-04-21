using PharamaVisitApp.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;

namespace PharamaVisitApp.Services
{
    public class AuthService
    {
        public bool IsTokenExpired(string? token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return true;

            var handler = new JwtSecurityTokenHandler();

            // This checks if the format looks like a JWT
            if (!handler.CanReadToken(token))
                return true;

            try
            {
                var jwt = handler.ReadJwtToken(token);
                return jwt.ValidTo < DateTime.UtcNow;
            }
            catch
            {
                // Invalid token format, treat as expired
                return true;
            }
        }

        public async Task<string?> GetTokenAsync()
        {
            var token = await SecureStorage.GetAsync("auth_token");
            var container = JsonSerializer.Deserialize<TokenContainer>(token ?? string.Empty);
            return container?.Token;
        }
    }
}
