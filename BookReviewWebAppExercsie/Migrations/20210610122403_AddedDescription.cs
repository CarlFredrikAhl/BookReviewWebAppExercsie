using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewWebAppExercsie.Migrations
{
    public partial class AddedDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Description",
                value: "Written for J.R.R. Tolkien’s own children, The Hobbit met with instant critical acclaim when it was first published in 1937. Now recognized as a timeless classic, this introduction to the hobbit Bilbo Baggins, the wizard Gandalf, Gollum, and the spectacular world of Middle-earth recounts of the adventures of a reluctant hero, a powerful and dangerous ring, and the cruel dragon Smaug the Magnificent. The text in this 372-page paperback edition is based on that first published in Great Britain by Collins Modern Classics (1998), and includes a note on the text by Douglas A. Anderson (2001).");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Description",
                value: "Full of sympathetic characters, wildly imaginative situations, and countless exciting details, the first installment in the series assembles an unforgettable magical world and sets the stage for many high-stakes adventures to come.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Description",
                value: "Harriet Vanger, a scion of one of Sweden’s wealthiest families disappeared over forty years ago. All these years later, her aged uncle continues to seek the truth. He hires Mikael Blomkvist, a crusading journalist recently trapped by a libel conviction, to investigate. He is aided by the pierced and tattooed punk prodigy Lisbeth Salander. Together they tap into a vein of unfathomable iniquity and astonishing corruption.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "Description",
                value: "One of the most critically acclaimed suspense writers of our time, New York Times bestseller Gillian Flynn takes that statement to its darkest place in this unputdownable masterpiece about a marriage gone terribly, terribly wrong. The Chicago Tribune proclaimed that her work “draws you in and keeps you reading with the force of a pure but nasty addiction.” Gone Girl’s toxic mix of sharp-edged wit and deliciously chilling prose creates a nerve-fraying thriller that confounds you at every turn.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "Description",
                value: "Between life and death there is a library, and within that library, the shelves go on forever. Every book provides a chance to try another life you could have lived. To see how things would be if you had made other choices . . . Would you have done anything different, if you had the chance to undo your regrets?");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "BookId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "BookId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "BookId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "BookId",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Book");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "BookId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "BookId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "BookId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "BookId",
                value: 4);
        }
    }
}
