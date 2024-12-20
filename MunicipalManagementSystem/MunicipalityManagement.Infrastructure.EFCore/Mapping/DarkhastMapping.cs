using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.DarkhastAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

class DarkhastMapping : IEntityTypeConfiguration<Darkhast>
{
    public void Configure(EntityTypeBuilder<Darkhast> builder)
    {
        builder.ToTable("tbldarkhast");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(500);


    }
}
