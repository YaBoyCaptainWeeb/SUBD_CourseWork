using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SUBD_CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class BaseVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "academicRanks",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AcademicRankType = table.Column<string>(type: "text", nullable: false),
                    YearOfAward = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_academicRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "disciplines",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DisciplineType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disciplines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "institutions",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobTitles",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobTitlesType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "streets",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_streets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "typeOfCooperations",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoopType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeOfCooperations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "typeOfWorks",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeOfWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    startOfYear = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    endOfYear = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "degrees",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DegreeType = table.Column<string>(type: "text", nullable: false),
                    YearOfAward = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DisciplineId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_degrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_degrees_disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalSchema: "public",
                        principalTable: "disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "faculties",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: true),
                    InstitutionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_faculties_institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalSchema: "public",
                        principalTable: "institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "houseNumbers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    House = table.Column<int>(type: "integer", nullable: false),
                    StreetId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_houseNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_houseNumbers_streets_StreetId",
                        column: x => x.StreetId,
                        principalSchema: "public",
                        principalTable: "streets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "departments",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: true),
                    FacultyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_departments_faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalSchema: "public",
                        principalTable: "faculties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateOfBeginning = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateOfEnding = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Wage = table.Column<double>(type: "double precision", nullable: false),
                    ElectedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    HouseNumberId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    JobTitleId = table.Column<int>(type: "integer", nullable: false),
                    TypeOfCooperationId = table.Column<int>(type: "integer", nullable: false),
                    DegreeId = table.Column<int>(type: "integer", nullable: false),
                    AcademicRankId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_teachers_academicRanks_AcademicRankId",
                        column: x => x.AcademicRankId,
                        principalSchema: "public",
                        principalTable: "academicRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_teachers_degrees_DegreeId",
                        column: x => x.DegreeId,
                        principalSchema: "public",
                        principalTable: "degrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_teachers_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "public",
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_teachers_houseNumbers_HouseNumberId",
                        column: x => x.HouseNumberId,
                        principalSchema: "public",
                        principalTable: "houseNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_teachers_jobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalSchema: "public",
                        principalTable: "jobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_teachers_typeOfCooperations_TypeOfCooperationId",
                        column: x => x.TypeOfCooperationId,
                        principalSchema: "public",
                        principalTable: "typeOfCooperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "emailAdresses",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emailAdresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_emailAdresses_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalSchema: "public",
                        principalTable: "teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "individualPlans",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeOfWorkId = table.Column<int>(type: "integer", nullable: false),
                    plannedForFallSemestre = table.Column<int>(type: "integer", nullable: false),
                    plannedForSpringSemestre = table.Column<int>(type: "integer", nullable: false),
                    factForFallSemestre = table.Column<int>(type: "integer", nullable: false),
                    factForSpringSemestre = table.Column<int>(type: "integer", nullable: false),
                    teacherId = table.Column<int>(type: "integer", nullable: false),
                    YearId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_individualPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_individualPlans_Years_YearId",
                        column: x => x.YearId,
                        principalSchema: "public",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_individualPlans_teachers_teacherId",
                        column: x => x.teacherId,
                        principalSchema: "public",
                        principalTable: "teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_individualPlans_typeOfWorks_TypeOfWorkId",
                        column: x => x.TypeOfWorkId,
                        principalSchema: "public",
                        principalTable: "typeOfWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phoneNumbers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "text", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_phoneNumbers_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalSchema: "public",
                        principalTable: "teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "academicRanks",
                columns: new[] { "Id", "AcademicRankType", "YearOfAward" },
                values: new object[] { 1, "Доцент", new DateTime(2003, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                schema: "public",
                table: "disciplines",
                columns: new[] { "Id", "DisciplineType" },
                values: new object[,]
                {
                    { 1, "Технических наук" },
                    { 2, "Экономических наук" },
                    { 3, "Математических наук" },
                    { 4, "Информационных наук" },
                    { 5, "Философских наук" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "institutions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 1, "Оренбургский государственный университет", "ОГУ" });

            migrationBuilder.InsertData(
                schema: "public",
                table: "jobTitles",
                columns: new[] { "Id", "JobTitlesType" },
                values: new object[,]
                {
                    { 1, "Асссистент" },
                    { 2, "Преподаватель" },
                    { 3, "Старший преподаватель" },
                    { 4, "Доцент" },
                    { 5, "Профессор" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "typeOfCooperations",
                columns: new[] { "Id", "CoopType" },
                values: new object[,]
                {
                    { 1, "Штатный" },
                    { 2, "Совмещает" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "typeOfWorks",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Учебная работа", null },
                    { 2, "Учебно-методическая работа", null },
                    { 3, "Научно-методическая", null },
                    { 4, "Научно-исслеовательнская работа", null },
                    { 5, "Организационно-методическая работа", null },
                    { 6, "Внеурочная работа со студентами", null },
                    { 7, "Прочие виды работы", null }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "faculties",
                columns: new[] { "Id", "InstitutionId", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, 1, "Институт Математики и информационных технологий", "ИМИТ" },
                    { 2, 1, "Аэрокосмический институт", "АЭИ" },
                    { 3, 1, "Архитектурно-строительный факультет", "АСФ" },
                    { 4, 1, "Институт менеджмента, экономики и предпринимательства", "ИМЭиП" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "departments",
                columns: new[] { "Id", "FacultyId", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, 2, "Кафедра летательных аппаратов", "КЛА" },
                    { 2, 2, "Кафедра материаловедения и технологии материалов", "КМТМ" },
                    { 3, 2, "Кафедра механики материалов, конструкций и машин", "КММКиМ" },
                    { 4, 2, "Кафедра систем автоматизации производства", "КСАП" },
                    { 5, 2, "Кафедра технологии машиностроения, металлообрабатывающих станков и комплексов", "КТММСиК" },
                    { 6, 2, "Кафедра управления и информатики в технических системах", "КУиИТС" },
                    { 7, 1, "Кафедра вычислительной техники и защиты информации", "КВТИИ" },
                    { 8, 1, "Кафедра информатики", "КИ" },
                    { 9, 1, "Кафедра компьютерной безопасности и математического обеспечения информационных систем", "ККБиМОИС" },
                    { 10, 1, "Кафедра математики и цифровых технологий", "КМиЦТ" },
                    { 11, 1, "Кафедра математических методов и моделей в экономике", "КММиМЭ" },
                    { 12, 1, "Кафедра прикладной информатики в экономике и управлении", "КПИЭиУ" },
                    { 13, 1, "Кафедра прикладной математики", "КПМ" },
                    { 14, 1, "Кафедра программного обеспечения вычислительной техники и автоматизированных систем", "КПОВТиАС" },
                    { 15, 1, "Кафедра статистики и эконометрики", "КСиЭ" },
                    { 16, 3, "Кафедра автомобильных дорог и строительных материалов", "КАДиСМ" },
                    { 17, 3, "Кафедра архитектуры", "КА" },
                    { 18, 3, "Кафедра начертательной геометрии, инженерной и компьютерной графики", "КНГНиКГ" },
                    { 19, 3, "Кафедра строительных конструкций", "КСК" },
                    { 20, 3, "Кафедра теплогазоснабжения, вентиляции и гидромеханики", "КТВиГ" },
                    { 21, 3, "Кафедра технологии строительного производства", "КТСП" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_academicRanks_Id",
                schema: "public",
                table: "academicRanks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_degrees_DisciplineId",
                schema: "public",
                table: "degrees",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_degrees_Id",
                schema: "public",
                table: "degrees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_departments_FacultyId",
                schema: "public",
                table: "departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_departments_Id",
                schema: "public",
                table: "departments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_disciplines_Id",
                schema: "public",
                table: "disciplines",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_emailAdresses_Id",
                schema: "public",
                table: "emailAdresses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_emailAdresses_TeacherId",
                schema: "public",
                table: "emailAdresses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_faculties_Id",
                schema: "public",
                table: "faculties",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_faculties_InstitutionId",
                schema: "public",
                table: "faculties",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_houseNumbers_Id",
                schema: "public",
                table: "houseNumbers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_houseNumbers_StreetId",
                schema: "public",
                table: "houseNumbers",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_individualPlans_Id",
                schema: "public",
                table: "individualPlans",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_individualPlans_teacherId",
                schema: "public",
                table: "individualPlans",
                column: "teacherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_individualPlans_TypeOfWorkId",
                schema: "public",
                table: "individualPlans",
                column: "TypeOfWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_individualPlans_YearId",
                schema: "public",
                table: "individualPlans",
                column: "YearId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_institutions_Id",
                schema: "public",
                table: "institutions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_jobTitles_Id",
                schema: "public",
                table: "jobTitles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_phoneNumbers_Id",
                schema: "public",
                table: "phoneNumbers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_phoneNumbers_TeacherId",
                schema: "public",
                table: "phoneNumbers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_streets_Id",
                schema: "public",
                table: "streets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_AcademicRankId",
                schema: "public",
                table: "teachers",
                column: "AcademicRankId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teachers_DegreeId",
                schema: "public",
                table: "teachers",
                column: "DegreeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teachers_DepartmentId",
                schema: "public",
                table: "teachers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_HouseNumberId",
                schema: "public",
                table: "teachers",
                column: "HouseNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_Id",
                schema: "public",
                table: "teachers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_JobTitleId",
                schema: "public",
                table: "teachers",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_TypeOfCooperationId",
                schema: "public",
                table: "teachers",
                column: "TypeOfCooperationId");

            migrationBuilder.CreateIndex(
                name: "IX_typeOfCooperations_Id",
                schema: "public",
                table: "typeOfCooperations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_typeOfWorks_Id",
                schema: "public",
                table: "typeOfWorks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Years_Id",
                schema: "public",
                table: "Years",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emailAdresses",
                schema: "public");

            migrationBuilder.DropTable(
                name: "individualPlans",
                schema: "public");

            migrationBuilder.DropTable(
                name: "phoneNumbers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Years",
                schema: "public");

            migrationBuilder.DropTable(
                name: "typeOfWorks",
                schema: "public");

            migrationBuilder.DropTable(
                name: "teachers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "academicRanks",
                schema: "public");

            migrationBuilder.DropTable(
                name: "degrees",
                schema: "public");

            migrationBuilder.DropTable(
                name: "departments",
                schema: "public");

            migrationBuilder.DropTable(
                name: "houseNumbers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "jobTitles",
                schema: "public");

            migrationBuilder.DropTable(
                name: "typeOfCooperations",
                schema: "public");

            migrationBuilder.DropTable(
                name: "disciplines",
                schema: "public");

            migrationBuilder.DropTable(
                name: "faculties",
                schema: "public");

            migrationBuilder.DropTable(
                name: "streets",
                schema: "public");

            migrationBuilder.DropTable(
                name: "institutions",
                schema: "public");
        }
    }
}
