using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PharamaVisitApp.Handlers
{
    public class AuthHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = await SecureStorage.GetAsync("auth_token");

            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var response = await base.SendAsync(request, cancellationToken);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                await HandleTokenExpiredAsync();
            }

            return response;
        }

        private async Task HandleTokenExpiredAsync()
        {
            await SecureStorage.SetAsync("auth_token", string.Empty);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Shell.Current.DisplayAlert("Session Expired", "Please log in again.", "OK");
                await Shell.Current.GoToAsync("/");
            });
        }
    }
}
