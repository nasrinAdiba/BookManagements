using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagements.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    publisherName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    publisherAge = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    pageNumber = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    publishDate = table.Column<DateTime>(type: "datetime2", maxLength: 200, nullable: false),
                    type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
