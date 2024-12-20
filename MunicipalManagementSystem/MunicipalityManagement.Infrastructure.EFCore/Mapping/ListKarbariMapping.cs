using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.ListKarbariAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

public class ListKarbariMapping : IEntityTypeConfiguration<ListKarbari>
{
    public void Configure(EntityTypeBuilder<ListKarbari> builder)
    {
        builder.ToTable("tblkarbari");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(500);

        builder.HasMany(x => x.sakhtemans)
           .WithOne(x => x.Karbari)
           .HasForeignKey(x => x.Idkarbari);
    }
}