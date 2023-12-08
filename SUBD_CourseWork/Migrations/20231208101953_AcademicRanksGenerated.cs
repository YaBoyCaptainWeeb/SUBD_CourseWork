using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SUBD_CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class AcademicRanksGenerated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "startOfYear",
                schema: "public",
                table: "Years",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "endOfYear",
                schema: "public",
                table: "Years",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ElectedDate",
                schema: "public",
                table: "teachers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfEnding",
                schema: "public",
                table: "teachers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBeginning",
                schema: "public",
                table: "teachers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "BirthDate",
                schema: "public",
                table: "teachers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "YearOfAward",
                schema: "public",
                table: "degrees",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "YearOfAward",
                schema: "public",
                table: "academicRanks",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearOfAward",
                value: new DateOnly(2015, 12, 28));

            migrationBuilder.InsertData(
                schema: "public",
                table: "academicRanks",
                columns: new[] { "Id", "AcademicRankType", "YearOfAward" },
                values: new object[,]
                {
                    { 2, "Доцент", new DateOnly(2020, 10, 29) },
                    { 3, "Доцент", new DateOnly(2010, 9, 6) },
                    { 4, "Доцент", new DateOnly(2010, 8, 5) },
                    { 5, "Профессор", new DateOnly(2012, 2, 20) },
                    { 6, "Профессор", new DateOnly(2018, 6, 6) },
                    { 7, "Доцент", new DateOnly(2021, 4, 10) },
                    { 8, "Доцент", new DateOnly(2018, 10, 2) },
                    { 9, "Профессор", new DateOnly(2019, 11, 14) },
                    { 10, "Профессор", new DateOnly(2018, 11, 30) },
                    { 11, "Доцент", new DateOnly(2022, 6, 4) },
                    { 12, "Профессор", new DateOnly(2022, 1, 15) },
                    { 13, "Профессор", new DateOnly(2023, 2, 7) },
                    { 14, "Профессор", new DateOnly(2018, 6, 17) },
                    { 15, "Доцент", new DateOnly(2020, 12, 13) },
                    { 16, "Доцент", new DateOnly(2007, 10, 5) },
                    { 17, "Доцент", new DateOnly(2012, 4, 13) },
                    { 18, "Доцент", new DateOnly(2007, 8, 28) },
                    { 19, "Доцент", new DateOnly(2010, 6, 23) },
                    { 20, "Профессор", new DateOnly(2023, 4, 1) },
                    { 21, "Доцент", new DateOnly(2019, 6, 16) },
                    { 22, "Профессор", new DateOnly(2007, 8, 13) },
                    { 23, "Доцент", new DateOnly(2019, 11, 19) },
                    { 24, "Доцент", new DateOnly(2011, 5, 25) },
                    { 25, "Профессор", new DateOnly(2014, 4, 7) },
                    { 26, "Доцент", new DateOnly(2008, 8, 6) },
                    { 27, "Профессор", new DateOnly(2017, 3, 17) },
                    { 28, "Доцент", new DateOnly(2014, 4, 26) },
                    { 29, "Профессор", new DateOnly(2009, 3, 10) },
                    { 30, "Доцент", new DateOnly(2010, 1, 13) },
                    { 31, "Доцент", new DateOnly(2013, 9, 30) },
                    { 32, "Профессор", new DateOnly(2019, 4, 14) },
                    { 33, "Доцент", new DateOnly(2020, 7, 27) },
                    { 34, "Профессор", new DateOnly(2021, 8, 14) },
                    { 35, "Профессор", new DateOnly(2008, 4, 18) },
                    { 36, "Профессор", new DateOnly(2011, 4, 15) },
                    { 37, "Доцент", new DateOnly(2006, 3, 30) },
                    { 38, "Профессор", new DateOnly(2018, 4, 26) },
                    { 39, "Доцент", new DateOnly(2017, 12, 26) },
                    { 40, "Профессор", new DateOnly(2022, 2, 8) },
                    { 41, "Профессор", new DateOnly(2015, 1, 29) },
                    { 42, "Доцент", new DateOnly(2022, 12, 28) },
                    { 43, "Профессор", new DateOnly(2023, 1, 15) },
                    { 44, "Доцент", new DateOnly(2014, 2, 2) },
                    { 45, "Профессор", new DateOnly(2018, 9, 17) },
                    { 46, "Доцент", new DateOnly(2021, 8, 2) },
                    { 47, "Доцент", new DateOnly(2011, 7, 10) },
                    { 48, "Профессор", new DateOnly(2017, 11, 23) },
                    { 49, "Профессор", new DateOnly(2022, 10, 2) },
                    { 50, "Профессор", new DateOnly(2009, 12, 5) },
                    { 51, "Доцент", new DateOnly(2012, 6, 12) },
                    { 52, "Профессор", new DateOnly(2012, 9, 4) },
                    { 53, "Профессор", new DateOnly(2021, 8, 6) },
                    { 54, "Профессор", new DateOnly(2016, 7, 11) },
                    { 55, "Доцент", new DateOnly(2019, 8, 8) },
                    { 56, "Доцент", new DateOnly(2008, 3, 18) },
                    { 57, "Доцент", new DateOnly(2010, 7, 16) },
                    { 58, "Профессор", new DateOnly(2022, 12, 9) },
                    { 59, "Доцент", new DateOnly(2022, 2, 27) },
                    { 60, "Доцент", new DateOnly(2011, 4, 9) },
                    { 61, "Доцент", new DateOnly(2008, 11, 5) },
                    { 62, "Профессор", new DateOnly(2023, 5, 6) },
                    { 63, "Профессор", new DateOnly(2020, 3, 13) },
                    { 64, "Доцент", new DateOnly(2022, 8, 6) },
                    { 65, "Профессор", new DateOnly(2023, 3, 8) },
                    { 66, "Профессор", new DateOnly(2011, 6, 11) },
                    { 67, "Профессор", new DateOnly(2017, 6, 3) },
                    { 68, "Профессор", new DateOnly(2012, 5, 24) },
                    { 69, "Профессор", new DateOnly(2020, 8, 12) },
                    { 70, "Доцент", new DateOnly(2020, 4, 12) }
                });

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
                keyValue: 3,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "StreetId",
                value: 2);

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
                keyValue: 19,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "StreetId",
                value: 8);

            migrationBuilder.InsertData(
                schema: "public",
                table: "houseNumbers",
                columns: new[] { "Id", "House", "StreetId" },
                values: new object[,]
                {
                    { 21, 51, 11 },
                    { 22, 94, 3 },
                    { 23, 72, 10 },
                    { 24, 35, 17 },
                    { 25, 98, 10 },
                    { 26, 36, 7 },
                    { 27, 89, 10 },
                    { 28, 72, 1 },
                    { 29, 25, 4 },
                    { 30, 90, 8 },
                    { 31, 19, 1 },
                    { 32, 71, 6 },
                    { 33, 97, 6 },
                    { 34, 67, 15 },
                    { 35, 81, 4 },
                    { 36, 94, 19 },
                    { 37, 15, 19 },
                    { 38, 54, 5 },
                    { 39, 59, 1 },
                    { 40, 65, 11 },
                    { 41, 90, 2 },
                    { 42, 93, 12 },
                    { 43, 10, 4 },
                    { 44, 22, 18 },
                    { 45, 84, 3 },
                    { 46, 31, 4 },
                    { 47, 74, 18 },
                    { 48, 79, 11 },
                    { 49, 11, 2 },
                    { 50, 41, 5 }
                });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobTitlesType",
                value: "Лаборант");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobTitlesType",
                value: "Асссистент");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobTitlesType",
                value: "Преподаватель");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobTitlesType",
                value: "Старший преподаватель");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobTitlesType",
                value: "Доцент");

            migrationBuilder.InsertData(
                schema: "public",
                table: "jobTitles",
                columns: new[] { "Id", "JobTitlesType" },
                values: new object[,]
                {
                    { 6, "Профессор" },
                    { 7, "Заведующий кафедрой" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "startOfYear",
                schema: "public",
                table: "Years",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "endOfYear",
                schema: "public",
                table: "Years",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ElectedDate",
                schema: "public",
                table: "teachers",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEnding",
                schema: "public",
                table: "teachers",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBeginning",
                schema: "public",
                table: "teachers",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                schema: "public",
                table: "teachers",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfAward",
                schema: "public",
                table: "degrees",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfAward",
                schema: "public",
                table: "academicRanks",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearOfAward",
                value: new DateTime(2003, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "StreetId",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 13,
                column: "StreetId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 14,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 15,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 16,
                column: "StreetId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 19,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobTitlesType",
                value: "Асссистент");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobTitlesType",
                value: "Преподаватель");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobTitlesType",
                value: "Старший преподаватель");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobTitlesType",
                value: "Доцент");

            migrationBuilder.UpdateData(
                schema: "public",
                table: "jobTitles",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobTitlesType",
                value: "Профессор");
        }
    }
}
