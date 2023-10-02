using System;
using System.Collections.Generic;
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
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using SUBD_CourseWork;
using SUBD_CourseWork.Entities;



namespace SUBD_CourseWork
{
    public class ApplicationContext : DbContext
    {
 
        public DbSet<teacher> teachers { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CourseWorkDB;Username=postgres;Password=123;");
        }
    }
    public partial class MainWindow : Window
    {
        ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();
            var users = db.teachers.ToList();
            foreach (var user in users)
            {
                TestBlock.Text += user.Name + " | " + user.Id + " | " + user.BirthDate + "\n";

            }
        }
    }
}
