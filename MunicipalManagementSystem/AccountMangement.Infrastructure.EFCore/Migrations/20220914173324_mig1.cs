using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AccountMangement.Infrastructure.EFCore.Migrations;

public partial class mig1 : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "tbljobschart",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                JobsChartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                JobsChartDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                JobsChartLevel = table.Column<int>(type: "int", nullable: false),
                IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tbljobschart", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "tblaccountjob",
            columns: table => new
            {
                AccountId = table.Column<long>(type: "bigint", nullable: false),
                JobId = table.Column<long>(type: "bigint", nullable: false),
                StartJobName = table.Column<DateTime>(type: "datetime2", nullable: false),
                EndJobName = table.Column<DateTime>(type: "datetime2", nullable: false),
                IsHaveJob = table.Column<bool>(type: "bit", nullable: false),
                Id = table.Column<long>(type: "bigint", nullable: false),
                CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_tblaccountjob", x => new { x.AccountId, x.JobId });
                table.ForeignKey(
                    name: "FK_tblaccountjob_tblaccounts_AccountId",
                    column: x => x.AccountId,
                    principalTable: "tblaccounts",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_tblaccountjob_tbljobschart_JobId",
                    column: x => x.JobId,
                    principalTable: "tbljobschart",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_tblaccountjob_JobId",
            table: "tblaccountjob",
            column: "JobId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "tblaccountjob");

        migrationBuilder.DropTable(
            name: "tbljobschart");
    }
}
