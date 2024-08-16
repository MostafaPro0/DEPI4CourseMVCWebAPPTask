using DEPI4CourseMVCWebAPPTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEPI4CourseMVCWebAPPTask;

namespace DEPI4CourseMVCWebAPPTask.Contexts
{
    public class CourseMVCAppDbContext:DbContext 
    {

        public CourseMVCAppDbContext()
        {

        }
        public CourseMVCAppDbContext(DbContextOptions<CourseMVCAppDbContext>options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB; Database=CourseMVCApp;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
