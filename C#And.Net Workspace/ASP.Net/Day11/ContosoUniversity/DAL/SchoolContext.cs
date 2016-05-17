using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolContext") { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// OnModelCreating方法中的modelBuilder.Convertions.Remove被用来防止生成复数表名
        /// </summary>
        /// <param name="modelBuilder">DbModelBuilder类型参数</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}