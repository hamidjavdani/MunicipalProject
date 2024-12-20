using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.Title_RequestAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

public class TitleRequestMapping : IEntityTypeConfiguration<TitleRequest>
{
    public void Configure(EntityTypeBuilder<TitleRequest> builder)
    {
        builder.ToTable("tbltitlerequest");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(500);


    }
}