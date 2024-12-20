using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

public partial class intdatabasen : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "tblorder",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                AccountId = table.Column<long>(type: "bigint", nullable: false),
                RequestType = table.Column<int>(type: "int", nullable: false),
                Cnmantagheh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Cnhozeh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Cnblock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Cnmelk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                IsCanceled = table.Column<bool>(type: "bit", nullable: false),
                IssueTrackingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblorder", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "tblorder");
    }
}
