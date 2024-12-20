﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MunicipalityManagement.Infrastructure.EFCore;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

[DbContext(typeof(MunicipalityContext))]
[Migration("20220807160940_intdatabasen")]
partial class intdatabasen
{
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("Relational:MaxIdentifierLength", 128)
            .HasAnnotation("ProductVersion", "5.0.3")
            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        modelBuilder.Entity("MunicipalityManagement.Domain.DarkhastAgg.Darkhast", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.HasKey("Id");

                b.ToTable("tbldarkhast");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListBoxAgg.ListBox", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<long>("CategoryId")
                    .HasColumnType("bigint");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.HasKey("Id");

                b.HasIndex("CategoryId");

                b.ToTable("tbllistbox");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListBoxCategoryAgg.ListBoxCategory", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.HasKey("Id");

                b.ToTable("tbllistboxcategory");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListKarbariAgg.ListKarbari", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<int>("Idkarbari")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.HasKey("Id");

                b.ToTable("tblkarbari");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListTabaghatAgg.ListTabaghat", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<int>("Idtabagheh")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.HasKey("Id");

                b.ToTable("tbltabaghat");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.MelkAgg.Melk", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Address")
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.Property<bool>("Baftfarsudeh")
                    .HasColumnType("bit");

                b.Property<bool>("Baftkohan")
                    .HasColumnType("bit");

                b.Property<int>("Cnblock")
                    .HasColumnType("int");

                b.Property<string>("Cnblockold")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Cnhozeh")
                    .HasColumnType("int");

                b.Property<string>("Cnhozehold")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Cnmantagheh")
                    .HasColumnType("int");

                b.Property<string>("Cnmantaghehold")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Cnmelk")
                    .HasColumnType("int");

                b.Property<string>("Cnmelkold")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<long>("Idhamjavari")
                    .HasColumnType("bigint");

                b.Property<long>("Idkarbaribaft")
                    .HasColumnType("bigint");

                b.Property<long>("Idkarbaripahnehbaft")
                    .HasColumnType("bigint");

                b.Property<long>("Idkarbaritarhejameh")
                    .HasColumnType("bigint");

                b.Property<long>("Idpahnehtarhejameh")
                    .HasColumnType("bigint");

                b.Property<long>("Idstatemelk")
                    .HasColumnType("bigint");

                b.Property<int>("Idtarakompayeh")
                    .HasColumnType("int");

                b.Property<long>("Idtarhehtafzili")
                    .HasColumnType("bigint");

                b.Property<long>("Idtypesanad")
                    .HasColumnType("bigint");

                b.Property<long>("Idzaribpahneh")
                    .HasColumnType("bigint");

                b.Property<decimal>("Masahateslahi")
                    .HasColumnType("decimal");

                b.Property<decimal>("Masahatsanad")
                    .HasColumnType("decimal");

