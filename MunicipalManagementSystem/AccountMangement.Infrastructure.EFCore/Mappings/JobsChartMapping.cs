using AccountManagement.Domain.JobsChartAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountMangement.Infrastructure.EFCore.Mappings;

public class JobsChartMapping : IEntityTypeConfiguration<JobsChart>
{
    public void Configure(EntityTypeBuilder<JobsChart> builder)
    {
        builder.ToTable("tbljobschart");
        builder.HasKey(x => x.Id);


        //builder.HasOne(x => x.)
        //    .WithMany(x => x.Requests)
        //    .HasForeignKey(x => x.RequestType);

    }
}
