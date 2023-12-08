using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SUBD_CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class GeneratedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_houseNumbers_streets_StreetId",
                schema: "public",
                table: "houseNumbers");

            migrationBuilder.AlterColumn<int>(
                name: "StreetId",
                schema: "public",
                table: "houseNumbers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "public",
                table: "streets",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "пр. Набережная" },
                    { 2, "Пионерская улица" },
                    { 3, "улица Дорожная" },
                    { 4, "пл. Шоссейная" },
                    { 5, "пл. Пролетарская" },
                    { 6, "Вокзальная площадь" },
                    { 7, "Труда проспект" },
                    { 8, "Сосновая пл." },
                    { 9, "Механизаторов площадь" },
                    { 10, "Совхозная пл." },
                    { 11, "ул. Набережная" },
                    { 12, "улица Мира" },
                    { 13, "улица Партизанская" },
                    { 14, "Мира площадь" },
                    { 15, "Мира ул." },
                    { 16, "Степная улица" },
                    { 17, "Строительная улица" },
                    { 18, "пр. Дзержинского" },
                    { 19, "проспект Крупской" },
                    { 20, "ул. Пролетарская" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "houseNumbers",
                columns: new[] { "Id", "House", "StreetId" },
                values: new object[,]
                {
                    { 1, 50, 1 },
                    { 2, 21, 17 },
                    { 3, 39, 11 },
                    { 4, 82, 3 },
                    { 5, 79, 15 },
                    { 6, 97, 4 },
                    { 7, 98, 1 },
                    { 8, 80, 2 },
                    { 9, 31, 3 },
                    { 10, 25, 11 },
                    { 11, 76, 4 },
                    { 12, 72, 11 },
                    { 13, 41, 13 },
                    { 14, 64, 17 },
                    { 15, 11, 11 },
                    { 16, 48, 12 },
                    { 17, 86, 5 },
                    { 18, 16, 7 },
                    { 19, 6, 5 },
                    { 20, 68, 5 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_houseNumbers_streets_StreetId",
                schema: "public",
                table: "houseNumbers",
                column: "StreetId",
                principalSchema: "public",
                principalTable: "streets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_houseNumbers_streets_StreetId",
                schema: "public",
                table: "houseNumbers");

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "streets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.AlterColumn<int>(
                name: "StreetId",
                schema: "public",
                table: "houseNumbers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_houseNumbers_streets_StreetId",
                schema: "public",
                table: "houseNumbers",
                column: "StreetId",
                principalSchema: "public",
                principalTable: "streets",
                principalColumn: "Id");
        }
    }
}
