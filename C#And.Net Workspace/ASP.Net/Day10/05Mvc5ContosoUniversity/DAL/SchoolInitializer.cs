using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using _05Mvc5ContosoUniversity.Models;

namespace _05Mvc5ContosoUniversity.DAL
{
    public class SchoolInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        /// <summary>
        /// 添加数据到数据库中。在方法中创建3个实体对象的集合，将集合中的数据添加到上下文中每一个对象实体，然后保存数据库数据
        /// </summary>
        /// <param name="context">数据上下文对象</param>
        protected override void Seed(SchoolContext context)
        {
            #region 添加Students数据
            var students = new List<Student>
            {
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            #endregion

            #region 添加Courses数据
            var courses = new List<Course>
            {
                new Course{CourseId=1050,Title="Chemistry",Credits=3,},
                new Course{CourseId=4022,Title="Microeconomics",Credits=3,},
                new Course{CourseId=4041,Title="Macroeconomics",Credits=3,},
                new Course{CourseId=1045,Title="Calculus",Credits=4,},
                new Course{CourseId=3141,Title="Trigonometry",Credits=4,},
                new Course{CourseId=2021,Title="Composition",Credits=3,},
                new Course{CourseId=2042,Title="Literature",Credits=4,}
            };

            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();
            #endregion

            #region 添加enrollments数据
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentId=1,CourseId=1050,Grade=Grade.A},
                new Enrollment{StudentId=1,CourseId=4022,Grade=Grade.C},
                new Enrollment{StudentId=1,CourseId=4041,Grade=Grade.B},
                new Enrollment{StudentId=2,CourseId=1045,Grade=Grade.B},
                new Enrollment{StudentId=2,CourseId=3141,Grade=Grade.F},
                new Enrollment{StudentId=2,CourseId=2021,Grade=Grade.F},
                new Enrollment{StudentId=3,CourseId=1050},
                new Enrollment{StudentId=4,CourseId=1050,},
                new Enrollment{StudentId=4,CourseId=4022,Grade=Grade.F},
                new Enrollment{StudentId=5,CourseId=4041,Grade=Grade.C},
                new Enrollment{StudentId=6,CourseId=1045},
                new Enrollment{StudentId=7,CourseId=3141,Grade=Grade.A},
            };

            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
            #endregion
            
        }
    }
}