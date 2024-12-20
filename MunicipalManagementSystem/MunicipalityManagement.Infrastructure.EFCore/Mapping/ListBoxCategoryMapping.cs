using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.ListBoxCategoryAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

public class ListBoxCategoryMapping : IEntityTypeConfiguration<ListBoxCategory>
{
    public void Configure(EntityTypeBuilder<ListBoxCategory> builder)
    {
        builder.ToTable("tbllistboxcategory");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(500);

        builder.HasMany(x => x.Listboxs)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId);

    }
}
