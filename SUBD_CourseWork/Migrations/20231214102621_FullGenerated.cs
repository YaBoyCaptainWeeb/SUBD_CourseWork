using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SUBD_CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class FullGenerated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_individualPlans_teacherId",
                schema: "public",
                table: "individualPlans");

            migrationBuilder.DropIndex(
                name: "IX_individualPlans_YearId",
                schema: "public",
                table: "individualPlans");

            migrationBuilder.InsertData(
                schema: "public",
                table: "Years",
                columns: new[] { "Id", "endOfYear", "startOfYear" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 5, 30), new DateOnly(2022, 9, 1) },
                    { 2, new DateOnly(2022, 5, 30), new DateOnly(2021, 9, 1) },
                    { 3, new DateOnly(2018, 5, 30), new DateOnly(2017, 9, 1) },
                    { 4, new DateOnly(2017, 5, 30), new DateOnly(2016, 9, 1) },
                    { 5, new DateOnly(2012, 5, 30), new DateOnly(2011, 9, 1) }
                });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearOfAward",
                value: new DateOnly(2015, 2, 15));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "YearOfAward",
                value: new DateOnly(2020, 11, 4));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 3,
                column: "YearOfAward",
                value: new DateOnly(2002, 8, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 4,
                column: "YearOfAward",
                value: new DateOnly(2012, 2, 3));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 5,
                column: "YearOfAward",
                value: new DateOnly(2009, 7, 14));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 6,
                column: "YearOfAward",
                value: new DateOnly(2017, 10, 31));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 7,
                column: "YearOfAward",
                value: new DateOnly(2020, 4, 3));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 8,
                column: "YearOfAward",
                value: new DateOnly(2017, 11, 26));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 9,
                column: "YearOfAward",
                value: new DateOnly(2017, 11, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 10,
                column: "YearOfAward",
                value: new DateOnly(2018, 5, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 11,
                column: "YearOfAward",
                value: new DateOnly(2021, 7, 8));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 12,
                column: "YearOfAward",
                value: new DateOnly(2022, 1, 21));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 13,
                column: "YearOfAward",
                value: new DateOnly(2023, 4, 4));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 14,
                column: "YearOfAward",
                value: new DateOnly(2018, 10, 12));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 15,
                column: "YearOfAward",
                value: new DateOnly(2019, 10, 22));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 16,
                column: "YearOfAward",
                value: new DateOnly(2004, 3, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 17,
                column: "YearOfAward",
                value: new DateOnly(2013, 8, 4));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 18,
                column: "YearOfAward",
                value: new DateOnly(2006, 10, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 19,
                column: "YearOfAward",
                value: new DateOnly(2011, 3, 29));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 20,
                column: "YearOfAward",
                value: new DateOnly(2022, 11, 4));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 21,
                column: "YearOfAward",
                value: new DateOnly(2020, 3, 21));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 22,
                column: "YearOfAward",
                value: new DateOnly(2006, 9, 22));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 23,
                column: "YearOfAward",
                value: new DateOnly(2019, 9, 4));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 24,
                column: "YearOfAward",
                value: new DateOnly(2005, 11, 2));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 25,
                column: "YearOfAward",
                value: new DateOnly(2013, 9, 29));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 26,
                column: "YearOfAward",
                value: new DateOnly(2000, 2, 3));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 27,
                column: "YearOfAward",
                value: new DateOnly(2013, 2, 10));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 28,
                column: "YearOfAward",
                value: new DateOnly(2011, 8, 31));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 29,
                column: "YearOfAward",
                value: new DateOnly(2005, 12, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 30,
                column: "YearOfAward",
                value: new DateOnly(2011, 8, 6));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 31,
                column: "YearOfAward",
                value: new DateOnly(2014, 4, 30));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 32,
                column: "YearOfAward",
                value: new DateOnly(2019, 1, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 33,
                column: "YearOfAward",
                value: new DateOnly(2020, 12, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 34,
                column: "YearOfAward",
                value: new DateOnly(2021, 3, 31));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 35,
                column: "YearOfAward",
                value: new DateOnly(2010, 1, 19));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 36,
                column: "YearOfAward",
                value: new DateOnly(2005, 9, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 37,
                column: "YearOfAward",
                value: new DateOnly(2000, 5, 11));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 38,
                column: "YearOfAward",
                value: new DateOnly(2018, 5, 2));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 39,
                column: "YearOfAward",
                value: new DateOnly(2014, 5, 13));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 40,
                column: "YearOfAward",
                value: new DateOnly(2021, 1, 2));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 41,
                column: "YearOfAward",
                value: new DateOnly(2013, 8, 13));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 42,
                column: "YearOfAward",
                value: new DateOnly(2022, 11, 6));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 43,
                column: "YearOfAward",
                value: new DateOnly(2023, 3, 17));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 44,
                column: "YearOfAward",
                value: new DateOnly(2012, 6, 18));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 45,
                column: "YearOfAward",
                value: new DateOnly(2019, 4, 23));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 46,
                column: "YearOfAward",
                value: new DateOnly(2021, 9, 25));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 47,
                column: "YearOfAward",
                value: new DateOnly(2011, 7, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 48,
                column: "YearOfAward",
                value: new DateOnly(2018, 8, 1));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 49,
                column: "YearOfAward",
                value: new DateOnly(2022, 8, 21));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 50,
                column: "YearOfAward",
                value: new DateOnly(2006, 10, 31));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 51,
                column: "YearOfAward",
                value: new DateOnly(2005, 6, 11));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 52,
                column: "YearOfAward",
                value: new DateOnly(2005, 10, 24));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 53,
                column: "YearOfAward",
                value: new DateOnly(2020, 9, 14));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 54,
                column: "YearOfAward",
                value: new DateOnly(2015, 9, 20));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 55,
                column: "YearOfAward",
                value: new DateOnly(2019, 5, 19));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 56,
                column: "YearOfAward",
                value: new DateOnly(2002, 2, 10));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 57,
                column: "YearOfAward",
                value: new DateOnly(2003, 11, 9));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 58,
                column: "YearOfAward",
                value: new DateOnly(2022, 5, 26));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 59,
                column: "YearOfAward",
                value: new DateOnly(2021, 12, 22));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 60,
                column: "YearOfAward",
                value: new DateOnly(2005, 8, 28));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 61,
                column: "YearOfAward",
                value: new DateOnly(2003, 11, 1));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 62,
                column: "YearOfAward",
                value: new DateOnly(2023, 5, 24));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 63,
                column: "YearOfAward",
                value: new DateOnly(2018, 2, 20));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 64,
                column: "YearOfAward",
                value: new DateOnly(2022, 9, 8));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 65,
                column: "YearOfAward",
                value: new DateOnly(2022, 12, 27));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 66,
                column: "YearOfAward",
                value: new DateOnly(2005, 3, 19));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 67,
                column: "YearOfAward",
                value: new DateOnly(2013, 10, 26));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 68,
                column: "YearOfAward",
                value: new DateOnly(2005, 12, 31));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 69,
                column: "YearOfAward",
                value: new DateOnly(2020, 1, 29));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 70,
                column: "YearOfAward",
                value: new DateOnly(2018, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 7,
                column: "YearOfAward",
                value: new DateOnly(2015, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 8,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 9,
                column: "YearOfAward",
                value: new DateOnly(2016, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2015, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2015, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 21,
                column: "YearOfAward",
                value: new DateOnly(2015, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 22,
                column: "YearOfAward",
                value: new DateOnly(2013, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 23,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2015, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 32,
                column: "YearOfAward",
                value: new DateOnly(2014, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 33,
                column: "YearOfAward",
                value: new DateOnly(2015, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 34,
                column: "YearOfAward",
                value: new DateOnly(2014, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2015, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2014, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2015, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 49,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2015, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 55,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 59,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 65,
                column: "YearOfAward",
                value: new DateOnly(2014, 4, 7));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2016, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2012, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2013, 4, 7) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "TeacherId",
                value: 66);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "TeacherId",
                value: 31);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeacherId",
                value: 65);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeacherId",
                value: 70);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 5,
                column: "TeacherId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 6,
                column: "TeacherId",
                value: 64);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 7,
                column: "TeacherId",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 8,
                column: "TeacherId",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 9,
                column: "TeacherId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 10,
                column: "TeacherId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 11,
                column: "TeacherId",
                value: 27);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 12,
                column: "TeacherId",
                value: 47);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 13,
                column: "TeacherId",
                value: 50);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 14,
                column: "TeacherId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 15,
                column: "TeacherId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 16,
                column: "TeacherId",
                value: 66);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 17,
                column: "TeacherId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 18,
                column: "TeacherId",
                value: 34);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 19,
                column: "TeacherId",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 20,
                column: "TeacherId",
                value: 68);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 21,
                column: "TeacherId",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 22,
                column: "TeacherId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 23,
                column: "TeacherId",
                value: 41);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 24,
                column: "TeacherId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 25,
                column: "TeacherId",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 27,
                column: "TeacherId",
                value: 55);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 28,
                column: "TeacherId",
                value: 24);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 29,
                column: "TeacherId",
                value: 34);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 30,
                column: "TeacherId",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 31,
                column: "TeacherId",
                value: 57);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 32,
                column: "TeacherId",
                value: 47);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 33,
                column: "TeacherId",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 34,
                column: "TeacherId",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 35,
                column: "TeacherId",
                value: 37);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 36,
                column: "TeacherId",
                value: 53);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 37,
                column: "TeacherId",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 38,
                column: "TeacherId",
                value: 61);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 39,
                column: "TeacherId",
                value: 42);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 40,
                column: "TeacherId",
                value: 39);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 41,
                column: "TeacherId",
                value: 37);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 42,
                column: "TeacherId",
                value: 30);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 43,
                column: "TeacherId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 44,
                column: "TeacherId",
                value: 24);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 45,
                column: "TeacherId",
                value: 60);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 46,
                column: "TeacherId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 47,
                column: "TeacherId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 48,
                column: "TeacherId",
                value: 51);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 49,
                column: "TeacherId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 50,
                column: "TeacherId",
                value: 58);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 51,
                column: "TeacherId",
                value: 40);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 52,
                column: "TeacherId",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 53,
                column: "TeacherId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 54,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 55,
                column: "TeacherId",
                value: 69);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 56,
                column: "TeacherId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 57,
                column: "TeacherId",
                value: 64);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 58,
                column: "TeacherId",
                value: 36);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 59,
                column: "TeacherId",
                value: 59);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 60,
                column: "TeacherId",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 61,
                column: "TeacherId",
                value: 29);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 62,
                column: "TeacherId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 63,
                column: "TeacherId",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 64,
                column: "TeacherId",
                value: 47);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 65,
                column: "TeacherId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 66,
                column: "TeacherId",
                value: 40);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 67,
                column: "TeacherId",
                value: 27);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 68,
                column: "TeacherId",
                value: 58);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 69,
                column: "TeacherId",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 70,
                column: "TeacherId",
                value: 46);

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
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "StreetId",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "StreetId",
                value: 17);

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
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "StreetId",
                value: 9);

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
                value: 12);

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
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "StreetId",
                value: 14);

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
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "StreetId",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 21,
                column: "StreetId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "StreetId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "StreetId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "StreetId",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "StreetId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "StreetId",
                value: 14);

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
                keyValue: 31,
                column: "StreetId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "StreetId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "StreetId",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "StreetId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "StreetId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "StreetId",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "StreetId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "StreetId",
                value: 17);

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
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "StreetId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "StreetId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TeacherId",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TeacherId",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeacherId",
                value: 30);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeacherId",
                value: 24);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "TeacherId",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "TeacherId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "TeacherId",
                value: 68);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "TeacherId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "TeacherId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "TeacherId",
                value: 53);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "TeacherId",
                value: 45);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 13,
                column: "TeacherId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 15,
                column: "TeacherId",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "TeacherId",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "TeacherId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 19,
                column: "TeacherId",
                value: 33);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "TeacherId",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "TeacherId",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "TeacherId",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "TeacherId",
                value: 30);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "TeacherId",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "TeacherId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "TeacherId",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "TeacherId",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 29,
                column: "TeacherId",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 30,
                column: "TeacherId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 31,
                column: "TeacherId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "TeacherId",
                value: 52);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "TeacherId",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "TeacherId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "TeacherId",
                value: 30);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "TeacherId",
                value: 64);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "TeacherId",
                value: 68);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "TeacherId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "TeacherId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "TeacherId",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 42,
                column: "TeacherId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 43,
                column: "TeacherId",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "TeacherId",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "TeacherId",
                value: 29);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "TeacherId",
                value: 66);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "TeacherId",
                value: 66);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "TeacherId",
                value: 41);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "TeacherId",
                value: 24);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 51,
                column: "TeacherId",
                value: 33);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 52,
                column: "TeacherId",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 53,
                column: "TeacherId",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 54,
                column: "TeacherId",
                value: 50);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 55,
                column: "TeacherId",
                value: 61);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 56,
                column: "TeacherId",
                value: 31);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 57,
                column: "TeacherId",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 58,
                column: "TeacherId",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 59,
                column: "TeacherId",
                value: 41);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 60,
                column: "TeacherId",
                value: 59);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 61,
                column: "TeacherId",
                value: 63);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 62,
                column: "TeacherId",
                value: 23);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 63,
                column: "TeacherId",
                value: 32);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 64,
                column: "TeacherId",
                value: 34);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 65,
                column: "TeacherId",
                value: 39);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 66,
                column: "TeacherId",
                value: 60);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 67,
                column: "TeacherId",
                value: 56);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 68,
                column: "TeacherId",
                value: 58);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 69,
                column: "TeacherId",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 70,
                column: "TeacherId",
                value: 16);

            migrationBuilder.InsertData(
                schema: "public",
                table: "individualPlans",
                columns: new[] { "Id", "TypeOfWorkId", "YearId", "factForFallSemestre", "factForSpringSemestre", "plannedForFallSemestre", "plannedForSpringSemestre", "teacherId" },
                values: new object[,]
                {
                    { 1, 7, 5, 69, 62, 67, 53, 28 },
                    { 2, 7, 5, 167, 146, 168, 147, 35 },
                    { 3, 2, 2, 88, 133, 92, 132, 22 },
                    { 4, 3, 5, 144, 98, 141, 99, 15 },
                    { 5, 6, 5, 107, 94, 100, 86, 43 },
                    { 6, 6, 1, 156, 110, 150, 104, 65 },
                    { 7, 6, 1, 172, 164, 164, 163, 19 },
                    { 8, 6, 4, 155, 99, 150, 98, 4 },
                    { 9, 5, 4, 73, 49, 68, 55, 2 },
                    { 10, 4, 1, 88, 55, 92, 59, 25 },
                    { 11, 7, 2, 158, 103, 155, 108, 21 },
                    { 12, 7, 3, 41, 168, 50, 169, 59 },
                    { 13, 5, 5, 134, 113, 142, 123, 32 },
                    { 14, 1, 5, 58, 135, 55, 131, 1 },
                    { 15, 3, 4, 170, 80, 168, 75, 62 },
                    { 16, 3, 2, 76, 80, 72, 79, 51 },
                    { 17, 5, 4, 89, 96, 97, 89, 57 },
                    { 18, 5, 4, 139, 32, 149, 41, 53 },
                    { 19, 5, 4, 101, 120, 105, 130, 11 },
                    { 20, 6, 3, 58, 134, 50, 140, 56 },
                    { 21, 5, 2, 73, 154, 77, 162, 46 },
                    { 22, 2, 5, 163, 110, 170, 112, 40 },
                    { 23, 3, 5, 126, 68, 133, 65, 29 },
                    { 24, 3, 5, 109, 131, 111, 122, 26 },
                    { 25, 2, 1, 40, 38, 47, 43, 13 },
                    { 26, 2, 4, 135, 46, 129, 42, 16 },
                    { 27, 1, 1, 60, 165, 64, 157, 33 },
                    { 28, 3, 4, 78, 44, 77, 40, 69 },
                    { 29, 3, 4, 162, 153, 159, 160, 30 },
                    { 30, 3, 2, 56, 119, 48, 124, 37 },
                    { 31, 7, 4, 75, 91, 69, 95, 61 },
                    { 32, 6, 1, 86, 166, 78, 163, 44 },
                    { 33, 7, 5, 60, 48, 62, 48, 67 },
                    { 34, 1, 5, 35, 146, 40, 149, 45 },
                    { 35, 6, 2, 107, 64, 107, 64, 63 },
                    { 36, 7, 3, 79, 124, 86, 126, 3 },
                    { 37, 5, 5, 53, 156, 48, 155, 20 },
                    { 38, 1, 4, 60, 161, 51, 168, 14 },
                    { 39, 5, 3, 111, 90, 113, 87, 7 },
                    { 40, 7, 1, 116, 60, 119, 58, 10 },
                    { 41, 3, 2, 49, 43, 53, 50, 48 },
                    { 42, 7, 3, 151, 48, 142, 43, 36 },
                    { 43, 4, 2, 167, 138, 166, 132, 49 },
                    { 44, 3, 5, 85, 72, 93, 63, 47 },
                    { 45, 1, 2, 58, 75, 63, 68, 39 },
                    { 46, 5, 4, 89, 156, 95, 154, 58 },
                    { 47, 6, 2, 117, 101, 113, 104, 17 },
                    { 48, 1, 3, 67, 93, 62, 93, 64 },
                    { 49, 4, 5, 100, 70, 95, 79, 31 },
                    { 50, 1, 3, 84, 164, 92, 158, 24 },
                    { 51, 1, 3, 47, 177, 54, 170, 8 },
                    { 52, 4, 5, 67, 95, 61, 99, 52 },
                    { 53, 7, 2, 72, 50, 79, 55, 27 },
                    { 54, 3, 2, 144, 157, 138, 159, 70 },
                    { 55, 2, 4, 71, 42, 66, 51, 9 },
                    { 56, 7, 3, 98, 96, 94, 105, 54 },
                    { 57, 6, 4, 129, 142, 136, 142, 5 },
                    { 58, 5, 4, 33, 107, 43, 114, 68 },
                    { 59, 4, 2, 53, 78, 53, 88, 18 },
                    { 60, 7, 3, 64, 116, 72, 110, 66 },
                    { 61, 2, 1, 133, 50, 125, 58, 42 },
                    { 62, 5, 5, 51, 105, 48, 102, 23 },
                    { 63, 5, 5, 59, 148, 65, 151, 6 },
                    { 64, 3, 3, 89, 80, 91, 81, 55 },
                    { 65, 5, 4, 154, 48, 156, 52, 34 },
                    { 66, 3, 5, 62, 137, 68, 140, 12 },
                    { 67, 5, 1, 88, 94, 88, 87, 38 },
                    { 68, 6, 2, 127, 160, 124, 159, 50 },
                    { 69, 7, 1, 106, 71, 105, 80, 41 },
                    { 70, 6, 5, 105, 72, 99, 63, 60 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_individualPlans_teacherId",
                schema: "public",
                table: "individualPlans",
                column: "teacherId");

            migrationBuilder.CreateIndex(
                name: "IX_individualPlans_YearId",
                schema: "public",
                table: "individualPlans",
                column: "YearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_individualPlans_teacherId",
                schema: "public",
                table: "individualPlans");

            migrationBuilder.DropIndex(
                name: "IX_individualPlans_YearId",
                schema: "public",
                table: "individualPlans");

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "individualPlans",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Years",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Years",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Years",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearOfAward",
                value: new DateOnly(2016, 11, 18));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "YearOfAward",
                value: new DateOnly(2020, 6, 29));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 3,
                column: "YearOfAward",
                value: new DateOnly(2012, 3, 1));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 4,
                column: "YearOfAward",
                value: new DateOnly(2006, 11, 24));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 5,
                column: "YearOfAward",
                value: new DateOnly(2012, 2, 24));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 6,
                column: "YearOfAward",
                value: new DateOnly(2017, 10, 29));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 7,
                column: "YearOfAward",
                value: new DateOnly(2021, 4, 14));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 8,
                column: "YearOfAward",
                value: new DateOnly(2017, 8, 11));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 9,
                column: "YearOfAward",
                value: new DateOnly(2019, 11, 18));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 10,
                column: "YearOfAward",
                value: new DateOnly(2019, 3, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 11,
                column: "YearOfAward",
                value: new DateOnly(2021, 11, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 12,
                column: "YearOfAward",
                value: new DateOnly(2022, 5, 14));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 13,
                column: "YearOfAward",
                value: new DateOnly(2022, 12, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 14,
                column: "YearOfAward",
                value: new DateOnly(2016, 1, 13));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 15,
                column: "YearOfAward",
                value: new DateOnly(2020, 12, 17));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 16,
                column: "YearOfAward",
                value: new DateOnly(1998, 10, 13));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 17,
                column: "YearOfAward",
                value: new DateOnly(2007, 10, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 18,
                column: "YearOfAward",
                value: new DateOnly(2004, 1, 18));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 19,
                column: "YearOfAward",
                value: new DateOnly(2005, 4, 1));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 20,
                column: "YearOfAward",
                value: new DateOnly(2023, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 21,
                column: "YearOfAward",
                value: new DateOnly(2019, 12, 19));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 22,
                column: "YearOfAward",
                value: new DateOnly(2000, 5, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 23,
                column: "YearOfAward",
                value: new DateOnly(2019, 11, 23));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 24,
                column: "YearOfAward",
                value: new DateOnly(2013, 7, 1));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 25,
                column: "YearOfAward",
                value: new DateOnly(2010, 7, 8));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 26,
                column: "YearOfAward",
                value: new DateOnly(2001, 10, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 27,
                column: "YearOfAward",
                value: new DateOnly(2013, 11, 9));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 28,
                column: "YearOfAward",
                value: new DateOnly(2008, 6, 13));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 29,
                column: "YearOfAward",
                value: new DateOnly(2006, 9, 28));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 30,
                column: "YearOfAward",
                value: new DateOnly(2010, 10, 26));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 31,
                column: "YearOfAward",
                value: new DateOnly(2011, 6, 30));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 32,
                column: "YearOfAward",
                value: new DateOnly(2016, 9, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 33,
                column: "YearOfAward",
                value: new DateOnly(2020, 3, 16));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 34,
                column: "YearOfAward",
                value: new DateOnly(2020, 8, 6));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 35,
                column: "YearOfAward",
                value: new DateOnly(2003, 2, 4));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 36,
                column: "YearOfAward",
                value: new DateOnly(2011, 12, 31));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 37,
                column: "YearOfAward",
                value: new DateOnly(2006, 4, 3));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 38,
                column: "YearOfAward",
                value: new DateOnly(2017, 9, 14));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 39,
                column: "YearOfAward",
                value: new DateOnly(2016, 9, 3));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 40,
                column: "YearOfAward",
                value: new DateOnly(2020, 12, 31));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 41,
                column: "YearOfAward",
                value: new DateOnly(2011, 2, 25));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 42,
                column: "YearOfAward",
                value: new DateOnly(2022, 7, 12));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 43,
                column: "YearOfAward",
                value: new DateOnly(2022, 11, 25));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 44,
                column: "YearOfAward",
                value: new DateOnly(2015, 3, 12));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 45,
                column: "YearOfAward",
                value: new DateOnly(2016, 5, 26));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 46,
                column: "YearOfAward",
                value: new DateOnly(2020, 9, 6));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 47,
                column: "YearOfAward",
                value: new DateOnly(2010, 2, 25));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 48,
                column: "YearOfAward",
                value: new DateOnly(2016, 11, 25));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 49,
                column: "YearOfAward",
                value: new DateOnly(2022, 7, 2));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 50,
                column: "YearOfAward",
                value: new DateOnly(2005, 4, 8));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 51,
                column: "YearOfAward",
                value: new DateOnly(2007, 5, 9));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 52,
                column: "YearOfAward",
                value: new DateOnly(2010, 10, 23));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 53,
                column: "YearOfAward",
                value: new DateOnly(2021, 6, 24));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 54,
                column: "YearOfAward",
                value: new DateOnly(2017, 5, 11));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 55,
                column: "YearOfAward",
                value: new DateOnly(2018, 5, 30));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 56,
                column: "YearOfAward",
                value: new DateOnly(2008, 3, 22));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 57,
                column: "YearOfAward",
                value: new DateOnly(2005, 5, 4));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 58,
                column: "YearOfAward",
                value: new DateOnly(2022, 10, 13));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 59,
                column: "YearOfAward",
                value: new DateOnly(2022, 1, 26));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 60,
                column: "YearOfAward",
                value: new DateOnly(2009, 11, 15));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 61,
                column: "YearOfAward",
                value: new DateOnly(2008, 1, 8));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 62,
                column: "YearOfAward",
                value: new DateOnly(2023, 2, 14));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 63,
                column: "YearOfAward",
                value: new DateOnly(2019, 5, 19));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 64,
                column: "YearOfAward",
                value: new DateOnly(2022, 7, 14));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 65,
                column: "YearOfAward",
                value: new DateOnly(2023, 2, 25));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 66,
                column: "YearOfAward",
                value: new DateOnly(2010, 10, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 67,
                column: "YearOfAward",
                value: new DateOnly(2015, 8, 17));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 68,
                column: "YearOfAward",
                value: new DateOnly(2008, 7, 23));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 69,
                column: "YearOfAward",
                value: new DateOnly(2018, 12, 18));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "academicRanks",
                keyColumn: "Id",
                keyValue: 70,
                column: "YearOfAward",
                value: new DateOnly(2018, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearOfAward",
                value: new DateOnly(2013, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2016, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 7,
                column: "YearOfAward",
                value: new DateOnly(2015, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 8,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 9,
                column: "YearOfAward",
                value: new DateOnly(2013, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2016, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2016, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 21,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 22,
                column: "YearOfAward",
                value: new DateOnly(2014, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 23,
                column: "YearOfAward",
                value: new DateOnly(2013, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2016, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2016, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 32,
                column: "YearOfAward",
                value: new DateOnly(2016, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 33,
                column: "YearOfAward",
                value: new DateOnly(2013, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 34,
                column: "YearOfAward",
                value: new DateOnly(2014, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2016, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 49,
                column: "YearOfAward",
                value: new DateOnly(2014, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2016, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2016, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 55,
                column: "YearOfAward",
                value: new DateOnly(2015, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 59,
                column: "YearOfAward",
                value: new DateOnly(2012, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 2, new DateOnly(2012, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 65,
                column: "YearOfAward",
                value: new DateOnly(2016, 4, 5));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 4, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 3, new DateOnly(2014, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 1, new DateOnly(2015, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "degrees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DisciplineId", "YearOfAward" },
                values: new object[] { 5, new DateOnly(2013, 4, 5) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "TeacherId",
                value: 47);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "TeacherId",
                value: 32);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeacherId",
                value: 34);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeacherId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 5,
                column: "TeacherId",
                value: 70);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 6,
                column: "TeacherId",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 7,
                column: "TeacherId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 8,
                column: "TeacherId",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 9,
                column: "TeacherId",
                value: 55);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 10,
                column: "TeacherId",
                value: 36);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 11,
                column: "TeacherId",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 12,
                column: "TeacherId",
                value: 48);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 13,
                column: "TeacherId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 14,
                column: "TeacherId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 15,
                column: "TeacherId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 16,
                column: "TeacherId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 17,
                column: "TeacherId",
                value: 47);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 18,
                column: "TeacherId",
                value: 33);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 19,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 20,
                column: "TeacherId",
                value: 34);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 21,
                column: "TeacherId",
                value: 51);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 22,
                column: "TeacherId",
                value: 40);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 23,
                column: "TeacherId",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 24,
                column: "TeacherId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 25,
                column: "TeacherId",
                value: 59);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 27,
                column: "TeacherId",
                value: 65);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 28,
                column: "TeacherId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 29,
                column: "TeacherId",
                value: 41);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 30,
                column: "TeacherId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 31,
                column: "TeacherId",
                value: 45);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 32,
                column: "TeacherId",
                value: 64);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 33,
                column: "TeacherId",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 34,
                column: "TeacherId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 35,
                column: "TeacherId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 36,
                column: "TeacherId",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 37,
                column: "TeacherId",
                value: 52);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 38,
                column: "TeacherId",
                value: 52);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 39,
                column: "TeacherId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 40,
                column: "TeacherId",
                value: 59);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 41,
                column: "TeacherId",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 42,
                column: "TeacherId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 43,
                column: "TeacherId",
                value: 34);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 44,
                column: "TeacherId",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 45,
                column: "TeacherId",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 46,
                column: "TeacherId",
                value: 31);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 47,
                column: "TeacherId",
                value: 69);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 48,
                column: "TeacherId",
                value: 68);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 49,
                column: "TeacherId",
                value: 47);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 50,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 51,
                column: "TeacherId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 52,
                column: "TeacherId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 53,
                column: "TeacherId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 54,
                column: "TeacherId",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 55,
                column: "TeacherId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 56,
                column: "TeacherId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 57,
                column: "TeacherId",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 58,
                column: "TeacherId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 59,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 60,
                column: "TeacherId",
                value: 68);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 61,
                column: "TeacherId",
                value: 41);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 62,
                column: "TeacherId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 63,
                column: "TeacherId",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 64,
                column: "TeacherId",
                value: 50);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 65,
                column: "TeacherId",
                value: 60);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 66,
                column: "TeacherId",
                value: 39);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 67,
                column: "TeacherId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 68,
                column: "TeacherId",
                value: 42);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 69,
                column: "TeacherId",
                value: 48);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "emailAdresses",
                keyColumn: "Id",
                keyValue: 70,
                column: "TeacherId",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "StreetId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "StreetId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "StreetId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "StreetId",
                value: 20);

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
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "StreetId",
                value: 13);

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
                value: 13);

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
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "StreetId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "StreetId",
                value: 4);

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
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 21,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "StreetId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "StreetId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 29,
                column: "StreetId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 30,
                column: "StreetId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 31,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "StreetId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "StreetId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "StreetId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "StreetId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "StreetId",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "StreetId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 42,
                column: "StreetId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 43,
                column: "StreetId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "StreetId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "StreetId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "StreetId",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "StreetId",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "StreetId",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "StreetId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "houseNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "StreetId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TeacherId",
                value: 69);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TeacherId",
                value: 29);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeacherId",
                value: 39);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeacherId",
                value: 50);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "TeacherId",
                value: 53);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "TeacherId",
                value: 55);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "TeacherId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "TeacherId",
                value: 65);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "TeacherId",
                value: 36);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "TeacherId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "TeacherId",
                value: 60);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "TeacherId",
                value: 66);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 13,
                column: "TeacherId",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 15,
                column: "TeacherId",
                value: 51);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "TeacherId",
                value: 37);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "TeacherId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 19,
                column: "TeacherId",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "TeacherId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "TeacherId",
                value: 63);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "TeacherId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "TeacherId",
                value: 36);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "TeacherId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "TeacherId",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "TeacherId",
                value: 66);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "TeacherId",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 29,
                column: "TeacherId",
                value: 69);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 30,
                column: "TeacherId",
                value: 53);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 31,
                column: "TeacherId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "TeacherId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "TeacherId",
                value: 55);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "TeacherId",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "TeacherId",
                value: 63);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "TeacherId",
                value: 32);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "TeacherId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "TeacherId",
                value: 53);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "TeacherId",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "TeacherId",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 42,
                column: "TeacherId",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 43,
                column: "TeacherId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "TeacherId",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "TeacherId",
                value: 65);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "TeacherId",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "TeacherId",
                value: 60);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "TeacherId",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "TeacherId",
                value: 48);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "TeacherId",
                value: 55);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 51,
                column: "TeacherId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 52,
                column: "TeacherId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 53,
                column: "TeacherId",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 54,
                column: "TeacherId",
                value: 70);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 55,
                column: "TeacherId",
                value: 45);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 56,
                column: "TeacherId",
                value: 70);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 57,
                column: "TeacherId",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 58,
                column: "TeacherId",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 59,
                column: "TeacherId",
                value: 59);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 60,
                column: "TeacherId",
                value: 57);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 61,
                column: "TeacherId",
                value: 27);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 62,
                column: "TeacherId",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 63,
                column: "TeacherId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 64,
                column: "TeacherId",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 65,
                column: "TeacherId",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 66,
                column: "TeacherId",
                value: 69);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 67,
                column: "TeacherId",
                value: 45);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 68,
                column: "TeacherId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 69,
                column: "TeacherId",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "phoneNumbers",
                keyColumn: "Id",
                keyValue: 70,
                column: "TeacherId",
                value: 32);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 17, new DateOnly(1996, 6, 21), new DateOnly(2018, 4, 15), 37, 12, new DateOnly(2018, 2, 15), 31, 7, 17000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 23, new DateOnly(1996, 7, 9), new DateOnly(2019, 4, 13), 1, 18, new DateOnly(2019, 1, 13), 22, 2, 53000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 5, new DateOnly(1994, 3, 15), new DateOnly(2018, 4, 18), 6, 5, new DateOnly(2018, 2, 18), 12, 2, 61000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 60, new DateOnly(1992, 3, 19), new DateOnly(2019, 4, 13), 23, 25, new DateOnly(2019, 2, 13), 45, 4, 1, 22000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 43, new DateOnly(1992, 6, 7), new DateOnly(2018, 5, 10), new DateOnly(2022, 7, 24), 40, 7, new DateOnly(2018, 3, 10), 4, 1, 1, 39000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 16, new DateOnly(1991, 8, 24), new DateOnly(2019, 5, 15), 45, 8, new DateOnly(2019, 3, 15), 48, 5, 1, 22000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 48, new DateOnly(1994, 8, 5), new DateOnly(2019, 6, 7), 21, 12, new DateOnly(2019, 3, 7), 33, 2, 1, 57000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "Wage" },
                values: new object[] { 20, new DateOnly(1988, 8, 24), new DateOnly(2018, 6, 7), 38, 21, new DateOnly(2018, 4, 7), 5, 43000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 37, new DateOnly(1991, 8, 28), new DateOnly(2018, 5, 11), 8, 17, new DateOnly(2018, 2, 11), 10, 4, 1, 51000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 52, new DateOnly(1990, 2, 27), new DateOnly(2019, 6, 8), 54, 19, new DateOnly(2019, 3, 8), 39, 5, 2, 24000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 2, new DateOnly(1991, 3, 9), new DateOnly(2019, 6, 20), 17, 16, new DateOnly(2019, 4, 20), 19, 5, 18000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 3, new DateOnly(1990, 3, 21), new DateOnly(2019, 4, 15), 36, 19, new DateOnly(2019, 2, 15), 28, 7, 2, 19000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 46, new DateOnly(1995, 7, 14), new DateOnly(2018, 6, 13), 7, 26, new DateOnly(2018, 4, 13), 23, 2, 1, 38000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "Wage" },
                values: new object[] { 12, new DateOnly(1988, 5, 17), new DateOnly(2019, 6, 8), 56, 19, new DateOnly(2019, 3, 8), 10, 53000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 51, new DateOnly(1993, 7, 21), new DateOnly(2019, 5, 20), 69, 7, new DateOnly(2019, 3, 20), 27, 1, 15000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 11, new DateOnly(1992, 2, 5), new DateOnly(2018, 5, 7), new DateOnly(2021, 7, 18), 61, 9, new DateOnly(2018, 3, 7), 3, 7, 1, 26000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 32, new DateOnly(1991, 7, 11), new DateOnly(2019, 6, 13), 57, 20, new DateOnly(2019, 3, 13), 29, 3, 44000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 66, new DateOnly(1993, 1, 22), new DateOnly(2018, 4, 6), 16, 18, new DateOnly(2018, 2, 6), 14, 4, 61000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 53, new DateOnly(1993, 2, 24), new DateOnly(2018, 5, 8), 68, 3, new DateOnly(2018, 3, 8), 7, 3, 62000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 9, new DateOnly(1991, 4, 30), new DateOnly(2018, 6, 18), 31, 24, new DateOnly(2018, 3, 18), 35, 4, 2, 17000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 55, new DateOnly(1995, 9, 21), new DateOnly(2019, 5, 6), 12, 8, new DateOnly(2019, 3, 6), 20, 1, 2, 33000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 13, new DateOnly(1996, 7, 13), new DateOnly(2019, 5, 16), 30, 5, new DateOnly(2019, 3, 16), 40, 6, 2, 53000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 19, new DateOnly(1994, 3, 10), new DateOnly(2018, 4, 12), new DateOnly(2023, 1, 25), 43, 12, new DateOnly(2018, 1, 12), 1, 1, 55000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 69, new DateOnly(1991, 4, 30), new DateOnly(2018, 5, 13), 33, 5, new DateOnly(2018, 2, 13), 8, 1, 60000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 29, new DateOnly(1994, 3, 6), new DateOnly(2019, 6, 16), 63, 14, new DateOnly(2019, 3, 16), 18, 6, 2, 30000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 63, new DateOnly(1988, 6, 22), new DateOnly(2018, 4, 20), 29, 16, new DateOnly(2018, 2, 20), 22, 6, 31000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 18, new DateOnly(1992, 8, 28), new DateOnly(2018, 5, 9), 10, new DateOnly(2018, 2, 9), 31, 5, 27000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 44, new DateOnly(1993, 9, 14), new DateOnly(2019, 4, 5), 27, 7, new DateOnly(2019, 1, 5), 27, 5, 2, 42000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 33, new DateOnly(1991, 2, 17), new DateOnly(2019, 5, 20), 49, 8, 39, 1, 2, 46000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 31, new DateOnly(1989, 6, 10), new DateOnly(2018, 6, 14), 70, 27, new DateOnly(2018, 4, 14), 50, 5, 30000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 67, new DateOnly(1989, 8, 12), new DateOnly(2018, 4, 19), 66, 14, new DateOnly(2018, 1, 19), 25, 5, 53000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 15, new DateOnly(1989, 6, 26), new DateOnly(2018, 4, 5), 62, 1, new DateOnly(2018, 1, 5), 44, 7, 2, 49000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 24, new DateOnly(1989, 2, 6), new DateOnly(2018, 6, 10), 64, 15, new DateOnly(2018, 4, 10), 46, 3, 26000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 59, new DateOnly(1989, 6, 2), new DateOnly(2018, 5, 17), 42, 15, new DateOnly(2018, 2, 17), 37, 7, 2, 42000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 8, new DateOnly(1992, 8, 21), new DateOnly(2018, 5, 14), 5, 24, new DateOnly(2018, 2, 14), 34, 5, 1, 59000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 21, new DateOnly(1995, 7, 8), new DateOnly(2018, 5, 19), 3, 6, new DateOnly(2018, 3, 19), 26, 5, 19000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 42, new DateOnly(1995, 4, 23), new DateOnly(2019, 4, 17), new DateOnly(2023, 8, 28), 44, 6, 44, 6, 58000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 62, new DateOnly(1995, 7, 21), new DateOnly(2018, 6, 8), new DateOnly(2022, 7, 13), 11, 19, new DateOnly(2018, 4, 8), 46, 1, 35000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 57, new DateOnly(1992, 9, 25), new DateOnly(2019, 6, 12), 14, 28, new DateOnly(2019, 4, 12), 34, 1, 18000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 39, new DateOnly(1988, 1, 29), new DateOnly(2018, 4, 12), 48, 23, new DateOnly(2018, 2, 12), 29, 1, 1, 31000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 40, new DateOnly(1992, 6, 6), new DateOnly(2018, 4, 12), new DateOnly(2022, 2, 21), 2, 17, new DateOnly(2018, 2, 12), 37, 3, 2, 30000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 45, new DateOnly(1994, 4, 28), new DateOnly(2018, 4, 5), 34, 22, new DateOnly(2018, 1, 5), 28, 2, 1, 40000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId" },
                values: new object[] { 38, new DateOnly(1991, 4, 24), new DateOnly(2018, 6, 13), 19, 13, new DateOnly(2018, 3, 13), 19, 1, 1 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 36, new DateOnly(1991, 9, 19), new DateOnly(2019, 5, 5), 41, 4, new DateOnly(2019, 2, 5), 31, 3, 19000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 27, new DateOnly(1991, 7, 21), new DateOnly(2019, 4, 15), 4, 12, new DateOnly(2019, 1, 15), 29, 2, 2, 55000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 50, new DateOnly(1991, 6, 2), new DateOnly(2018, 6, 20), 25, 31, new DateOnly(2018, 4, 20), 13, 2, 63000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 58, new DateOnly(1995, 9, 18), new DateOnly(2018, 4, 6), 35, 16, new DateOnly(2018, 2, 6), 5, 7, 1, 42000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "Wage" },
                values: new object[] { 61, new DateOnly(1994, 8, 5), new DateOnly(2018, 6, 5), 52, 15, new DateOnly(2018, 3, 5), 34, 30000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 30, new DateOnly(1991, 9, 25), new DateOnly(2019, 6, 19), 20, 14, new DateOnly(2019, 4, 19), 42, 5, 54000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 28, new DateOnly(1991, 9, 5), new DateOnly(2018, 5, 14), 10, 7, new DateOnly(2018, 3, 14), 1, 1, 2, 56000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 34, new DateOnly(1989, 3, 26), new DateOnly(2018, 6, 14), new DateOnly(2022, 1, 29), 18, 19, new DateOnly(2018, 4, 14), 30, 4, 64000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 70, new DateOnly(1993, 8, 3), new DateOnly(2019, 5, 15), 47, 17, new DateOnly(2019, 2, 15), 42, 4, 1, 29000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 35, new DateOnly(1992, 5, 27), new DateOnly(2018, 6, 8), 13, 17, new DateOnly(2018, 3, 8), 19, 5, 17000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 22, new DateOnly(1990, 8, 10), new DateOnly(2019, 6, 17), 39, 21, new DateOnly(2019, 4, 17), 3, 4, 2, 55000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 14, new DateOnly(1991, 8, 11), new DateOnly(2018, 5, 13), 55, 4, new DateOnly(2018, 3, 13), 27, 6, 36000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 26, new DateOnly(1992, 3, 19), new DateOnly(2018, 6, 11), 67, 4, new DateOnly(2018, 4, 11), 7, 5, 2, 63000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 41, new DateOnly(1996, 5, 10), new DateOnly(2018, 4, 16), 28, 23, new DateOnly(2018, 2, 16), 36, 7, 48000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 64, new DateOnly(1989, 8, 22), new DateOnly(2019, 5, 7), 22, 17, new DateOnly(2019, 3, 7), 8, 6, 50000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 4, new DateOnly(1990, 8, 18), new DateOnly(2019, 4, 7), 58, 28, new DateOnly(2019, 2, 7), 46, 1, 2, 58000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 25, new DateOnly(1994, 8, 9), new DateOnly(2019, 6, 14), 15, 9, new DateOnly(2019, 4, 14), 2, 2, 59000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 49, new DateOnly(1993, 2, 27), new DateOnly(2019, 4, 8), 51, 23, new DateOnly(2019, 1, 8), 4, 7, 46000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 1, new DateOnly(1994, 8, 31), new DateOnly(2018, 4, 11), 32, 13, new DateOnly(2018, 1, 11), 5, 5, 2, 50000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 56, new DateOnly(1988, 4, 21), new DateOnly(2018, 5, 6), 53, 8, new DateOnly(2018, 2, 6), 46, 5, 16000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 10, new DateOnly(1993, 3, 16), new DateOnly(2018, 6, 10), 24, 28, new DateOnly(2018, 4, 10), 45, 5, 44000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 7, new DateOnly(1995, 4, 5), new DateOnly(2018, 5, 5), new DateOnly(2021, 11, 23), 59, 29, new DateOnly(2018, 2, 5), 14, 1, 1, 62000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 68, new DateOnly(1988, 7, 22), new DateOnly(2018, 5, 19), 65, 6, new DateOnly(2018, 3, 19), 41, 7, 39000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "Wage" },
                values: new object[] { 47, new DateOnly(1994, 5, 9), new DateOnly(2019, 4, 9), 26, 7, new DateOnly(2019, 2, 9), 50, 16000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DateOfEnding", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "TypeOfCooperationId", "Wage" },
                values: new object[] { 6, new DateOnly(1994, 3, 31), new DateOnly(2019, 6, 14), new DateOnly(2022, 12, 23), 50, 15, new DateOnly(2019, 3, 14), 32, 5, 1, 54000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "JobTitleId", "Wage" },
                values: new object[] { 54, new DateOnly(1992, 8, 30), new DateOnly(2018, 5, 19), 60, 30, new DateOnly(2018, 3, 19), 28, 7, 29000.0 });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "teachers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AcademicRankId", "BirthDate", "DateOfBeginning", "DegreeId", "DepartmentId", "ElectedDate", "HouseNumberId", "Wage" },
                values: new object[] { 65, new DateOnly(1992, 8, 22), new DateOnly(2018, 4, 17), 9, 26, new DateOnly(2018, 1, 17), 46, 52000.0 });

            migrationBuilder.CreateIndex(
                name: "IX_individualPlans_teacherId",
                schema: "public",
                table: "individualPlans",
                column: "teacherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_individualPlans_YearId",
                schema: "public",
                table: "individualPlans",
                column: "YearId",
                unique: true);
        }
    }
}
