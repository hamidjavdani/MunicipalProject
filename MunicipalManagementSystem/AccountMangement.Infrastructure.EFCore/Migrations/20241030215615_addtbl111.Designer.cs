﻿// <auto-generated />
using System;
using AccountMangement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(AccountContext))]
    [Migration("20241030215615_addtbl111")]
    partial class addtbl111
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccountManagement.Domain.AccountAgg.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

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

                    b.ToTable("tblaccounts", (string)null);
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

                    b.ToTable("tblaccountjob", (string)null);
                });

            modelBuilder.Entity("AccountManagement.Domain.JobsChartAgg.JobsChart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

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

                    b.ToTable("tbljobschart", (string)null);
                });

            modelBuilder.Entity("AccountManagement.Domain.LogAgg.Log", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.ToTable("tbllogs", (string)null);
                });

            modelBuilder.Entity("AccountManagement.Domain.PermissionAgg.TitelPermission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("tbltitelpermission", (string)null);
                });

            modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("tblroles", (string)null);
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

            modelBuilder.Entity("AccountManagement.Domain.LogAgg.Log", b =>
                {
                    b.HasOne("AccountManagement.Domain.PermissionAgg.TitelPermission", "TitelPermission")
                        .WithMany("Logs")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TitelPermission");
                });

            modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
                {
                    b.OwnsMany("AccountManagement.Domain.RoleAgg.Permission", "Permissions", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<long>("Id"));

                            b1.Property<int>("Code")
                                .HasColumnType("int");

                            b1.Property<long>("RoleId")
                                .HasColumnType("bigint");

                            b1.HasKey("Id");

                            b1.HasIndex("RoleId");

                            b1.ToTable("tblrolepermissions", (string)null);

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

            modelBuilder.Entity("AccountManagement.Domain.PermissionAgg.TitelPermission", b =>
                {
                    b.Navigation("Logs");
                });

            modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
