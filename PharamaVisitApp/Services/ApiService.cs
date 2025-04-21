using PharamaVisitApp.Models;
using System.Text;
using System.Text.Json;

namespace PharamaVisitApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("PharmacieVisitClient");
        }

        public async Task<UserLoginDto> LoginAsync(string username, string password)
        {
            var loginPayload = new
            {
                Username = username,
                Password = password
            };

            var content = new StringContent(JsonSerializer.Serialize(loginPayload), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("auth/login", content);

            // a revoir les messages d'erreurs
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return new UserLoginDto { Success = false, Message = "Utilisateur introuvable." };

            var token = await response.Content.ReadAsStringAsync();
            await SecureStorage.SetAsync("auth_token", token);

            return new UserLoginDto
            {
                Token = token,
                Success = true,
                Message = "Connexion avec success"
            };
        }
    }
}
