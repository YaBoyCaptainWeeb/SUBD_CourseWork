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
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using NpgsqlTypes;
using SUBD_CourseWork;
using SUBD_CourseWork.Configurations;
using SUBD_CourseWork.Entities;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.AvalonEdit.Highlighting;
using Npgsql.Internal.TypeHandlers.LTreeHandlers;
using System.Collections.ObjectModel;
using System.ComponentModel;



namespace SUBD_CourseWork
{
    public class ApplicationContext : DbContext
    {
        private Fakers _fakers = new Fakers(); // Генератор данных
        // Сущности
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
            // Соединение с БД
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CourseWorkDB;Username=postgres;Password=123;");
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
            int yearsCount = 5;

            modelBuilder.Entity<Street>().HasData(_fakers.GetStreetsGenerator().Generate(streetsCount)); // Генерация улиц
            modelBuilder.Entity<HouseNumber>().HasData(_fakers.GetHouseNumberGenerator(streetsCount).Generate(housesCount)); // Генерация номеров домов
            modelBuilder.Entity<AcademicRank>().HasData(_fakers.GetAcademicRankGenerator().Generate(teachersCount)); // Генерация ученых званий
            modelBuilder.Entity<Degree>().HasData(_fakers.GetDegreesGenerator().Generate(teachersCount)); // Генерация ученых степеней
            modelBuilder.Entity<Teacher>().HasData(_fakers.GetTeachersGenerator(housesCount, teachersCount).Generate(teachersCount)); // Генерация учителей
            modelBuilder.Entity<EmailAdress>().HasData(_fakers.GetEmailAdressGenerator(teachersCount).Generate(teachersCount)); // Генерация электронных почт
            modelBuilder.Entity<PhoneNumber>().HasData(_fakers.GetPhoneNumberGenerator(teachersCount).Generate(teachersCount)); // Генерация номеров телефона
            modelBuilder.Entity<Year>().HasData(_fakers.GetYearGenerator(yearsCount).Generate(yearsCount)); // Генерация учебных годов
            modelBuilder.Entity<IndividualPlan>().HasData(_fakers.GetIndividualPlanFaker(teachersCount, yearsCount).Generate(teachersCount)); // Генерация учебных планов

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

    public class ViewModel 
    {
        public ObservableCollection<string> DepartmentSelectorVM { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> FacultySelectorVM { get; set; } = new ObservableCollection<string>();
        public string SQLcode;
        public ViewModel()
        {
            ApplicationContext db = new ApplicationContext();
            var buff = db.faculties.Select(x => x.Name).OrderBy(x => x).ToList();
            foreach(var card in buff)
            {
                FacultySelectorVM!.Add(card);
            }
        }
    }
    public partial class MainWindow : Window
    {
        public ApplicationContext db = new ApplicationContext();
        public ViewModel vm = new ViewModel();

