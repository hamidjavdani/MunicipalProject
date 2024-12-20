using Microsoft.EntityFrameworkCore.Migrations;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

public partial class init2relation : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<long>(
            name: "RequestType",
            table: "tblrequest",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.CreateIndex(
            name: "IX_tblrequest_RequestType",
            table: "tblrequest",
            column: "RequestType");

        migrationBuilder.AddForeignKey(
            name: "FK_tblrequest_tbltitlerequest_RequestType",
            table: "tblrequest",
            column: "RequestType",
            principalTable: "tbltitlerequest",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_tblrequest_tbltitlerequest_RequestType",
            table: "tblrequest");

        migrationBuilder.DropIndex(
            name: "IX_tblrequest_RequestType",
            table: "tblrequest");

        migrationBuilder.AlterColumn<int>(
            name: "RequestType",
            table: "tblrequest",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");
    }
}
