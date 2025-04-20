using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaVisitApp.Api.Domain.Entities;

namespace PharmaVisitApp.Api.Infrastructre.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x=> x.FirstName).IsRequired(true).HasMaxLength(255);
            builder.Property(x=> x.LastName).IsRequired(true).HasMaxLength(255);
            builder.Property(x=> x.Username).IsRequired(true).HasMaxLength(255);
            builder.Property(x=> x.AdConnect).IsRequired(false);
            builder.Property(x=> x.IsActive).IsRequired(true);
            builder.Property(x=> x.ResponsableId).IsRequired(false).HasMaxLength(100);
            builder.Property(x=> x.Email).IsRequired(true).HasMaxLength(100);
            builder.Property(x=> x.PhoneNumber).IsRequired(false).HasMaxLength(50);
            builder.Property(x=> x.PasswordHash).IsRequired(true);
            builder.Property(x=> x.PasswordSalt).IsRequired(true);
            builder.Property(x=> x.IsValidatedPlan).IsRequired(false);
            builder.Property(x=> x.ValidatedPlan).IsRequired(false);
            builder.Property(x=> x.ProfileId).IsRequired(true).HasMaxLength(100);

            builder.HasMany(e => e.Geos).WithMany(o => o.Users);

            //Audit
            builder.Property(x=> x.CreatedAt).IsRequired(true).HasColumnType("date");
            builder.Property(x=> x.CreatedBy).IsRequired(true).HasMaxLength(100);
            builder.Property(x=> x.ModifiedAt).IsRequired(false).HasColumnType("date");
            builder.Property(x=> x.ModifiedBy).IsRequired(false).HasMaxLength(100);
        }
    }
}