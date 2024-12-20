using AccountManagement.Domain.PermissionAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountMangement.Infrastructure.EFCore.Mappings;
public class TitelPermissionMpping : IEntityTypeConfiguration<TitelPermission>
{
    public void Configure(EntityTypeBuilder<TitelPermission> builder)
    {
        builder.ToTable("tbltitelpermission");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();


    }
}