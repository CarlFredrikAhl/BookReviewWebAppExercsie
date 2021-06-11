using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewWebAppExercsie.Migrations
{
    public partial class ChangedFromDecmialToIntRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Review",
                type: "decimal(18,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "TextContent",
                value: "I will never ever rate this lower than 10. BEAUTIFUL.");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Rating",
                value: 9m);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Rating",
                value: 6m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Review",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,1)");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "TextContent",
                value: "I will never ever rate this lower than 10 stars. BEAUTIFUL.");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Rating",
                value: 9.5m);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Rating",
                value: 6.5m);
        }
    }
}
