using Microsoft.EntityFrameworkCore;
using PharmaVisitApp.Api.Entities.Entities;

namespace PharmaVisitApp.Api.Infrastructre
{
    public class PharmaVisitDbContext : DbContext
    {
        public PharmaVisitDbContext(DbContextOptions<PharmaVisitDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UsePropertyAccessMode(PropertyAccessMode.PreferField);
            builder.ApplyConfigurationsFromAssembly(typeof(PharmaVisitDbContext).Assembly);
            base.OnModelCreating(builder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Geo> Geos { get; set; }
    }
}
