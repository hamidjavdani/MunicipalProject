using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.RequestAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

public class RequestMapping : IEntityTypeConfiguration<Request>
{
    public void Configure(EntityTypeBuilder<Request> builder)
    {
        builder.ToTable("tblrequest");
        builder.HasKey(x => x.Id);


        builder.HasOne(x => x.TitleRequests)
            .WithMany(x => x.Requests)
            .HasForeignKey(x => x.RequestType);

    }
}
