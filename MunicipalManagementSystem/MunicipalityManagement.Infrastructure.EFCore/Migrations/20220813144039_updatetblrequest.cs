using Microsoft.EntityFrameworkCore.Migrations;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

public partial class updatetblrequest : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "Cnblock",
            table: "tblrequest",
            type: "nvarchar(max)",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "Cnhozeh",
            table: "tblrequest",
            type: "nvarchar(max)",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "Cnmantagheh",
            table: "tblrequest",
            type: "nvarchar(max)",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "Cnmelk",
            table: "tblrequest",
            type: "nvarchar(max)",
            nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Cnblock",
            table: "tblrequest");

        migrationBuilder.DropColumn(
            name: "Cnhozeh",
            table: "tblrequest");

        migrationBuilder.DropColumn(
            name: "Cnmantagheh",
            table: "tblrequest");

        migrationBuilder.DropColumn(
            name: "Cnmelk",
            table: "tblrequest");
    }
}
