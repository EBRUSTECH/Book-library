using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    public partial class SeedCategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"INSERT INTO Books(Id, Title, Author, Description, Language, ISBN, NumberOfPages, Publisher, PhotoUrl, PublicId,  AddedBy,    SubCategoryId, PublishedDate, CreatedOn, UpdateOn) 
                     VALUES('1', 'The Lost Apothecary', 'Sarah Penner', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in', 'English', '0-5508-3333-1', 30, 'Godwin Publishing Company', '', '',  '',  18, '1/1/0001 12:00:00 AM', '1/1/0001 12:00:00 AM', '1/1/0001 12:00:00 AM'),
           ('2', 'Fitness Habits', 'Subhara Moitra', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in', 'English', '0-5508-3333-1', 30, 'Godwin Publishing Company', '', '',  '', 21, '1/1/0001 12:00:00 AM', '1/1/0001 12:00:00 AM', '1/1/0001 12:00:00 AM'),
           ('3', 'Parts Library', 'Janet Skes CHARLES', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in', 'English', '0-5508-3333-1', 30, 'Godwin Publishing Company', '', '', '', 20, '1/1/0001 12:00:00 AM', '1/1/0001 12:00:00 AM', '1/1/0001 12:00:00 AM')
 ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
