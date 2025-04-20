using Microsoft.EntityFrameworkCore;
using PharmaVisitApp.Api.Domain.Interfaces;
using PharmaVisitApp.Api.Domain.Services;

namespace PharmaVisitApp.Api.Infrastructre
{
    public static class AppDenpendencyInjection
    {
        public static IServiceCollection Inject(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PharmaVisitDbContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString("LocalConnection"),
                 sqlOptions => sqlOptions.EnableRetryOnFailure(
                 maxRetryCount: 5,
                 maxRetryDelay: TimeSpan.FromSeconds(30),
                 errorNumbersToAdd: null)));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IProfileService, ProfileService>();
            return services;
        }
    }
}
