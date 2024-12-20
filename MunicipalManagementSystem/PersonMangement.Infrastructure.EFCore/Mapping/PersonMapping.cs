using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonManagement.Domain.PersonAgg;
namespace PersonMangement.Infrastructure.EFCore.Mapping;

public class PersonMapping : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("tblperson");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName).HasMaxLength(200).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(200).IsRequired();
        builder.Property(x => x.MelliCode).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Shenasnameh).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Parent).HasMaxLength(200).IsRequired();

        // --builder.HasOne(x => x.Role).WithMany(x => x.Accounts).HasForeignKey(x => x.RoleId);
    }
}
