using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class updatetbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbllogs_AccountId",
                table: "tbllogs",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbllogs_tblaccounts_AccountId",
                table: "tbllogs",
                column: "AccountId",
                principalTable: "tblaccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbllogs_tblaccounts_AccountId",
                table: "tbllogs");

            migrationBuilder.DropIndex(
                name: "IX_tbllogs_AccountId",
                table: "tbllogs");
        }
    }
}
