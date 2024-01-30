using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    public partial class SeedSuCategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO SubCategories(Name, CategoryId) 
                     VALUES('Drama', 7), ('Mystery', 7),('Horror', 7),('Sci-fi', 7),('Art', 8), ('Biography', 8),('Sport', 8),('Travel', 8),('Blues', 9), ('Classical', 9),('Folk', 9),('Hip-Hop', 9)
              ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
