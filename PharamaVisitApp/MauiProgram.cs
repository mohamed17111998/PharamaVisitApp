using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PharamaVisitApp.Handlers;
using PharamaVisitApp.Services;
using System.Net.Http.Headers;

namespace PharamaVisitApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddTransient<AuthHandler>();
            builder.Services.AddTransient<ApiService>();
            builder.Services.AddTransient<AuthService>();


            builder.Services.AddHttpClient("PharmacieVisitClient", client =>
            {
                client.BaseAddress = new Uri("https://localhost:1000/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }).AddHttpMessageHandler<AuthHandler>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
