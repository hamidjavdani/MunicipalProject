﻿// <auto-generated />
using System;
using AccountMangement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountMangement.Infrastructure.EFCore.Migrations;

[DbContext(typeof(AccountContext))]
[Migration("20220915135532_initaccount")]
partial class initaccount
{
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("Relational:MaxIdentifierLength", 128)
            .HasAnnotation("ProductVersion", "5.0.3")
            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        modelBuilder.Entity("AccountManagement.Domain.AccountAgg.Account", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Fullname")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("LastName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Mobile")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnType("nvarchar(1000)");

                b.Property<string>("ProfilePhoto")
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.Property<long>("RoleId")
                    .HasColumnType("bigint");

                b.Property<string>("Username")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("tblaccounts");
            });

        modelBuilder.Entity("AccountManagement.Domain.AccountJobAgg.AccountJob", b =>
            {
                b.Property<long>("AccountId")
                    .HasColumnType("bigint");

                b.Property<long>("JobId")
                    .HasColumnType("bigint");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("EndJobName")
                    .HasColumnType("datetime2");

                b.Property<long>("Id")
                    .HasColumnType("bigint");

                b.Property<bool>("IsHaveJob")
                    .HasColumnType("bit");

                b.Property<DateTime>("StartJobName")
                    .HasColumnType("datetime2");

                b.HasKey("AccountId", "JobId");

                b.HasIndex("JobId");

                b.ToTable("tblaccountjob");
            });

        modelBuilder.Entity("AccountManagement.Domain.JobsChartAgg.JobsChart", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsRemoved")
                    .HasColumnType("bit");

                b.Property<string>("JobsChartDescription")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("JobsChartLevel")
                    .HasColumnType("int");

                b.Property<string>("JobsChartName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("tbljobschart");
            });

        modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.HasKey("Id");

                b.ToTable("tblroles");
            });

        modelBuilder.Entity("AccountManagement.Domain.AccountAgg.Account", b =>
            {
                b.HasOne("AccountManagement.Domain.RoleAgg.Role", "Role")
                    .WithMany("Accounts")
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Role");
            });

        modelBuilder.Entity("AccountManagement.Domain.AccountJobAgg.AccountJob", b =>
            {
                b.HasOne("AccountManagement.Domain.AccountAgg.Account", "Account")
                    .WithMany("AccountJob")
                    .HasForeignKey("AccountId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("AccountManagement.Domain.JobsChartAgg.JobsChart", "Job")
                    .WithMany("AccountJob")
                    .HasForeignKey("JobId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Account");

                b.Navigation("Job");
            });

        modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
            {
                b.OwnsMany("AccountManagement.Domain.RoleAgg.Permission", "Permissions", b1 =>
                    {
                        b1.Property<long>("Id")
                            .ValueGeneratedOnAdd()
                            .HasColumnType("bigint")
                            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                        b1.Property<int>("Code")
                            .HasColumnType("int");

                        b1.Property<long>("RoleId")
                            .HasColumnType("bigint");

                        b1.HasKey("Id");

                        b1.HasIndex("RoleId");

                        b1.ToTable("tblrolepermissions");

                        b1.WithOwner("Role")
                            .HasForeignKey("RoleId");

                        b1.Navigation("Role");
                    });

                b.Navigation("Permissions");
            });

        modelBuilder.Entity("AccountManagement.Domain.AccountAgg.Account", b =>
            {
                b.Navigation("AccountJob");
            });

        modelBuilder.Entity("AccountManagement.Domain.JobsChartAgg.JobsChart", b =>
            {
                b.Navigation("AccountJob");
            });

        modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
            {
                b.Navigation("Accounts");
            });
#pragma warning restore 612, 618
    }
}
