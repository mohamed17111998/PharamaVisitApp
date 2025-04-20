using Microsoft.EntityFrameworkCore;
using PharmaVisitApp.Api.Domain.Entities;

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
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Geo> Geos { get; set; }
        public DbSet<Cycle> Cycles { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Pharmacie> Pharmacies { get; set; }
        public DbSet<Planification> Planifications { get; set; }
        public DbSet<PharmaLog> PharmaLogs { get; set; }
        public DbSet<Visite> Visites { get; set; }
    }
}
