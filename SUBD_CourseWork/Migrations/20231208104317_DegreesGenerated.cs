using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SUBD_CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class DegreesGenerated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "public",
                table: "degrees",
                columns: new[] { "Id", "DegreeType", "DisciplineId", "YearOfAward" },
                values: new object[,]
                {
                    { 1, "Кандидат наук", 4, new DateOnly(2015, 12, 28) },
                    { 2, "Кандидат наук", 3, new DateOnly(2020, 10, 29) },
                    { 3, "Кандидат наук", 3, new DateOnly(2010, 9, 6) },
                    { 4, "Кандидат наук", 5, new DateOnly(2010, 8, 5) },
                    { 5, "Доктор наук", 1, new DateOnly(2012, 2, 20) },
                    { 6, "Доктор наук", 2, new DateOnly(2018, 6, 6) },
                    { 7, "Кандидат наук", 1, new DateOnly(2021, 4, 10) },
                    { 8, "Кандидат наук", 4, new DateOnly(2018, 10, 2) },
                    { 9, "Доктор наук", 5, new DateOnly(2019, 11, 14) },
                    { 10, "Доктор наук", 2, new DateOnly(2018, 11, 30) },
                    { 11, "Кандидат наук", 1, new DateOnly(2022, 6, 4) },
                    { 12, "Доктор наук", 3, new DateOnly(2022, 1, 15) },
                    { 13, "Доктор наук", 1, new DateOnly(2023, 2, 7) },
                    { 14, "Доктор наук", 2, new DateOnly(2018, 6, 17) },
                    { 15, "Кандидат наук", 4, new DateOnly(2020, 12, 13) },
                    { 16, "Кандидат наук", 1, new DateOnly(2007, 10, 5) },
                    { 17, "Кандидат наук", 5, new DateOnly(2012, 4, 13) },
                    { 18, "Кандидат наук", 4, new DateOnly(2007, 8, 28) },
                    { 19, "Кандидат наук", 4, new DateOnly(2010, 6, 23) },
                    { 20, "Доктор наук", 1, new DateOnly(2023, 4, 1) },
                    { 21, "Кандидат наук", 5, new DateOnly(2019, 6, 16) },
                    { 22, "Доктор наук", 5, new DateOnly(2007, 8, 13) },
                    { 23, "Кандидат наук", 5, new DateOnly(2019, 11, 19) },
                    { 24, "Кандидат наук", 1, new DateOnly(2011, 5, 25) },
                    { 25, "Доктор наук", 1, new DateOnly(2014, 4, 7) },
                    { 26, "Кандидат наук", 4, new DateOnly(2008, 8, 6) },
                    { 27, "Доктор наук", 1, new DateOnly(2017, 3, 17) },
                    { 28, "Кандидат наук", 1, new DateOnly(2014, 4, 26) },
                    { 29, "Доктор наук", 2, new DateOnly(2009, 3, 10) },
                    { 30, "Кандидат наук", 3, new DateOnly(2010, 1, 13) },
                    { 31, "Кандидат наук", 3, new DateOnly(2013, 9, 30) },
                    { 32, "Доктор наук", 4, new DateOnly(2019, 4, 14) },
                    { 33, "Кандидат наук", 5, new DateOnly(2020, 7, 27) },
                    { 34, "Доктор наук", 2, new DateOnly(2021, 8, 14) },
                    { 35, "Доктор наук", 4, new DateOnly(2008, 4, 18) },
                    { 36, "Доктор наук", 5, new DateOnly(2011, 4, 15) },
                    { 37, "Кандидат наук", 2, new DateOnly(2006, 3, 30) },
                    { 38, "Доктор наук", 5, new DateOnly(2018, 4, 26) },
                    { 39, "Кандидат наук", 4, new DateOnly(2017, 12, 26) },
                    { 40, "Доктор наук", 5, new DateOnly(2022, 2, 8) },
                    { 41, "Доктор наук", 3, new DateOnly(2015, 1, 29) },
                    { 42, "Кандидат наук", 2, new DateOnly(2022, 12, 28) },
                    { 43, "Доктор наук", 2, new DateOnly(2023, 1, 15) },
                    { 44, "Кандидат наук", 2, new DateOnly(2014, 2, 2) },
                    { 45, "Доктор наук", 1, new DateOnly(2018, 9, 17) },
                    { 46, "Кандидат наук", 3, new DateOnly(2021, 8, 2) },
                    { 47, "Кандидат наук", 5, new DateOnly(2011, 7, 10) },
                    { 48, "Доктор наук", 5, new DateOnly(2017, 11, 23) },
                    { 49, "Доктор наук", 5, new DateOnly(2022, 10, 2) },
                    { 50, "Доктор наук", 4, new DateOnly(2009, 12, 5) },
                    { 51, "Кандидат наук", 4, new DateOnly(2012, 6, 12) },
                    { 52, "Доктор наук", 1, new DateOnly(2012, 9, 4) },
                    { 53, "Доктор наук", 4, new DateOnly(2021, 8, 6) },
                    { 54, "Доктор наук", 5, new DateOnly(2016, 7, 11) },
                    { 55, "Кандидат наук", 1, new DateOnly(2019, 8, 8) },
                    { 56, "Кандидат наук", 5, new DateOnly(2008, 3, 18) },
                    { 57, "Кандидат наук", 5, new DateOnly(2010, 7, 16) },
                    { 58, "Доктор наук", 5, new DateOnly(2022, 12, 9) },
                    { 59, "Кандидат наук", 4, new DateOnly(2022, 2, 27) },
                    { 60, "Кандидат наук", 3, new DateOnly(2011, 4, 9) },
                    { 61, "Кандидат наук", 1, new DateOnly(2008, 11, 5) },
                    { 62, "Доктор наук", 1, new DateOnly(2023, 5, 6) },
                    { 63, "Доктор наук", 3, new DateOnly(2020, 3, 13) },
                    { 64, "Кандидат наук", 3, new DateOnly(2022, 8, 6) },
                    { 65, "Доктор наук", 3, new DateOnly(2023, 3, 8) },
                    { 66, "Доктор наук", 2, new DateOnly(2011, 6, 11) },
                    { 67, "Доктор наук", 4, new DateOnly(2017, 6, 3) },
                    { 68, "Доктор наук", 4, new DateOnly(2012, 5, 24) },
                    { 69, "Доктор наук", 5, new DateOnly(2020, 8, 12) },
                    { 70, "Кандидат наук", 2, new DateOnly(2020, 4, 12) }
                });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 1,
                column: "DisciplineType",
                value: "Гуманитарные науки");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 2,
                column: "DisciplineType",
                value: "Общественные науки");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 3,
                column: "DisciplineType",
                value: "Естественные науки");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 4,
                column: "DisciplineType",
                value: "Формальные науки");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 5,
                column: "DisciplineType",
                value: "Прикладные науки");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "StreetId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "StreetId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "StreetId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "StreetId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 13,
                column: "StreetId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 14,
                column: "StreetId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 15,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 16,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "StreetId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "StreetId",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 21,
                column: "StreetId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "StreetId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "StreetId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 29,
                column: "StreetId",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 30,
                column: "StreetId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "StreetId",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "StreetId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "StreetId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "StreetId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "StreetId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "StreetId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 42,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 43,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "StreetId",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "StreetId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "StreetId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "StreetId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "StreetId",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 1,
                column: "DisciplineType",
                value: "Технических наук");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 2,
                column: "DisciplineType",
                value: "Экономических наук");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 3,
                column: "DisciplineType",
                value: "Математических наук");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 4,
                column: "DisciplineType",
                value: "Информационных наук");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "disciplines",
                keyColumn: "Id",
                keyValue: 5,
                column: "DisciplineType",
                value: "Философских наук");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "StreetId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "StreetId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "StreetId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 13,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 14,
                column: "StreetId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 15,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 16,
                column: "StreetId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "StreetId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "StreetId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 21,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 29,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 30,
                column: "StreetId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "StreetId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "StreetId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "StreetId",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 42,
                column: "StreetId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 43,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "StreetId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "StreetId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "StreetId",
                value: 5);
        }
    }
}
