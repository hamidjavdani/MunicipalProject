using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

public partial class addeddata : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {


        migrationBuilder.CreateTable(
            name: "tbllistboxcategory",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tbllistboxcategory", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "tbllistbox",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                CategoryId = table.Column<long>(type: "bigint", nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tbllistbox", x => x.Id);
                table.ForeignKey(
                    name: "FK_tbllistbox_tbllistboxcategory_CategoryId",
                    column: x => x.CategoryId,
                    principalTable: "tbllistboxcategory",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tblmelk",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Cnmantagheh = table.Column<int>(type: "int", nullable: false),
                Cnhozeh = table.Column<int>(type: "int", nullable: false),
                Cnblock = table.Column<int>(type: "int", nullable: false),
                Cnmelk = table.Column<int>(type: "int", nullable: false),
                Cnmantaghehold = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Cnhozehold = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Cnblockold = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Cnmelkold = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Masahatsanad = table.Column<decimal>(type: "decimal", nullable: false),
                Masahateslahi = table.Column<decimal>(type: "decimal", nullable: false),
                Idtypesanad = table.Column<long>(type: "bigint", nullable: false),
                Idtarakompayeh = table.Column<int>(type: "int", nullable: false),
                Idkarbaritarhejameh = table.Column<int>(type: "int", nullable: false),
                Idstatemelk = table.Column<int>(type: "int", nullable: false),
                Idpahnehtarhejameh = table.Column<int>(type: "int", nullable: false),
                Idhamjavari = table.Column<int>(type: "int", nullable: false),
                Idzaribpahneh = table.Column<int>(type: "int", nullable: false),
                Idkarbaribaft = table.Column<int>(type: "int", nullable: false),
                Idkarbaripahnehbaft = table.Column<int>(type: "int", nullable: false),
                Idtarhehtafzili = table.Column<int>(type: "int", nullable: false),
                Baftfarsudeh = table.Column<bool>(type: "bit", nullable: false),
                Baftkohan = table.Column<bool>(type: "bit", nullable: false),
                Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                Pelakasli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Pelakfarei1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Pelakfarei2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Tozihat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblmelk", x => x.Id);
                table.ForeignKey(
                    name: "FK_tblmelk_tbllistbox_Idtypesanad",
                    column: x => x.Idtypesanad,
                    principalTable: "tbllistbox",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tblsakhteman",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Idsakhteman = table.Column<int>(type: "int", nullable: false),
                Idnama = table.Column<int>(type: "int", nullable: false),
                Idtabagheh = table.Column<int>(type: "int", nullable: false),
                Idkarbari = table.Column<int>(type: "int", nullable: false),
                Idestefadeh = table.Column<int>(type: "int", nullable: false),
                Ideskelet = table.Column<int>(type: "int", nullable: false),
                Idmarhalesakhtemani = table.Column<int>(type: "int", nullable: false),
                Idvahed = table.Column<int>(type: "int", nullable: false),
                Salsakht = table.Column<int>(type: "int", nullable: false),
                Tedadvahed = table.Column<int>(type: "int", nullable: false),
                Masahat = table.Column<decimal>(type: "decimal", nullable: false),
                IdMelk = table.Column<long>(type: "bigint", nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblsakhteman", x => x.Id);
                table.ForeignKey(
                    name: "FK_tblsakhteman_tblmelk_IdMelk",
                    column: x => x.IdMelk,
                    principalTable: "tblmelk",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_tbllistbox_CategoryId",
            table: "tbllistbox",
            column: "CategoryId");

        migrationBuilder.CreateIndex(
            name: "IX_tblmelk_Idtypesanad",
            table: "tblmelk",
            column: "Idtypesanad");

        migrationBuilder.CreateIndex(
            name: "IX_tblsakhteman_IdMelk",
            table: "tblsakhteman",
            column: "IdMelk");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {


        migrationBuilder.DropTable(
            name: "tblsakhteman");

        migrationBuilder.DropTable(
            name: "tblmelk");

        migrationBuilder.DropTable(
            name: "tbllistbox");

        migrationBuilder.DropTable(
            name: "tbllistboxcategory");
    }
}
