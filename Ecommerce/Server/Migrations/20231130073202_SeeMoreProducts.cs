using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeeMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[] { 2, "A story of the two brothers, Michael Scofield and Lincoln Burrows.", "https://resizing.flixster.com/pCE28S2R4XLyrCkU5_ZKCuu6hLY=/206x305/v2/https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p185128_b_v8_ag.jpg", "Prison Break" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", 7.99m, "Ready Player One" },
                    { 3, 3, "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. ", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", 69.99m, "GTA V" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" });
        }
    }
}
