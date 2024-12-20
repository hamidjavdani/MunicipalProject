using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MunicipalityManagement.Domain.MelkAgg;

namespace MunicipalityManagement.Infrastructure.EFCore.Mapping;

public class MelkMapping : IEntityTypeConfiguration<Melk>
{
    public void Configure(EntityTypeBuilder<Melk> builder)
    {
        builder.ToTable("tblmelk");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Address).HasMaxLength(500);
        builder.Property(x => x.Masahatsanad).HasColumnType<decimal>("decimal");
        builder.Property(x => x.Masahateslahi).HasColumnType<decimal>("decimal");

        builder.HasMany(x => x.Sakhtemans)
         .WithOne(x => x.Melk)
         .HasForeignKey(x => x.Idmelk);

        builder.HasOne(x => x.ListBoxtypesanad)
        .WithMany(x => x.melks)
        .HasForeignKey(x => x.Idtypesanad);

        builder.HasOne(x => x.ListBoxkarbaritarhejameh)
        .WithMany(x => x.tarhjameh)
        .HasForeignKey(x => x.Idkarbaritarhejameh);

        // builder.HasOne(x => x.ListBoxstatemelk)
        // .WithMany(x => x.melks)
        // .HasForeignKey(x => x.Idstatemelk);


        // builder.HasOne(x => x.ListBoxpahnehtarhejameh)
        // .WithMany(x => x.melks)
        // .HasForeignKey(x => x.Idkarbaritarhejameh);

        // builder.HasOne(x => x.ListBoxhamjavari)
        //.WithMany(x => x.melks)
        //.HasForeignKey(x => x.Idhamjavari);

        // builder.HasOne(x => x.ListBoxzaribpahneh)
        //.WithMany(x => x.melks)
        //.HasForeignKey(x => x.Idzaribpahneh);

        // builder.HasOne(x => x.ListBoxkarbaribaft)
        // .WithMany(x => x.melks)
        // .HasForeignKey(x => x.Idkarbaribaft);

        // builder.HasOne(x => x.ListBoxkarbaripahnehbaft)
        // .WithMany(x => x.melks)
        // .HasForeignKey(x => x.Idkarbaripahnehbaft);

        // builder.HasOne(x => x.ListBoxtarhehtafzili)
        // .WithMany(x => x.melks)
        //  .HasForeignKey(x => x.Idtarhehtafzili);



    }
}
