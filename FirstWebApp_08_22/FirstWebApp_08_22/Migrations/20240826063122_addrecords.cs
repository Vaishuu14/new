using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebApp_08_22.Migrations
{
    /// <inheritdoc />
    public partial class addrecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Currencies_currencyId",
                table: "BookPrices");

            migrationBuilder.DropColumn(
                name: "LaungaugeId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "BookPrices");

            migrationBuilder.RenameColumn(
                name: "currencyId",
                table: "BookPrices",
                newName: "CurrencyId");

            migrationBuilder.RenameIndex(
                name: "IX_BookPrices_currencyId",
                table: "BookPrices",
                newName: "IX_BookPrices_CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Currencies_CurrencyId",
                table: "BookPrices",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Currencies_CurrencyId",
                table: "BookPrices");

            migrationBuilder.RenameColumn(
                name: "CurrencyId",
                table: "BookPrices",
                newName: "currencyId");

            migrationBuilder.RenameIndex(
                name: "IX_BookPrices_CurrencyId",
                table: "BookPrices",
                newName: "IX_BookPrices_currencyId");

            migrationBuilder.AddColumn<int>(
                name: "LaungaugeId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Currency",
                table: "BookPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Currencies_currencyId",
                table: "BookPrices",
                column: "currencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
