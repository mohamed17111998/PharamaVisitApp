using Microsoft.EntityFrameworkCore;
using PharmaVisitApp.Api.Entities.Entities;
using PharmaVisitApp.Api.Entities.Interfaces;
using PharmaVisitApp.Api.Infrastructre;

namespace PharmaVisitApp.Api.Entities.Services
{
    public static class SeedAdmin
    {
        public static async Task Seed(this IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                var userService = scope.ServiceProvider.GetRequiredService<IUserService>();
                var dbContext = scope.ServiceProvider.GetRequiredService<PharmaVisitDbContext>();

                User? user = await dbContext.Users.SingleOrDefaultAsync(x => x.Username == "admin");
                if(user == null) await userService.CreateAdmin();
            }
        }
    }
}
