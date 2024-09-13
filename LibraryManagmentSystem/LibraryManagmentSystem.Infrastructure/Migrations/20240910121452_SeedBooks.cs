using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagmentSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "ISBN", "NumberOfCopies", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Fiction", "9780743273565", 10, "The Great Gatsby" },
                    { 2, "Harper Lee", "Fiction", "9780060935467", 8, "To Kill a Mockingbird" },
                    { 3, "George Orwell", "Dystopian", "9780451524935", 12, "1984" },
                    { 4, "Jane Austen", "Romance", "9780141040349", 7, "Pride and Prejudice" },
                    { 5, "J.D. Salinger", "Fiction", "9780316769488", 6, "The Catcher in the Rye" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
