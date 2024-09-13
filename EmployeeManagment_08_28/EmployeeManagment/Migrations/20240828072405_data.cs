using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagment.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Name", "Phone" },
                values: new object[] { 1, "vaishnavi@123gmail.com", "Vaishnavi", "123456789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
