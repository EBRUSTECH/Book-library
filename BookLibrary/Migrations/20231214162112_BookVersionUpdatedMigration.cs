using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    public partial class BookVersionUpdatedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookId",
                table: "BookVersions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_BookVersions_BookId",
                table: "BookVersions",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookVersions_Books_BookId",
                table: "BookVersions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookVersions_Books_BookId",
                table: "BookVersions");

            migrationBuilder.DropIndex(
                name: "IX_BookVersions_BookId",
                table: "BookVersions");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookVersions");
        }
    }
}