        public string departmentName { get; set; } = "Не выбрано";
        public string facultyName { get; set; } = "Не выбрано";
        public DateOnly fromBetween { get; set; }
        public DateOnly toBetween { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadContent();

            FacultySelector.DataContext = vm;
            DepartmentSelector.DataContext = vm;
            SQLcode2.DataContext = vm;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var resourceNames = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            using (var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("SUBD_CourseWork.SQL.xshd"))
            {
                using (var reader = new System.Xml.XmlTextReader(stream))
                {
                    var HighlightDef = ICSharpCode.AvalonEdit.Highlighting.Xshd.HighlightingLoader.Load(reader,
                        ICSharpCode.AvalonEdit.Highlighting.HighlightingManager.Instance);
                    SQLcode.SyntaxHighlighting = HighlightDef;
                    SQLcode1.SyntaxHighlighting = HighlightDef;
                    SQLcode2.SyntaxHighlighting = HighlightDef;
                }
            }

        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void ComboBox_Selected_DepartmentSelector(object sender, SelectionChangedEventArgs e) // ебаное говно блять
        {
            vm.DepartmentSelectorVM.Clear();
            var bindedFaculty = db.faculties.Where(x => x.Name == FacultySelector.SelectedItem as string).Select(x => x).FirstOrDefault();
            var departments = db.departments.Where(x => x.FacultyId == bindedFaculty!.Id).Select(x => x.Name).ToList();
            foreach ( var department in departments )
            {
                vm.DepartmentSelectorVM.Add(department);
            }
            DepartmentSelector.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FacultySelector.SelectedItem != null && DepartmentSelector.SelectedItem != null && DateSelector.SelectedDate != null && DateSelector1.SelectedDate != null)
            {
                var date = DateSelector.SelectedDate.Value;
                var date1 = DateSelector1.SelectedDate.Value;
                departmentName = DepartmentSelector.SelectedItem.ToString();
                facultyName = FacultySelector.SelectedItem.ToString();
                fromBetween = new DateOnly(date.Year,date.Month,date.Day);
                toBetween = new DateOnly(date1.Year, date1.Month, date1.Day);


                SQLcode2.Text = $"SELECT\r\n\tdprts.\"Name\" AS \"Кафедра\",\r" +
                    "\n\tfclties.\"Name\" AS \"Факультет\",\r" +
                    "\n\ttch.\"Surname\" AS \"Фамилия\",\r" +
                    "\n\ttch.\"Name\" AS \"Имя\",\r" +
                    "\n\ttch.\"LastName\" AS \"Отчество\",\r" +
                    "\n\tdgrs.\"DegreeType\" AS \"Ученая степень\",\r" +
                    "\n\tdgrs.\"YearOfAward\" AS \"Дата награждения степенью\",\r" +
                    "\n\tdscpl.\"DisciplineType\" AS \"Наука\",\r" +
                    "\n\r\nFROM teachers AS tch\r" +
                    "\n\r\nLEFT JOIN\r" +
                    "\n\t\"departments\" dprts ON tch.\"DepartmentId\" = dprts.\"Id\"\r" +
                    "\nLEFT JOIN \r" +
                    "\n\t\"faculties\" fclties ON dprts.\"FacultyId\" = fclties.\"Id\"\r" +
                    "\nLEFT JOIN\r" +
                    "\n\t\"degrees\" dgrs ON tch.\"DegreeId\" = dgrs.\"Id\"\r" +
                    "\nLEFT JOIN \r" +
                    "\n\t\"disciplines\" dscpl ON dgrs.\"DisciplineId\" = dscpl.\"Id\"\r\n\t\r" +
                    $"\nWHERE dprts.\"Name\" = '{departmentName}'\r" +
                    $"\nAND fclties.\"Name\" = '{facultyName}'\r" +
                    $"\nAND dgrs.\"YearOfAward\" BETWEEN '{fromBetween}' AND '{toBetween}'\r\nORDER BY tch.\"Surname\"";

                var thirdQuerry = db.teachers.Select(x => new
                {
                    DepartmentShortName = x.Department.Name,
                    FacultyShortName = x.Department!.Faculty!.Name,
                    Surname = x.Surname,
                    Name = x.Name,
                    LastName = x.LastName,
                    DegreeType = x.Degree.DegreeType,
                    DegreeTypeYearOfAward = x.Degree.YearOfAward,
                    DisciplineType = x.Degree.Discipline.DisciplineType,
                }).Where(x => x.DepartmentShortName == departmentName && x.FacultyShortName == facultyName && x.DegreeTypeYearOfAward >= fromBetween && x.DegreeTypeYearOfAward <= toBetween)
                .ToList();
                TeachersGrid2.ItemsSource = thirdQuerry;
                DateSelector.BlackoutDates.Clear();
                DateSelector1.BlackoutDates.Clear();
            } else
            {
                MessageBox.Show("Один из аргументов не был указан", "Ошибка", MessageBoxButton.OK);
            }

        }
        public void LoadContent()
        {
            SQLcode.Text = "SELECT\r" +
    "\n\t\"Учителя\".\"Surname\" AS \"Фамилия\",\r" +
    "\n\t\"Учителя\".\"Name\" AS \"Имя\",\r\n\t\"Учителя\".\"LastName\" AS \"Отчество\",\r" +
    "\n\tjb.\"JobTitlesType\" AS \"Должность\",\r" +
    "\n\tIP.\"plannedForFallSemestre\" + IP.\"plannedForSpringSemestre\" AS \"Итоговая сумма запланированных часов\",\r" +
    "\n\tIP.\"factForFallSemestre\" + IP.\"factForSpringSemestre\" AS \"Итоговая сумма фактических часов\"\r" +
    "\n\t\r\nFROM \"teachers\" AS \"Учителя\"\r\n\r\nLEFT JOIN\r\n\t\"jobTitles\" jb ON \"Учителя\".\"JobTitleId\" = jb.\"Id\"\r\nLEFT JOIN\r" +
    "\n\t\"individualPlans\" IP ON IP.\"teacherId\" = \"Учителя\".\"Id\"\r\nORDER BY \"Учителя\".\"Surname\"";
            var firstQuerry = db.individualPlans.Select(x => new
            {
                Surname = x.teacher.Surname,
                Name = x.teacher.Name,
                LastName = x.teacher.LastName,
                JobTitlesType = x.teacher.JobTitle.JobTitlesType,
                IP1 = x.plannedForFallSemestre + x.plannedForSpringSemestre,
                IP2 = x.factForFallSemestre + x.factForSpringSemestre
            }).OrderBy(x => x.Surname).ToList();
            TeachersGrid.ItemsSource = firstQuerry;

            SQLcode1.Text = "SELECT\r" +
                "\n\tdprts.\"ShortName\" AS \"Кафедра\",\r" +
                "\n\tfclties.\"ShortName\" AS \"Факультет\",\r" +
                "\n\ttch.\"Surname\" AS \"Фамилия\",\r" +
                "\n\ttch.\"Name\" AS \"Имя\",\r\n\ttch.\"LastName\" AS \"Отчество\",\r" +
                "\n\tdgrs.\"DegreeType\" AS \"Ученая степень\",\r" +
                "\n\tdgrs.\"YearOfAward\" AS \"Дата награждения степенью\",\r" +
                "\n\tdscpl.\"DisciplineType\" AS \"Наука\",\r" +
                "\n\tacr.\"AcademicRankType\" AS \"Ученое звание\",\r" +
                "\n\tacr.\"YearOfAward\" AS \"Дата награждения званием\",\r" +
                "\n\tjb.\"JobTitlesType\" AS \"Должность\",\r" +
                "\n\tyrs.\"startOfYear\" AS \"Начало семестра\",\r" +
                "\n\tyrs.\"endOfYear\" AS \"Конец семестра\",\r" +
                "\n\t(IP.\"factForFallSemestre\" + IP.\"factForSpringSemestre\") -(IP.\"plannedForFallSemestre\" + IP.\"plannedForSpringSemestre\") AS \"Кол-во перевыполненных часов\"\r" +
                "\nFROM teachers AS tch\r" +
                "\n\r\nLEFT JOIN\r" +
                "\n\t\"departments\" dprts ON tch.\"DepartmentId\" = dprts.\"Id\"\r" +
                "\nLEFT JOIN \r" +
                "\n\t\"faculties\" fclties ON dprts.\"FacultyId\" = fclties.\"Id\"\r" +
                "\nLEFT JOIN\r\n\t\"jobTitles\" jb ON tch.\"JobTitleId\" = jb.\"Id\"\r\nLEFT JOIN\r" +
                "\n\t\"degrees\" dgrs ON tch.\"DegreeId\" = dgrs.\"Id\"\r\nLEFT JOIN \r" +
                "\n\t\"disciplines\" dscpl ON dgrs.\"DisciplineId\" = dscpl.\"Id\"\r\nLEFT JOIN\r" +
                "\n\t\"academicRanks\" acr ON tch.\"AcademicRankId\" = acr.\"Id\"\r\nLEFT JOIN\r" +
                "\n\t\"individualPlans\" IP ON IP.\"teacherId\" = tch.\"Id\"\r\nLEFT JOIN\r" +
                "\n\t\"Years\" yrs ON IP.\"YearId\" = yrs.\"Id\"\r" +
                "\n\r\nWHERE IP.\"plannedForFallSemestre\" + IP.\"plannedForSpringSemestre\" < IP.\"factForFallSemestre\" + IP.\"factForSpringSemestre\"\r" +
                "\nORDER BY tch.\"Surname\"";

            var secondQuerry = db.individualPlans.Select(x => new
            {
                DepartmentShortName = x.teacher.Department.ShortName,
                FacultyShortName = x.teacher.Department.Faculty.ShortName,
                Surname = x.teacher.Surname,
                Name = x.teacher.Name,
                LastName = x.teacher.LastName,
                DegreeType = x.teacher.Degree.DegreeType,
                DegreeTypeYearOfAward = x.teacher.Degree.YearOfAward,
                DisciplineType = x.teacher.Degree.Discipline.DisciplineType,
                AcademicRankType = x.teacher.AcademicRank.AcademicRankType,
                AcademicRankTypeYearOfAward = x.teacher.AcademicRank.YearOfAward,
                JobTitle = x.teacher.JobTitle.JobTitlesType,
                startOfYear = x.Year.startOfYear,
                endOfYear = x.Year.endOfYear,
                IP = x.plannedForFallSemestre + x.plannedForSpringSemestre,
                IP1 = x.factForFallSemestre + x.factForSpringSemestre,
                res = (x.factForFallSemestre + x.factForSpringSemestre) - (x.plannedForFallSemestre + x.plannedForSpringSemestre)
            }).Where(x => x.IP < x.IP1).ToList();
            TeachersGrid1.ItemsSource = secondQuerry;

            SQLcode2.Text = $"SELECT\r\n\tdprts.\"Name\" AS \"Кафедра\",\r" +
                "\n\tfclties.\"Name\" AS \"Факультет\",\r" +
                "\n\ttch.\"Surname\" AS \"Фамилия\",\r" +
                "\n\ttch.\"Name\" AS \"Имя\",\r" +
                "\n\ttch.\"LastName\" AS \"Отчество\",\r" +
                "\n\tdgrs.\"DegreeType\" AS \"Ученая степень\",\r" +
                "\n\tdgrs.\"YearOfAward\" AS \"Дата награждения степенью\",\r" +
                "\n\tdscpl.\"DisciplineType\" AS \"Наука\",\r" +
                "\n\r\nFROM teachers AS tch\r" +
                "\n\r\nLEFT JOIN\r" +
                "\n\t\"departments\" dprts ON tch.\"DepartmentId\" = dprts.\"Id\"\r" +
                "\nLEFT JOIN \r" +
                "\n\t\"faculties\" fclties ON dprts.\"FacultyId\" = fclties.\"Id\"\r" +
                "\nLEFT JOIN\r" +
                "\n\t\"degrees\" dgrs ON tch.\"DegreeId\" = dgrs.\"Id\"\r" +
                "\nLEFT JOIN \r" +
                "\n\t\"disciplines\" dscpl ON dgrs.\"DisciplineId\" = dscpl.\"Id\"\r\n\t\r" +
                $"\nWHERE dprts.\"Name\" = '{departmentName}'\r" +
                $"\nAND fclties.\"Name\" = '{facultyName}'\r" +
                $"\nAND dgrs.\"YearOfAward\" BETWEEN '{fromBetween}' AND '{toBetween}'\r\nORDER BY tch.\"Surname\"";
        }

        private void DateSelector_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateSelector1.BlackoutDates.Clear();
            DateTime d2 = DateTime.MinValue;
            int totalDays = (int)(DateSelector.SelectedDate.Value - d2).TotalDays;
            List<DateTime> startFrom = new List<DateTime>() { DateSelector.SelectedDate.Value };
            var res = startFrom.SelectMany(x => Enumerable.Range(0, totalDays).Select(d => x.AddDays(-1*d)));
            CalendarDateRange dr = new();
            dr.Start = res.Last();
            dr.End = res.First();
            DateSelector1.BlackoutDates.Add(dr);
        }

        private void DateSelector1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateSelector.BlackoutDates.Clear();
            DateTime d1 = DateTime.MaxValue;
            int totalDays = (int)(d1 - DateSelector1.SelectedDate.Value).TotalDays;
            List<DateTime> startFrom = new List<DateTime>() { DateSelector1.SelectedDate.Value };
            var res = startFrom.SelectMany(x => Enumerable.Range(0, totalDays-20000).Select(d => x.AddDays(d)));
            CalendarDateRange dr = new();
            dr.Start = res.First();
            dr.End = res.Last();
            DateSelector.BlackoutDates.Add(dr);
        }
    }
}
