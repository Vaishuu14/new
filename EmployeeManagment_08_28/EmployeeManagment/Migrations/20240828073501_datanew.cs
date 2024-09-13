using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagment.Migrations
{
    /// <inheritdoc />
    public partial class datanew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Name", "Phone" },
                values: new object[] { 2, "shitole@123gmail.com", "Shitole", "987654321" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
