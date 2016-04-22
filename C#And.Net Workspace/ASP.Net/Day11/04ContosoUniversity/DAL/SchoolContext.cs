using _04ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace _04ContosoUniversity.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolContext") { }      //base("SchoolContext")引号中的字符串为数据库连接字符串
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();      //OnModelCreating方法中的modelBuilder.Convertions.Remove被用来防止生成的表名为复数形式
        }

    }
}