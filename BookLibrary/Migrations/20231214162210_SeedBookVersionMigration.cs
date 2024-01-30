using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    public partial class SeedBookVersionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO BookVersions(Version, CopiesInLibrary, BookId) 
                     VALUES('Book', 5, 1), ('CD', 5, 1),
                     ('Book', 10, 2), ('CD', 15, 2),
                     ('Book', 5, 3), ('CD', 5, 3)
              ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
