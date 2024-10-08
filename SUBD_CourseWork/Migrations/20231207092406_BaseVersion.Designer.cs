﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SUBD_CourseWork;

#nullable disable

namespace SUBD_CourseWork.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231207092406_BaseVersion")]
    partial class BaseVersion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SUBD_CourseWork.Entities.AcademicRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AcademicRankType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("YearOfAward")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("academicRanks", "public");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AcademicRankType = "Доцент",
                            YearOfAward = new DateTime(2003, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Degree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DegreeType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("YearOfAward")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("Id");

                    b.ToTable("degrees", "public");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("FacultyId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("Id");

                    b.ToTable("departments", "public");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FacultyId = 2,
                            Name = "Кафедра летательных аппаратов",
                            ShortName = "КЛА"
                        },
                        new
                        {
                            Id = 2,
                            FacultyId = 2,
                            Name = "Кафедра материаловедения и технологии материалов",
                            ShortName = "КМТМ"
                        },
                        new
                        {
                            Id = 3,
                            FacultyId = 2,
                            Name = "Кафедра механики материалов, конструкций и машин",
                            ShortName = "КММКиМ"
                        },
                        new
                        {
                            Id = 4,
                            FacultyId = 2,
                            Name = "Кафедра систем автоматизации производства",
                            ShortName = "КСАП"
                        },
                        new
                        {
                            Id = 5,
                            FacultyId = 2,
                            Name = "Кафедра технологии машиностроения, металлообрабатывающих станков и комплексов",
                            ShortName = "КТММСиК"
                        },
                        new
                        {
                            Id = 6,
                            FacultyId = 2,
                            Name = "Кафедра управления и информатики в технических системах",
                            ShortName = "КУиИТС"
                        },
                        new
                        {
                            Id = 7,
                            FacultyId = 1,
                            Name = "Кафедра вычислительной техники и защиты информации",
                            ShortName = "КВТИИ"
                        },
                        new
                        {
                            Id = 8,
                            FacultyId = 1,
                            Name = "Кафедра информатики",
                            ShortName = "КИ"
                        },
                        new
                        {
                            Id = 9,
                            FacultyId = 1,
                            Name = "Кафедра компьютерной безопасности и математического обеспечения информационных систем",
                            ShortName = "ККБиМОИС"
                        },
                        new
                        {
                            Id = 10,
                            FacultyId = 1,
                            Name = "Кафедра математики и цифровых технологий",
                            ShortName = "КМиЦТ"
                        },
                        new
                        {
                            Id = 11,
                            FacultyId = 1,
                            Name = "Кафедра математических методов и моделей в экономике",
                            ShortName = "КММиМЭ"
                        },
                        new
                        {
                            Id = 12,
                            FacultyId = 1,
                            Name = "Кафедра прикладной информатики в экономике и управлении",
                            ShortName = "КПИЭиУ"
                        },
                        new
                        {
                            Id = 13,
                            FacultyId = 1,
                            Name = "Кафедра прикладной математики",
                            ShortName = "КПМ"
                        },
                        new
                        {
                            Id = 14,
                            FacultyId = 1,
                            Name = "Кафедра программного обеспечения вычислительной техники и автоматизированных систем",
                            ShortName = "КПОВТиАС"
                        },
                        new
                        {
                            Id = 15,
                            FacultyId = 1,
                            Name = "Кафедра статистики и эконометрики",
                            ShortName = "КСиЭ"
                        },
                        new
                        {
                            Id = 16,
                            FacultyId = 3,
                            Name = "Кафедра автомобильных дорог и строительных материалов",
                            ShortName = "КАДиСМ"
                        },
                        new
                        {
                            Id = 17,
                            FacultyId = 3,
                            Name = "Кафедра архитектуры",
                            ShortName = "КА"
                        },
                        new
                        {
                            Id = 18,
                            FacultyId = 3,
                            Name = "Кафедра начертательной геометрии, инженерной и компьютерной графики",
                            ShortName = "КНГНиКГ"
                        },
                        new
                        {
                            Id = 19,
                            FacultyId = 3,
                            Name = "Кафедра строительных конструкций",
                            ShortName = "КСК"
                        },
                        new
                        {
                            Id = 20,
                            FacultyId = 3,
                            Name = "Кафедра теплогазоснабжения, вентиляции и гидромеханики",
                            ShortName = "КТВиГ"
                        },
                        new
                        {
                            Id = 21,
                            FacultyId = 3,
                            Name = "Кафедра технологии строительного производства",
                            ShortName = "КТСП"
                        });
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DisciplineType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("disciplines", "public");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisciplineType = "Технических наук"
                        },
                        new
                        {
                            Id = 2,
                            DisciplineType = "Экономических наук"
                        },
                        new
                        {
                            Id = 3,
                            DisciplineType = "Математических наук"
                        },
                        new
                        {
                            Id = 4,
                            DisciplineType = "Информационных наук"
                        },
                        new
                        {
                            Id = 5,
                            DisciplineType = "Философских наук"
                        });
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.EmailAdress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("emailAdresses", "public");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("InstitutionId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("faculties", "public");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InstitutionId = 1,
                            Name = "Институт Математики и информационных технологий",
                            ShortName = "ИМИТ"
                        },
                        new
                        {
                            Id = 2,
                            InstitutionId = 1,
                            Name = "Аэрокосмический институт",
                            ShortName = "АЭИ"
                        },
                        new
                        {
                            Id = 3,
                            InstitutionId = 1,
                            Name = "Архитектурно-строительный факультет",
                            ShortName = "АСФ"
                        },
                        new
                        {
                            Id = 4,
                            InstitutionId = 1,
                            Name = "Институт менеджмента, экономики и предпринимательства",
                            ShortName = "ИМЭиП"
                        });
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.HouseNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("House")
                        .HasColumnType("integer");

                    b.Property<int?>("StreetId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("houseNumbers", "public");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.IndividualPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("TypeOfWorkId")
                        .HasColumnType("integer");

                    b.Property<int>("YearId")
                        .HasColumnType("integer");

                    b.Property<int>("factForFallSemestre")
                        .HasColumnType("integer");

                    b.Property<int>("factForSpringSemestre")
                        .HasColumnType("integer");

                    b.Property<int>("plannedForFallSemestre")
                        .HasColumnType("integer");

                    b.Property<int>("plannedForSpringSemestre")
                        .HasColumnType("integer");

                    b.Property<int>("teacherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("TypeOfWorkId");

                    b.HasIndex("YearId")
                        .IsUnique();

                    b.HasIndex("teacherId")
                        .IsUnique();

                    b.ToTable("individualPlans", "public");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("institutions", "public");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Оренбургский государственный университет",
                            ShortName = "ОГУ"
                        });
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.JobTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("JobTitlesType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("jobTitles", "public");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            JobTitlesType = "Асссистент"
                        },
                        new
                        {
                            Id = 2,
                            JobTitlesType = "Преподаватель"
                        },
                        new
                        {
                            Id = 3,
                            JobTitlesType = "Старший преподаватель"
                        },
                        new
                        {
                            Id = 4,
                            JobTitlesType = "Доцент"
                        },
                        new
                        {
                            Id = 5,
                            JobTitlesType = "Профессор"
                        });
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("phoneNumbers", "public");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("streets", "public");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AcademicRankId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOfBeginning")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateOfEnding")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DegreeId")
                        .HasColumnType("integer");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ElectedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("HouseNumberId")
                        .HasColumnType("integer");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeOfCooperationId")
                        .HasColumnType("integer");

                    b.Property<double>("Wage")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("AcademicRankId")
                        .IsUnique();

                    b.HasIndex("DegreeId")
                        .IsUnique();

                    b.HasIndex("DepartmentId");

                    b.HasIndex("HouseNumberId");

                    b.HasIndex("Id");

                    b.HasIndex("JobTitleId");

                    b.HasIndex("TypeOfCooperationId");

                    b.ToTable("teachers", "public");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.TypeOfCooperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CoopType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("typeOfCooperations", "public");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoopType = "Штатный"
                        },
                        new
                        {
                            Id = 2,
                            CoopType = "Совмещает"
                        });
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.TypeOfWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("typeOfWorks", "public");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Учебная работа"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Учебно-методическая работа"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Научно-методическая"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Научно-исслеовательнская работа"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Организационно-методическая работа"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Внеурочная работа со студентами"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Прочие виды работы"
                        });
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Year", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("endOfYear")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("startOfYear")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Years", "public");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Degree", b =>
                {
                    b.HasOne("SUBD_CourseWork.Entities.Discipline", "Discipline")
                        .WithMany("Degrees")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Department", b =>
                {
                    b.HasOne("SUBD_CourseWork.Entities.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.EmailAdress", b =>
                {
                    b.HasOne("SUBD_CourseWork.Entities.Teacher", "Teacher")
                        .WithMany("EmailAdresses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Faculty", b =>
                {
                    b.HasOne("SUBD_CourseWork.Entities.Institution", "Institution")
                        .WithMany("Faculties")
                        .HasForeignKey("InstitutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Institution");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.HouseNumber", b =>
                {
                    b.HasOne("SUBD_CourseWork.Entities.Street", null)
                        .WithMany("HouseNumbers")
                        .HasForeignKey("StreetId");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.IndividualPlan", b =>
                {
                    b.HasOne("SUBD_CourseWork.Entities.TypeOfWork", "TypeOfWork")
                        .WithMany()
                        .HasForeignKey("TypeOfWorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SUBD_CourseWork.Entities.Year", "Year")
                        .WithOne("individualPlans")
                        .HasForeignKey("SUBD_CourseWork.Entities.IndividualPlan", "YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SUBD_CourseWork.Entities.Teacher", "teacher")
                        .WithOne("IndividualPlan")
                        .HasForeignKey("SUBD_CourseWork.Entities.IndividualPlan", "teacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeOfWork");

                    b.Navigation("Year");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.PhoneNumber", b =>
                {
                    b.HasOne("SUBD_CourseWork.Entities.Teacher", "Teacher")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Teacher", b =>
                {
                    b.HasOne("SUBD_CourseWork.Entities.AcademicRank", "AcademicRank")
                        .WithOne("Teacher")
                        .HasForeignKey("SUBD_CourseWork.Entities.Teacher", "AcademicRankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SUBD_CourseWork.Entities.Degree", "Degree")
                        .WithOne("Teacher")
                        .HasForeignKey("SUBD_CourseWork.Entities.Teacher", "DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SUBD_CourseWork.Entities.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SUBD_CourseWork.Entities.HouseNumber", "HouseNumber")
                        .WithMany("Teachers")
                        .HasForeignKey("HouseNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SUBD_CourseWork.Entities.JobTitle", "JobTitle")
                        .WithMany("Teachers")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SUBD_CourseWork.Entities.TypeOfCooperation", "TypeOfCooperation")
                        .WithMany("Teachers")
                        .HasForeignKey("TypeOfCooperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicRank");

                    b.Navigation("Degree");

                    b.Navigation("Department");

                    b.Navigation("HouseNumber");

                    b.Navigation("JobTitle");

                    b.Navigation("TypeOfCooperation");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.AcademicRank", b =>
                {
                    b.Navigation("Teacher")
                        .IsRequired();
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Degree", b =>
                {
                    b.Navigation("Teacher")
                        .IsRequired();
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Discipline", b =>
                {
                    b.Navigation("Degrees");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Faculty", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.HouseNumber", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Institution", b =>
                {
                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.JobTitle", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Street", b =>
                {
                    b.Navigation("HouseNumbers");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Teacher", b =>
                {
                    b.Navigation("EmailAdresses");

                    b.Navigation("IndividualPlan")
                        .IsRequired();

                    b.Navigation("PhoneNumbers");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.TypeOfCooperation", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("SUBD_CourseWork.Entities.Year", b =>
                {
                    b.Navigation("individualPlans")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
