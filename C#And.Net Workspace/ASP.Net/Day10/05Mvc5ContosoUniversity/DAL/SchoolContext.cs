using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _05Mvc5ContosoUniversity.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace _05Mvc5ContosoUniversity.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolContext") { }      // 传递给构造函数的连接字符串。若不指定连接字符串，实体框架假定连接字符串的名称与类名称相同。 
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}