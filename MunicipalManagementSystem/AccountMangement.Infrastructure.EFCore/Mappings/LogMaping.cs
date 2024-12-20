using AccountManagement.Domain.LogAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountMangement.Infrastructure.EFCore.Mappings;

public class LogMaping : IEntityTypeConfiguration<Log>
{
    public void Configure(EntityTypeBuilder<Log> builder)
    {
        builder.ToTable("tbllogs");

        builder.HasKey(x => x.Id);

        //builder.Property(x => x.AccountId).HasColumnType<long>("bigint");

        //builder.Property(x => x.PermissionId).HasColumnType<long>("bigint");

        builder.HasOne(x => x.TitelPermission)
          .WithMany(x => x.Log).HasForeignKey(x => x.PermissionId);

        builder.HasOne(x => x.Account)
     .WithMany(x => x.Log).HasForeignKey(x => x.AccountId);


    }


}
