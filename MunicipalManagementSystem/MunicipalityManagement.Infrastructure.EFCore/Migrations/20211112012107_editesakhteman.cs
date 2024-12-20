using Microsoft.EntityFrameworkCore.Migrations;

namespace MunicipalityManagement.Infrastructure.EFCore.Migrations;

public partial class editesakhteman : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_tblsakhteman_tblmelk_IdMelk",
            table: "tblsakhteman");

        migrationBuilder.RenameColumn(
            name: "IdMelk",
            table: "tblsakhteman",
            newName: "Idmelk");

        migrationBuilder.RenameIndex(
            name: "IX_tblsakhteman_IdMelk",
            table: "tblsakhteman",
            newName: "IX_tblsakhteman_Idmelk");

        migrationBuilder.AddColumn<decimal>(
            name: "Ertefah",
            table: "tblsakhteman",
            type: "decimal(18,2)",
            nullable: false,
            defaultValue: 0m);

        migrationBuilder.AddColumn<decimal>(
            name: "Masahahttariz",
            table: "tblsakhteman",
            type: "decimal(18,2)",
            nullable: false,
            defaultValue: 0m);

        migrationBuilder.AddColumn<decimal>(
            name: "Pishamadegi",
            table: "tblsakhteman",
            type: "decimal(18,2)",
            nullable: false,
            defaultValue: 0m);

        migrationBuilder.AlterColumn<long>(
            name: "Idzaribpahneh",
            table: "tblmelk",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idtarhehtafzili",
            table: "tblmelk",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idstatemelk",
            table: "tblmelk",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idpahnehtarhejameh",
            table: "tblmelk",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idkarbaripahnehbaft",
            table: "tblmelk",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idkarbaribaft",
            table: "tblmelk",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AlterColumn<long>(
            name: "Idhamjavari",
            table: "tblmelk",
            type: "bigint",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");

        migrationBuilder.AddForeignKey(
            name: "FK_tblsakhteman_tblmelk_Idmelk",
            table: "tblsakhteman",
            column: "Idmelk",
            principalTable: "tblmelk",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_tblsakhteman_tblmelk_Idmelk",
            table: "tblsakhteman");

        migrationBuilder.DropColumn(
            name: "Ertefah",
            table: "tblsakhteman");

        migrationBuilder.DropColumn(
            name: "Masahahttariz",
            table: "tblsakhteman");

        migrationBuilder.DropColumn(
            name: "Pishamadegi",
            table: "tblsakhteman");

        migrationBuilder.RenameColumn(
            name: "Idmelk",
            table: "tblsakhteman",
            newName: "IdMelk");

        migrationBuilder.RenameIndex(
            name: "IX_tblsakhteman_Idmelk",
            table: "tblsakhteman",
            newName: "IX_tblsakhteman_IdMelk");

        migrationBuilder.AlterColumn<int>(
            name: "Idzaribpahneh",
            table: "tblmelk",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idtarhehtafzili",
            table: "tblmelk",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idstatemelk",
            table: "tblmelk",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idpahnehtarhejameh",
            table: "tblmelk",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idkarbaripahnehbaft",
            table: "tblmelk",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idkarbaribaft",
            table: "tblmelk",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AlterColumn<int>(
            name: "Idhamjavari",
            table: "tblmelk",
            type: "int",
            nullable: false,
            oldClrType: typeof(long),
            oldType: "bigint");

        migrationBuilder.AddForeignKey(
            name: "FK_tblsakhteman_tblmelk_IdMelk",
            table: "tblsakhteman",
            column: "IdMelk",
            principalTable: "tblmelk",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }
}
