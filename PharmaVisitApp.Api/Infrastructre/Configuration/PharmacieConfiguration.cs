using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaVisitApp.Api.Domain.Entities;

namespace PharmaVisitApp.Api.Infrastructre.Configuration
{
    public class PharmacieConfiguration : IEntityTypeConfiguration<Pharmacie>
    {
        public void Configure(EntityTypeBuilder<Pharmacie> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.NomPharmacie).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.NomPharmacien).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.PrenomPharmacien).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.GeoId).IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.Tel).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.Adresse).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.Potentiel).IsRequired(false);

            //Audit
            builder.Property(x => x.CreatedAt).IsRequired(true).HasColumnType("date");
            builder.Property(x => x.CreatedBy).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.ModifiedAt).IsRequired(false).HasColumnType("date");
            builder.Property(x => x.ModifiedBy).IsRequired(false).HasMaxLength(100);
        }
    }
}
