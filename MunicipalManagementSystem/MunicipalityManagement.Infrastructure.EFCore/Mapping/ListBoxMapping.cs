using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.ListBoxAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

class ListBoxMapping : IEntityTypeConfiguration<ListBox>
{
    public void Configure(EntityTypeBuilder<ListBox> builder)
    {
        builder.ToTable("tbllistbox");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(500);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Listboxs)
            .HasForeignKey(x => x.CategoryId);
    }
}
