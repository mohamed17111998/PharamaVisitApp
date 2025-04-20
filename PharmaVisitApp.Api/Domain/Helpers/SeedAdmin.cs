using Microsoft.EntityFrameworkCore;
using PharmaVisitApp.Api.Domain.Entities;
using PharmaVisitApp.Api.Infrastructre;

namespace PharmaVisitApp.Api.Domain.Helpers
{
    public static class SeedAdmin
    {
        public static async Task Seed(this IServiceProvider services)
        {
            await services.SeedProfiles();
            await services.SeedUserAdmin();
        }

        private static async Task SeedProfiles(this IServiceProvider services)
        {
            List<Profile> profiles = new List<Profile>()
            {
                new Profile("P1", "Admin"),
                new Profile("P2", "DPH"),
                new Profile("P3", "DSM"),
                new Profile("P4", "DIR"),
                new Profile("P5", "NSM"),
            };

            using (var scope = services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<PharmaVisitDbContext>();
                foreach (var profile in profiles)
                {
                    Profile? existingProfile = dbContext.Profiles.SingleOrDefault(x => x.Reference == profile.Reference);
                    if (existingProfile == null) await dbContext.Profiles.AddAsync(profile);
                }
                await dbContext.SaveChangesAsync();
            }
        }

        private static async Task SeedUserAdmin(this IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<PharmaVisitDbContext>();
                User? existingUser = await dbContext.Users.FirstOrDefaultAsync(x => x.Username == "admin");
                if (existingUser != null) return;

                Profile profile = await dbContext.Profiles.SingleAsync(x => x.Reference == "P1");
                (byte[] hash, byte[] salt) password = PasswordHelper.CreatePasswordHash("Admin@123");
                User user = new User("admin", "admin", "admin", "admin@gmail.com", null, null, null, password.salt, password.hash, true,
                    profile.Id, null, true, new List<Geo>());
                dbContext.Users.Add(user);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
