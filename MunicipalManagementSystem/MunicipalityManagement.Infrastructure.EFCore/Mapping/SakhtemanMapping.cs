using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.SakhtemanAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

public class SakhtemanMapping : IEntityTypeConfiguration<Sakhteman>
{
    public void Configure(EntityTypeBuilder<Sakhteman> builder)
    {
        builder.ToTable("tblsakhteman");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Masahat).HasColumnType<decimal>("decimal");
        //builder.Property(x => x.Ideskelet).HasColumnType<int>("int");
        // builder.Property(x => x.Idestefadeh).HasColumnType<int>("int");
        // builder.Property(x => x.Idkarbari).HasColumnType<int>("int");
        //  builder.Property(x => x.Idmarhalesakhtemani).HasColumnType<int>("int");
        builder.Property(x => x.Idmelk).HasColumnType<long>("bigint");

        builder.HasOne(x => x.Melk)
            .WithMany(x => x.Sakhtemans)
            .HasForeignKey(x => x.Idmelk);

        builder.HasOne(x => x.Tabagaht)
        .WithMany(x => x.sakhtemans)
        .HasForeignKey(x => x.Idtabagheh);


    }
}
