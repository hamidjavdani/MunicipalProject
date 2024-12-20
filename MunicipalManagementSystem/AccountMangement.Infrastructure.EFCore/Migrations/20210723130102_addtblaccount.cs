using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AccountMangement.Infrastructure.EFCore.Migrations;

public partial class addtblaccount : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "tblroles",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblroles", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "tblaccounts",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Fullname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Password = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                RoleId = table.Column<long>(type: "bigint", nullable: false),
                ProfilePhoto = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblaccounts", x => x.Id);
                table.ForeignKey(
                    name: "FK_tblaccounts_tblroles_RoleId",
                    column: x => x.RoleId,
                    principalTable: "tblroles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tblrolepermissions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Code = table.Column<int>(type: "int", nullable: false),
                RoleId = table.Column<long>(type: "bigint", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblrolepermissions", x => x.Id);
                table.ForeignKey(
                    name: "FK_tblrolepermissions_tblroles_RoleId",
                    column: x => x.RoleId,
                    principalTable: "tblroles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_tblaccounts_RoleId",
            table: "tblaccounts",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "IX_tblrolepermissions_RoleId",
            table: "tblrolepermissions",
            column: "RoleId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "tblaccounts");

        migrationBuilder.DropTable(
            name: "tblrolepermissions");

        migrationBuilder.DropTable(
            name: "tblroles");
    }
}
