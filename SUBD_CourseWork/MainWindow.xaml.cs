using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using NpgsqlTypes;
using SUBD_CourseWork;
using SUBD_CourseWork.Configurations;
using SUBD_CourseWork.Entities;



namespace SUBD_CourseWork
{
    class UtcValueConverter : ValueConverter<DateTime, DateTime>
    {
        public UtcValueConverter()
            : base(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Local))
        {
        }
    }
    public class ApplicationContext : DbContext
    {
        // Сущности
        readonly StreamWriter logStream = new StreamWriter("logs.txt", true);
        public DbSet<Teacher> teachers { get; set; } = null!;
        public DbSet<Faculty> faculties { get; set; } = null!;
        public DbSet<Department> departments { get; set; } = null!;
        public DbSet<JobTitle> jobTitles { get; set; } = null!;
        public DbSet<Degree> degrees { get; set; } = null!;
        public DbSet<Discipline> disciplines { get; set; } = null!;
        public DbSet<Institution> institutions { get; set; } = null!;
        public DbSet<AcademicRank> academicRanks { get; set; } = null!;
        public DbSet<TypeOfCooperation> typeOfCooperations { get; set; } = null!;
        public DbSet<Year> Years { get; set; } = null!;
        public DbSet<TypeOfWork> typeOfWorks { get; set; } = null!;
        public DbSet<IndividualPlan> individualPlans { get; set; } = null!;
        public DbSet<EmailAdress> emailAdresses { get; set; } = null!;
        public DbSet<PhoneNumber> phoneNumbers { get; set; } = null!;
        public DbSet<HouseNumber> houseNumbers { get; set; } = null!;
        public DbSet<Street> streets { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Соединение с БД и Логирование
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CourseWorkDB;Username=postgres;Password=123;");
            optionsBuilder.LogTo(logStream.WriteLine, LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Инициализация начальными данными
            modelBuilder.Entity<TypeOfCooperation>().HasData( // Вид сотрудничества
                new TypeOfCooperation { Id = 1, CoopType = "Штатный"},
                new TypeOfCooperation { Id = 2, CoopType = "Совмещает"}
                );
            modelBuilder.Entity<JobTitle>().HasData( // Должность
                new JobTitle { Id = 1, JobTitlesType = "Асссистент"},
                new JobTitle { Id = 2, JobTitlesType = "Преподаватель"},
                new JobTitle { Id = 3, JobTitlesType = "Старший преподаватель"},
                new JobTitle { Id = 4, JobTitlesType = "Доцент"},
                new JobTitle { Id = 5, JobTitlesType = "Профессор"}
                );
            modelBuilder.Entity<Discipline>().HasData( // Научная специальность
                new Discipline { Id = 1, DisciplineType = "Технических наук"},
                new Discipline { Id = 2, DisciplineType = "Экономических наук"},
                new Discipline { Id = 3, DisciplineType = "Математических наук" },
                new Discipline { Id = 4, DisciplineType = "Информационных наук" },
                new Discipline { Id = 5, DisciplineType = "Философских наук"}
                );
            modelBuilder.Entity<TypeOfWork>().HasData( // Виды работы
                new TypeOfWork { Id = 1, Name = "Учебная работа" },
                new TypeOfWork { Id = 2, Name = "Учебно-методическая работа"},
                new TypeOfWork { Id = 3, Name = "Научно-методическая"},
                new TypeOfWork { Id = 4, Name = "Научно-исслеовательнская работа"},
                new TypeOfWork { Id = 5, Name = "Организационно-методическая работа"},
                new TypeOfWork { Id = 6, Name = "Внеурочная работа со студентами"},
                new TypeOfWork { Id = 7, Name = "Прочие виды работы"}
                );

            var format = new DateTimeFormatInfo()
            {
                ShortDatePattern = "dd/MM/yyyy"
            };
            DateTime time = Convert.ToDateTime("24/10/2003", format);

            modelBuilder.Entity<AcademicRank>().HasData( // Академические звания
                new AcademicRank { Id = 1, AcademicRankType = "Доцент", YearOfAward = time}
                
                );
            modelBuilder.Entity<Institution>().HasData( // Институты
                new Institution { Id = 1, Name = "Оренбургский государственный университет", ShortName = "ОГУ"}
                );
            modelBuilder.Entity<Faculty>().HasData( // Факультеты 
                new Faculty { Id = 1, Name = "Институт Математики и информационных технологий", ShortName ="ИМИТ" , InstitutionId = 1},
                new Faculty { Id = 2, Name = "Аэрокосмический институт", ShortName = "АЭИ", InstitutionId = 1}
                );
            modelBuilder.Entity<Department>().HasData( // Кафедры
                new Department { Id = 1, Name = "Кафедра летательных аппаратов", ShortName = "КЛА", FacultyId = 2},
                new Department { Id = 2, Name = "Кафедра материаловедения и технологии материалов", ShortName = "КМТМ", FacultyId = 2},
                new Department { Id = 3, Name = "Кафедра механики материалов, конструкций и машин", ShortName = "КММКиМ", FacultyId = 2},
                new Department { Id = 4, Name = "Кафедра систем автоматизации производства", ShortName = "КСАП", FacultyId = 2},
                new Department { Id = 5, Name = "Кафедра технологии машиностроения, металлообрабатывающих станков и комплексов", ShortName = "КТММСиК", FacultyId = 2},
                new Department { Id = 6, Name = "Кафедра управления и информатики в технических системах", ShortName = "КУиИТС", FacultyId = 2},

                new Department { Id = 7, Name = "Кафедра вычислительной техники и защиты информации", ShortName = "КВТИИ", FacultyId = 1},
                new Department { Id = 8, Name = "Кафедра информатики", ShortName = "КИ", FacultyId = 1},
                new Department { Id = 9, Name = "Кафедра компьютерной безопасности и математического обеспечения информационных систем", ShortName = "ККБиМОИС", FacultyId = 1},
                new Department { Id = 10, Name = "Кафедра математики и цифровых технологий", ShortName = "КМиЦТ", FacultyId = 1},
                new Department { Id = 11, Name = "Кафедра математических методов и моделей в экономике", ShortName = "КММиМЭ", FacultyId = 1},
                new Department { Id = 12, Name = "Кафедра прикладной информатики в экономике и управлении", ShortName = "КПИЭиУ", FacultyId = 1},
                new Department { Id = 13, Name = "Кафедра прикладной математики", ShortName = "КПМ", FacultyId = 1},
                new Department { Id = 14, Name = "Кафедра программного обеспечения вычислительной техники и автоматизированных систем", ShortName = "КПОВТиАС", FacultyId = 1},
                new Department { Id = 15, Name = "Кафедра статистики и эконометрики", ShortName = "КСиЭ", FacultyId = 1}
                );

            // Конфигурации
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.UseIdentityColumns();

            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new TypeOfCooperationConfiguration());
            modelBuilder.ApplyConfiguration(new JobTitleConfiguration());
            modelBuilder.ApplyConfiguration(new DegreesConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new AcademicRankConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplinesConfiguration());
            modelBuilder.ApplyConfiguration(new InstitutionConfiguration());
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration(new IndividualPlanConfiguration());
            modelBuilder.ApplyConfiguration(new TypeOfWorkConfiguration());
            modelBuilder.ApplyConfiguration(new YearConfiguration());
            modelBuilder.ApplyConfiguration(new HouseNumberConfiguration());
            modelBuilder.ApplyConfiguration(new StreetConfiguration());
            modelBuilder.ApplyConfiguration(new EmailAdressConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneNumberConfiguration());

        }
    }
    public partial class MainWindow : Window
    {
    ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();
            //var d = db.teachers.Include(f => f.Faculty).Include(j => j.JobTitle).Include(t => t.TypeOfCooperation).Include(d => d.Degree).Include(a => a.AcademicRank).Include(i => i.Institution).ToList();
            //var d = db.institutions.Include(x => x.Faculties).ThenInclude(x => x.Departments).ToList();
            var d = db.individualPlans.Include(x => x.TypeOfWork).ToList();
            //var x = d[0].Faculties[0].Departments[0];
            TeachersGrid.ItemsSource = d;
            //var logStream = new StreamReader("C:\\Users\\User\\source\\repos\\SUBD_CourseWork\\SUBD_CourseWork\\bin\\Debug\\net6.0-windows\\logs.txt", UTF8Encoding.UTF8).ToString();
            //TestBlock.Text = high.Highlight("SQL", logStream);
        }
    }
}
