using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

public partial class intitblrequest : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "tblrequest",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                AccountId = table.Column<long>(type: "bigint", nullable: false),
                RequestType = table.Column<int>(type: "int", nullable: false),
                Codemelk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                IssueTrackingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblrequest", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "tblrequest");
    }
}
