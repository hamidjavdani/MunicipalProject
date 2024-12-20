using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.OrderAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

class OrderMapping : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("tblorder");
        builder.HasKey(x => x.Id);


    }
}
