using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

public partial class addtblkarbari : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_tblsakhteman_tbllistbox_ListBoxtabaghatId",
            table: "tblsakhteman");

        migrationBuilder.RenameColumn(
            name: "ListBoxtabaghatId",
            table: "tblsakhteman",
            newName: "ListBoxId");

        migrationBuilder.RenameIndex(
            name: "IX_tblsakhteman_ListBoxtabaghatId",
            table: "tblsakhteman",
            newName: "IX_tblsakhteman_ListBoxId");

        migrationBuilder.AlterColumn<long>(
            name: "Idnama",
            table: "tblsakhteman",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idmarhalesakhtemani",
            table: "tblsakhteman",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idkarbari",
            table: "tblsakhteman",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idestefadeh",
            table: "tblsakhteman",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Ideskelet",
            table: "tblsakhteman",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.CreateTable(
            name: "tblkarbari",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                Idkarbari = table.Column<int>(type: "int", nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblkarbari", x => x.Id);
            });

        migrationBuilder.CreateIndex(
            name: "IX_tblsakhteman_Idkarbari",
            table: "tblsakhteman",
            column: "Idkarbari");

        migrationBuilder.AddForeignKey(
            name: "FK_tblsakhteman_tblkarbari_Idkarbari",
            table: "tblsakhteman",
            column: "Idkarbari",
            principalTable: "tblkarbari",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_tblsakhteman_tbllistbox_ListBoxId",
            table: "tblsakhteman",
            column: "ListBoxId",
            principalTable: "tbllistbox",
            principalColumn: "Id",
            onDelete: ReferentialAction.Restrict);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_tblsakhteman_tblkarbari_Idkarbari",
            table: "tblsakhteman");

        migrationBuilder.DropForeignKey(
            name: "FK_tblsakhteman_tbllistbox_ListBoxId",
            table: "tblsakhteman");

        migrationBuilder.DropTable(
            name: "tblkarbari");

        migrationBuilder.DropIndex(
            name: "IX_tblsakhteman_Idkarbari",
            table: "tblsakhteman");

        migrationBuilder.RenameColumn(
            name: "ListBoxId",
            table: "tblsakhteman",
            newName: "ListBoxtabaghatId");

        migrationBuilder.RenameIndex(
            name: "IX_tblsakhteman_ListBoxId",
            table: "tblsakhteman",
            newName: "IX_tblsakhteman_ListBoxtabaghatId");

        migrationBuilder.AlterColumn<int>(
            name: "Idnama",
            table: "tblsakhteman",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idmarhalesakhtemani",
            table: "tblsakhteman",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idkarbari",
            table: "tblsakhteman",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idestefadeh",
            table: "tblsakhteman",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Ideskelet",
            table: "tblsakhteman",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AddForeignKey(
            name: "FK_tblsakhteman_tbllistbox_ListBoxtabaghatId",
            table: "tblsakhteman",
            column: "ListBoxtabaghatId",
            principalTable: "tbllistbox",
            principalColumn: "Id",
            onDelete: ReferentialAction.Restrict);
    }
}
