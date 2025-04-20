using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaVisitApp.Api.Domain.Entities;

namespace PharmaVisitApp.Api.Infrastructre.Configuration
{
    public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Action).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.Controller).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.Area).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.Path).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.CssIcon).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.Order).IsRequired(true);
            builder.Property(x => x.ProfileId).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.Title).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.TagTitle).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.TagNumber).IsRequired(false);

            //Audit
            builder.Property(x => x.CreatedAt).IsRequired(true).HasColumnType("date");
            builder.Property(x => x.CreatedBy).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.ModifiedAt).IsRequired(false).HasColumnType("date");
            builder.Property(x => x.ModifiedBy).IsRequired(false).HasMaxLength(100);
        }
    }
}
