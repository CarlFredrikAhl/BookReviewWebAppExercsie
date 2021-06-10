using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewWebAppExercsie.Migrations
{
    public partial class AddExampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 1, "J.R.R. Tolkien" },
                    { 2, "J.K. Rowling" },
                    { 3, "Stieg Larsson" },
                    { 4, "Gillian Flynn" },
                    { 5, "Matt Haig" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorId", "Date", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2002, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classics", "The Hobbit, or There and Back Again" },
                    { 2, 2, new DateTime(2003, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantasy", "Harry Potter and the Sorcerer's Stone" },
                    { 3, 3, new DateTime(2008, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller", "The Girl with the Dragon Tattoo" },
                    { 4, 4, new DateTime(2014, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mystery", "Gone girl" },
                    { 5, 5, new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantasy", "The Midnight Library" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "BookId", "Name", "TextContent" },
                values: new object[,]
                {
                    { 1, 4, "Inge", "Cool Story Bro" },
                    { 2, 4, "Zoe", "I will never ever rate this lower than 5 stars. BEAUTIFUL." },
                    { 3, 4, "Diane Wallace", "Loved it! an interesting,mystery filled and very thrill-seeking storyline..was well written,nice movie also... (paperback!)" },
                    { 4, 4, "NReads", "yo Amy really did THAT" },
                    { 5, 4, "Emily B", "This was cute and the concept was great but unfortunately it really lacked some depth for me!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4);
        }
    }
}
