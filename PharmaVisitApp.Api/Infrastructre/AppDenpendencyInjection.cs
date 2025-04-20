using PharmaVisitApp.Api.Entities.Interfaces;
using PharmaVisitApp.Api.Entities.Services;

namespace PharmaVisitApp.Api.Infrastructre
{
    public static class AppDenpendencyInjection
    {
        public static IServiceCollection Inject(this IServiceCollection services)
        {
            services.AddDbContext<PharmaVisitDbContext>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IProfileService, ProfileService>();
            return services;
        }
    }
}
