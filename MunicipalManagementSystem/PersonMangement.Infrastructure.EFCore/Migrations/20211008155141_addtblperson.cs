using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PersonMangement.Infrastructure.EFCore.Migrations;

public partial class addtblperson : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "tblperson",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                MelliCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Shenasnameh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Parent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                BirthDayDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Gender = table.Column<byte>(type: "tinyint", nullable: false),
                ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                SignaturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                IaActive = table.Column<byte>(type: "tinyint", nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblperson", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "tblperson");
    }
}
