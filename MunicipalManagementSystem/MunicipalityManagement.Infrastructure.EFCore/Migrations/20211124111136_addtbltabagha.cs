using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

public partial class addtbltabagha : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<long>(
            name: "Idtabagheh",
            table: "tblsakhteman",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AddColumn<long>(
            name: "ListBoxtabaghatId",
            table: "tblsakhteman",
            type: "bigint",
            nullable: true);

        migrationBuilder.CreateTable(
            name: "tbltabaghat",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                Idtabagheh = table.Column<int>(type: "int", nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tbltabaghat", x => x.Id);
            });

        migrationBuilder.CreateIndex(
            name: "IX_tblsakhteman_Idtabagheh",
            table: "tblsakhteman",
            column: "Idtabagheh");

        migrationBuilder.CreateIndex(
            name: "IX_tblsakhteman_ListBoxtabaghatId",
            table: "tblsakhteman",
            column: "ListBoxtabaghatId");

        migrationBuilder.AddForeignKey(
            name: "FK_tblsakhteman_tbllistbox_ListBoxtabaghatId",
            table: "tblsakhteman",
            column: "ListBoxtabaghatId",
            principalTable: "tbllistbox",
            principalColumn: "Id",
            onDelete: ReferentialAction.Restrict);

        migrationBuilder.AddForeignKey(
            name: "FK_tblsakhteman_tbltabaghat_Idtabagheh",
            table: "tblsakhteman",
            column: "Idtabagheh",
            principalTable: "tbltabaghat",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_tblsakhteman_tbllistbox_ListBoxtabaghatId",
            table: "tblsakhteman");

        migrationBuilder.DropForeignKey(
            name: "FK_tblsakhteman_tbltabaghat_Idtabagheh",
            table: "tblsakhteman");

        migrationBuilder.DropTable(
            name: "tbltabaghat");

        migrationBuilder.DropIndex(
            name: "IX_tblsakhteman_Idtabagheh",
            table: "tblsakhteman");

        migrationBuilder.DropIndex(
            name: "IX_tblsakhteman_ListBoxtabaghatId",
            table: "tblsakhteman");

        migrationBuilder.DropColumn(
            name: "ListBoxtabaghatId",
            table: "tblsakhteman");

        migrationBuilder.AlterColumn<int>(
            name: "Idtabagheh",
            table: "tblsakhteman",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");
    }
}
