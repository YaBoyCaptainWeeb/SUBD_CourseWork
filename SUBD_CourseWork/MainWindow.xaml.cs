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
using Microsoft.Extensions.Logging;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using SUBD_CourseWork;
using SUBD_CourseWork.Entities;



namespace SUBD_CourseWork
{
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
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CourseWorkDB;Username=postgres;Password=123;");
            optionsBuilder.LogTo(logStream.WriteLine, LogLevel.Information);
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
        }
    }
}
