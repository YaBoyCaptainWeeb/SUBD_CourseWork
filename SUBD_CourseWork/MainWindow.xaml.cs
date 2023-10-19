using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            NpgsqlConnection.GlobalTypeMapper.MapEnum<CooperationType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<DisciplineType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<DegreeType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<AcademicRankType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<JobTitlesType>();
            
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CourseWorkDB;Username=postgres;Password=123;");
            optionsBuilder.LogTo(logStream.WriteLine, LogLevel.Information);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .Properties<DateTime>()
                .HaveConversion(typeof(UtcValueConverter));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.HasPostgresEnum<CooperationType>();
            modelBuilder.HasPostgresEnum<DisciplineType>();
            modelBuilder.HasPostgresEnum<DegreeType>();
            modelBuilder.HasPostgresEnum<AcademicRankType>();
            modelBuilder.HasPostgresEnum<JobTitlesType>();
            modelBuilder.UseIdentityColumns();

            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new TypeOfCooperationConfiguration());
            modelBuilder.ApplyConfiguration(new JobTitleConfiguration());
            modelBuilder.ApplyConfiguration(new DegreesConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new AcademicRankConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplinesConfiguration());
            modelBuilder.ApplyConfiguration(new ExperienceConfiguration());
            modelBuilder.ApplyConfiguration(new InstitutionConfiguration());
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());

        }
        public override void Dispose()
        {
            base.Dispose();
            logStream.Dispose();
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
    public partial class MainWindow : Window
    {
    ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();
            var d = db.teachers.Include(f => f.Faculty).Include(d => d.Department).Include(j => j.JobTitle).Include(t => t.TypeOfCooperation).Include(d => d.Degree).Include(a => a.AcademicRank).Include(i => i.Institution).ToList();
            TeachersGrid.ItemsSource = d;
            //var logStream = new StreamReader("C:\\Users\\User\\source\\repos\\SUBD_CourseWork\\SUBD_CourseWork\\bin\\Debug\\net6.0-windows\\logs.txt", UTF8Encoding.UTF8).ToString();
            //TestBlock.Text = high.Highlight("SQL", logStream);
        }
    }
}
