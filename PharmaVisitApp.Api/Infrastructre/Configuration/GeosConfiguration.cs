using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaVisitApp.Api.Domain.Entities;

namespace PharmaVisitApp.Api.Infrastructre.Configuration
{
    public class GeosConfiguration : IEntityTypeConfiguration<Geo>
    {
        public void Configure(EntityTypeBuilder<Geo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.UG).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.CodeIMS).IsRequired(false);
            builder.Property(x => x.UGIMS).IsRequired(false).HasMaxLength(255);
        }
    }
}