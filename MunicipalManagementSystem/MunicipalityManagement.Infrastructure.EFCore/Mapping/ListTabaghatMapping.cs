using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.ListTabaghatAgg;
namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

public class ListTabaghatMapping : IEntityTypeConfiguration<ListTabaghat>
{
    public void Configure(EntityTypeBuilder<ListTabaghat> builder)
    {
        builder.ToTable("tbltabaghat");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(500);

        builder.HasMany(x => x.sakhtemans)
           .WithOne(x => x.Tabagaht)
           .HasForeignKey(x => x.Idtabagheh);
    }
}