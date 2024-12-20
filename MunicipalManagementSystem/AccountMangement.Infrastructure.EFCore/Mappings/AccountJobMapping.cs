using AccountManagement.Domain.AccountJobAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AccountMangement.Infrastructure.EFCore.Mappings;

public class AccountJobMapping : IEntityTypeConfiguration<AccountJob>
{
    public void Configure(EntityTypeBuilder<AccountJob> builder)
    {
        builder.ToTable("tblaccountjob");
        builder.HasKey(x => new { x.AccountId, x.JobId });


        builder.HasOne(x => x.Job)
            .WithMany(x => x.AccountJob).HasForeignKey(x => x.JobId);

        builder.HasOne(x => x.Account)
           .WithMany(x => x.AccountJob).HasForeignKey(x => x.AccountId);



        //builder.HasOne(x => x.Account)
        //  .WithMany(x => x.AccountJob)
        //  .HasForeignKey(x => x.JobId);

    }
}
