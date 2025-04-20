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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=PharmaVisit;Trusted_Connection=True;TrustServerCertificate=True;",
                    sqlOptions => sqlOptions.EnableRetryOnFailure()
                );
            }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Geo> Geos { get; set; }
    }
}
