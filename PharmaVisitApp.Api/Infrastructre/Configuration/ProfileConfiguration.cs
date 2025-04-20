using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaVisitApp.Api.Entities.Entities;

namespace PharmaVisitApp.Api.Infrastructre.Configuration
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Reference).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.Label).IsRequired(true).HasMaxLength(255);
        }
    }
}
