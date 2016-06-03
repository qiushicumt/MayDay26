using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ContosoUniversityDemo.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversityDemo.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolContext") { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        /*
        /// <summary>
        /// OnModelCreating方法中的modelBuilder.Convertions.Remove被用来防止生成复数表名
        /// </summary>
        /// <param name="modelBuilder">DbModelBuilder类型参数</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Instructors)
                .WithMany(i => i.Courses)
                .Map(t => t.MapLeftKey("CourseID")
                .MapRightKey("InstructorID")
                .ToTable("CourseInstructor"));
        }
    }
}