                b.Property<string>("Pelakasli")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Pelakfarei1")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Pelakfarei2")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Tozihat")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("Idkarbaritarhejameh");

                b.HasIndex("Idtypesanad");

                b.ToTable("tblmelk");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.OrderAgg.Order", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<long>("AccountId")
                    .HasColumnType("bigint");

                b.Property<string>("Cnblock")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Cnhozeh")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Cnmantagheh")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Cnmelk")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsCanceled")
                    .HasColumnType("bit");

                b.Property<string>("IssueTrackingNo")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("RequestType")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("tblorder");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.SakhtemanAgg.Sakhteman", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<decimal>("Ertefah")
                    .HasColumnType("decimal(18,2)");

                b.Property<long>("Ideskelet")
                    .HasColumnType("bigint");

                b.Property<long>("Idestefadeh")
                    .HasColumnType("bigint");

                b.Property<long>("Idkarbari")
                    .HasColumnType("bigint");

                b.Property<long>("Idmarhalesakhtemani")
                    .HasColumnType("bigint");

                b.Property<long>("Idmelk")
                    .HasColumnType("bigint");

                b.Property<long>("Idnama")
                    .HasColumnType("bigint");

                b.Property<int>("Idsakhteman")
                    .HasColumnType("int");

                b.Property<long>("Idtabagheh")
                    .HasColumnType("bigint");

                b.Property<int>("Idvahed")
                    .HasColumnType("int");

                b.Property<long?>("ListBoxId")
                    .HasColumnType("bigint");

                b.Property<decimal>("Masahahttariz")
                    .HasColumnType("decimal(18,2)");

                b.Property<decimal>("Masahat")
                    .HasColumnType("decimal");

                b.Property<decimal>("Pishamadegi")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("Salsakht")
                    .HasColumnType("int");

                b.Property<int>("Tedadvahed")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("Idkarbari");

                b.HasIndex("Idmelk");

                b.HasIndex("Idtabagheh");

                b.HasIndex("ListBoxId");

                b.ToTable("tblsakhteman");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.SlideAgg.Slide", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("BtnText")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Heading")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar(255)");

                b.Property<bool>("IsRemoved")
                    .HasColumnType("bit");

                b.Property<string>("Link")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Picture")
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnType("nvarchar(1000)");

                b.Property<string>("PictureAlt")
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.Property<string>("PictureTitle")
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.Property<string>("Text")
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar(255)");

                b.Property<string>("Title")
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar(255)");

                b.HasKey("Id");

                b.ToTable("Slides");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListBoxAgg.ListBox", b =>
            {
                b.HasOne("MunicipalityManagement.Domain.ListBoxCategoryAgg.ListBoxCategory", "Category")
                    .WithMany("Listboxs")
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Category");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.MelkAgg.Melk", b =>
            {
                b.HasOne("MunicipalityManagement.Domain.ListBoxAgg.ListBox", "ListBoxkarbaritarhejameh")
                    .WithMany("tarhjameh")
                    .HasForeignKey("Idkarbaritarhejameh")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("MunicipalityManagement.Domain.ListBoxAgg.ListBox", "ListBoxtypesanad")
                    .WithMany("melks")
                    .HasForeignKey("Idtypesanad")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("ListBoxkarbaritarhejameh");

                b.Navigation("ListBoxtypesanad");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.SakhtemanAgg.Sakhteman", b =>
            {
                b.HasOne("MunicipalityManagement.Domain.ListKarbariAgg.ListKarbari", "Karbari")
                    .WithMany("sakhtemans")
                    .HasForeignKey("Idkarbari")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("MunicipalityManagement.Domain.MelkAgg.Melk", "Melk")
                    .WithMany("Sakhtemans")
                    .HasForeignKey("Idmelk")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("MunicipalityManagement.Domain.ListTabaghatAgg.ListTabaghat", "Tabagaht")
                    .WithMany("sakhtemans")
                    .HasForeignKey("Idtabagheh")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("MunicipalityManagement.Domain.ListBoxAgg.ListBox", null)
                    .WithMany("sakhtemans")
                    .HasForeignKey("ListBoxId");

                b.Navigation("Karbari");

                b.Navigation("Melk");

                b.Navigation("Tabagaht");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListBoxAgg.ListBox", b =>
            {
                b.Navigation("melks");

                b.Navigation("sakhtemans");

                b.Navigation("tarhjameh");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListBoxCategoryAgg.ListBoxCategory", b =>
            {
                b.Navigation("Listboxs");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListKarbariAgg.ListKarbari", b =>
            {
                b.Navigation("sakhtemans");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.ListTabaghatAgg.ListTabaghat", b =>
            {
                b.Navigation("sakhtemans");
            });

        modelBuilder.Entity("MunicipalityManagement.Domain.MelkAgg.Melk", b =>
            {
                b.Navigation("Sakhtemans");
            });
#pragma warning restore 612, 618
    }
}
