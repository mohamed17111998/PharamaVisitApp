using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaVisitApp.Api.Domain.Entities;

namespace PharmaVisitApp.Api.Infrastructre.Configuration
{
    public class CycleConfiguration : IEntityTypeConfiguration<Cycle>
    {
        public void Configure(EntityTypeBuilder<Cycle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Nom).IsRequired(true).HasMaxLength(255);
            builder.Property(x => x.DateDebut).IsRequired(true).HasColumnType("date");
            builder.Property(x => x.DateFin).IsRequired(true).HasColumnType("date");
            builder.Property(x => x.NbrSemaine).IsRequired(false);

            //Audit
            builder.Property(x => x.CreatedAt).IsRequired(true).HasColumnType("date");
            builder.Property(x => x.CreatedBy).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.ModifiedAt).IsRequired(false).HasColumnType("date");
            builder.Property(x => x.ModifiedBy).IsRequired(false).HasMaxLength(100);
        }
    }
}
