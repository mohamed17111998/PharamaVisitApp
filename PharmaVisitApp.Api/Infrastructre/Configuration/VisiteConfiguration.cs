using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaVisitApp.Api.Domain.Entities;

namespace PharmaVisitApp.Api.Infrastructre.Configuration
{
    public class VisiteConfiguration : IEntityTypeConfiguration<Visite>
    {
        public void Configure(EntityTypeBuilder<Visite> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.PharmacieId).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.DateVisite).IsRequired(false).HasColumnType("date");
            builder.Property(x => x.PharmacieVu).IsRequired(false);
            builder.Property(x => x.FormationDipensee).IsRequired(false);
            builder.Property(x => x.BonCommande).IsRequired(false);
            builder.Property(x => x.RemisePlv).IsRequired(false);
            builder.Property(x => x.VisiteDouble).IsRequired(false);
            builder.Property(x => x.UserId).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.CycleId).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Semaine).IsRequired(false);

            //Audit
            builder.Property(x => x.CreatedAt).IsRequired(true).HasColumnType("date");
            builder.Property(x => x.CreatedBy).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.ModifiedAt).IsRequired(false).HasColumnType("date");
            builder.Property(x => x.ModifiedBy).IsRequired(false).HasMaxLength(100);
        }
    }
}
