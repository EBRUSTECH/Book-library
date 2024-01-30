using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    public partial class SeederMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Categories(Name) 
                     VALUES('Fiction'), ('Non-Fiction'), ('CD Genre')");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
