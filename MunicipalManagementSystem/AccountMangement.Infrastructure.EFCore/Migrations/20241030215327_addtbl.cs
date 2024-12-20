using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class addtbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "tbllogs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "tbllogs");
        }
    }
}
