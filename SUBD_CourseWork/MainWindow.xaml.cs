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
using Bogus;
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
        private Fakers _fakers = new Fakers(); // Генератор данных
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
            //Database.EnsureDeleted();
            //Database.Migrate();
            //Database.EnsureCreated();
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
                new JobTitle { Id = 1, JobTitlesType = "Лаборант"},
                new JobTitle { Id = 2, JobTitlesType = "Асссистент"},
                new JobTitle { Id = 3, JobTitlesType = "Преподаватель"},
                new JobTitle { Id = 4, JobTitlesType = "Старший преподаватель"},
                new JobTitle { Id = 5, JobTitlesType = "Доцент"},
                new JobTitle { Id = 6, JobTitlesType = "Профессор"},
                new JobTitle { Id = 7, JobTitlesType = "Заведующий кафедрой"}
                );
            modelBuilder.Entity<Discipline>().HasData( // Научная специальность
                new Discipline { Id = 1, DisciplineType = "Гуманитарные науки"},
                new Discipline { Id = 2, DisciplineType = "Общественные науки"},
                new Discipline { Id = 3, DisciplineType = "Естественные науки" },
                new Discipline { Id = 4, DisciplineType = "Формальные науки" },
                new Discipline { Id = 5, DisciplineType = "Прикладные науки"}
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

            //var format = new DateTimeFormatInfo()
            //{
            //    ShortDatePattern = "dd/MM/yyyy"
            //};
            //DateTime time = Convert.ToDateTime("24/10/2003", format);

            //modelBuilder.Entity<AcademicRank>().HasData( // Академические звания
            //    new AcademicRank { Id = 1, AcademicRankType = "Доцент", YearOfAward = time}
                
            //    );
            modelBuilder.Entity<Institution>().HasData( // Институты
                new Institution { Id = 1, Name = "Оренбургский государственный университет", ShortName = "ОГУ"}
                );
            modelBuilder.Entity<Faculty>().HasData( // Факультеты 
                new Faculty { Id = 1, Name = "Институт Математики и информационных технологий", ShortName ="ИМИТ" , InstitutionId = 1},
                new Faculty { Id = 2, Name = "Аэрокосмический институт", ShortName = "АЭИ", InstitutionId = 1},
                new Faculty { Id = 3, Name = "Архитектурно-строительный факультет", ShortName = "АСФ", InstitutionId = 1 },
                new Faculty { Id = 4, Name = "Институт менеджмента, экономики и предпринимательства", ShortName = "ИМЭиП", InstitutionId = 1 }
                );
            #region Кафедры
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
                new Department { Id = 15, Name = "Кафедра статистики и эконометрики", ShortName = "КСиЭ", FacultyId = 1},

                new Department { Id = 16, Name = "Кафедра автомобильных дорог и строительных материалов", ShortName = "КАДиСМ", FacultyId = 3 },
                new Department { Id = 17, Name = "Кафедра архитектуры", ShortName = "КА", FacultyId = 3 },
                new Department { Id = 18, Name = "Кафедра начертательной геометрии, инженерной и компьютерной графики", ShortName = "КНГНиКГ", FacultyId = 3 },
                new Department { Id = 19, Name = "Кафедра строительных конструкций", ShortName = "КСК", FacultyId = 3 },
                new Department { Id = 20, Name = "Кафедра теплогазоснабжения, вентиляции и гидромеханики", ShortName = "КТВиГ", FacultyId = 3 },
                new Department { Id = 21, Name = "Кафедра технологии строительного производства", ShortName = "КТСП", FacultyId = 3 },

                new Department { Id = 22, Name = "Кафедра банковского дела и страхования", ShortName = "КБДиС", FacultyId = 4 },
                new Department { Id = 23, Name = "Кафедра бухгалтерского учета, анализа и аудита", ShortName = "КБУАиА", FacultyId = 4 },
                new Department { Id = 24, Name = "Кафедра государственного и муниципального управления", ShortName = "КГиМУ", FacultyId = 4 },
                new Department { Id = 25, Name = "Кафедра маркетинга и торгового дела", ShortName = "КМиТД", FacultyId = 4 },
                new Department { Id = 26, Name = "Кафедра менеджмента", ShortName = "КМ", FacultyId = 4 },
                new Department { Id = 27, Name = "Кафедра рекламы, связей с общественностью и прикладной политологии", ShortName = "КРСОиПП", FacultyId = 4 },
                new Department { Id = 28, Name = "Кафедра таможенного дела", ShortName = "КТД", FacultyId = 4 },
                new Department { Id = 29, Name = "Кафедра управления персоналом, сервиса и туризма", ShortName = "КУПСиТ", FacultyId = 4 },
                new Department { Id = 30, Name = "Кафедра финансов", ShortName = "КФ", FacultyId = 4 },
                new Department { Id = 31, Name = "Кафедра экономической теории, региональной и отраслевой экономики", ShortName = "КФ", FacultyId = 4 }
                ); // Возможно тут еще кафедр накидать, хз
            #endregion
            int housesCount = 50, streetsCount = 20;
            int teachersCount = 70;

            modelBuilder.Entity<Street>().HasData(_fakers.GetStreetsGenerator().Generate(streetsCount)); // Генерация улиц
            modelBuilder.Entity<HouseNumber>().HasData(_fakers.GetHouseNumberGenerator(streetsCount).Generate(housesCount)); // Генерация номеров домов
            modelBuilder.Entity<AcademicRank>().HasData(_fakers.GetAcademicRankGenerator().Generate(teachersCount)); // Генерация ученых званий
            modelBuilder.Entity<Degree>().HasData(_fakers.GetDegreesGenerator().Generate(teachersCount)); // Генерация ученых степеней
            modelBuilder.Entity<Teacher>().HasData(_fakers.GetTeachersGenerator(housesCount, teachersCount).Generate(teachersCount)); // Генерация учителей
            modelBuilder.Entity<EmailAdress>().HasData(_fakers.GetEmailAdressGenerator(teachersCount).Generate(teachersCount)); // Генерация электронных почт
            modelBuilder.Entity<PhoneNumber>().HasData(_fakers.GetPhoneNumberGenerator(teachersCount).Generate(teachersCount)); // Генерация номеров телефона

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
            var d = db.individualPlans.Include(x => x.TypeOfWork).ToList();
            var b = db.houseNumbers.Include(x => x.street).ToList();
            TeachersGrid.ItemsSource = d;
            //var logStream = new StreamReader("C:\\Users\\User\\source\\repos\\SUBD_CourseWork\\SUBD_CourseWork\\bin\\Debug\\net6.0-windows\\logs.txt", UTF8Encoding.UTF8).ToString();
        }
    }
}
