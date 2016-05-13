using _04ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Migrations;

/*
当运行程序时，实体框架可以自动创建(或自动删除并重新创建)数据表。可以指定这应该在每次程序运行时进行或仅当模型发生了变化而不与现有的数据库同步时才进行。也可以写一个Seed方法，以便在数据库初始化后自动填充测试数据到新的数据表中。
默认的行为是只有当该数据库不存在时才创建(当数据库已经存在时会抛出一个异常)。在本节中将指定在每次模型发生变化时都删除旧数据库并建立一个新的。在本例中这样做是适当的。Seed方法将在重新创建后自动填充测试数据。而在生产中通常不希望这样做从而丢失数据库中的所有数据。
 */
namespace _04ContosoUniversity.DAL
{
    public class SchoolInitializer:DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student> 
            { 
                new Student{ FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") },
                new Student{ FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student{ FirstMidName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2003-09-01") },
                new Student{ FirstMidName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student{ FirstMidName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student{ FirstMidName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2001-09-01") },
                new Student{ FirstMidName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2003-09-01") },
                new Student{ FirstMidName = "NinoNo", LastName = "Olivetto", EnrollmentDate = DateTime.Parse("2005-09-02") },
            };
            // students.ForEach(s => context.Students.Add(s));
            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var instructors = new List<Instructor>
            {
                new Instructor { FirstName = "Kim", LastName = "Abercrombie", HireTime = DateTime.Parse("1995-03-11") },
                new Instructor { FirstName = "Fadi", LastName = "Fakhouri", HireTime = DateTime.Parse("2002-07-06") },
                new Instructor { FirstName = "Roger", LastName = "Harui", HireTime = DateTime.Parse("1998-07-01") },
                new Instructor { FirstName = "Candace", LastName = "Kapoor", HireTime = DateTime.Parse("2001-01-15") },
                new Instructor { FirstName = "Roger", LastName = "Zheng", HireTime = DateTime.Parse("2004-02-12") }
            };
            // instructors.ForEach(i => context.Instructors.Add(i));
            instructors.ForEach(s => context.Instructors.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { Name = "English", Budget = 350000, StartDate = DateTime.Parse("2007-09-01"), InstructorID = instructors.Single(i => i.LastName == "Abercrombie").InstructorID },
                new Department { Name = "Mathematics", Budget = 100000, StartDate = DateTime.Parse("2007-09-01"), InstructorID = instructors.Single(i => i.LastName == "Fakhouri").InstructorID },
                new Department { Name = "Engineering", Budget = 350000, StartDate = DateTime.Parse("2007-09-01"), InstructorID = instructors.Single(i => i.LastName == "Harui").InstructorID },
                new Department { Name = "Economics", Budget = 100000, StartDate = DateTime.Parse("2007-09-01"), InstructorID = instructors.Single(i => i.LastName == "Kapoor").InstructorID }
            };
            departments.ForEach(s => context.Departments.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
            /*
            var courses = new List<Course>
            {
                new Course{ CourseId = 1050 , Title = "Chemistry", Credits = 3 },
                new Course{ CourseId = 4022 , Title = "Microeconomics", Credits = 3 },
                new Course{ CourseId = 4041 , Title = "Macroeconomics", Credits = 4 },
                new Course{ CourseId = 3141 , Title = "Trigonometry", Credits = 4 },
                new Course{ CourseId = 2021 , Title = "Composition", Credits = 3 },
                new Course{ CourseId = 1045 , Title = "Calculus", Credits = 4 },
                new Course{ CourseId = 2042 , Title = "Literature", Credits = 3 },
            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();
            */

            var courses = new List<Course>
            {
                new Course { CourseId = 1050, Title = "Chemistry", Credits = 3, DepartmentID = departments.Single(s => s.Name == "Engineering").DepartmentID, Instructors = new List<Instructor>() },
                new Course { CourseId = 4022, Title = "Microeconomics", Credits = 3, DepartmentID = departments.Single(s => s.Name == "Economics").DepartmentID, Instructors = new List<Instructor>() },
                new Course { CourseId = 4041, Title = "Microeconomics", Credits = 3, DepartmentID = departments.Single(s => s.Name == "Economics").DepartmentID, Instructors = new List<Instructor>() },
                new Course { CourseId = 1045, Title = "Calculus", Credits = 4, DepartmentID = departments.Single(s => s.Name == "Mathematics").DepartmentID, Instructors = new List<Instructor>() },
                new Course { CourseId = 3141, Title = "Trigonometry", Credits = 4, DepartmentID = departments.Single(s => s.Name == "Mathematics").DepartmentID, Instructors = new List<Instructor>() },
                new Course { CourseId = 2021, Title = "Composition", Credits = 3, DepartmentID = departments.Single(s => s.Name == "English").DepartmentID, Instructors = new List<Instructor>() },
                new Course { CourseId = 2042, Title = "Literature", Credits = 4, DepartmentID = departments.Single(s => s.Name == "English").DepartmentID, Instructors = new List<Instructor>() }
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.CourseId, s));
            context.SaveChanges();

            var officeAssignments = new List<OfficeAssignment>
            {
                new OfficeAssignment { InstructorID = instructors.Single(i => i.LastName == "Fakhouri").InstructorID, Location = "Smith 17" },
                new OfficeAssignment { InstructorID = instructors.Single(i => i.LastName == "Harui").InstructorID, Location = "Gowan 27" },
                new OfficeAssignment { InstructorID = instructors.Single(i => i.LastName == "Kapoor").InstructorID, Location = "Thompson 304" }
            };
            officeAssignments.ForEach(s => context.OfficeAssignments.AddOrUpdate(p => p.InstructorID, s));
            context.SaveChanges();

            

            var enrollments = new List<Enrollment>
            {
                new Enrollment{ StudentId = 1, CourseId = 1050, Grade = Grade.B },
                new Enrollment{ StudentId = 1, CourseId = 4022, Grade = Grade.A },
                new Enrollment{ StudentId = 1, CourseId = 4041, Grade = Grade.C },
                new Enrollment{ StudentId = 2, CourseId = 1045, Grade = Grade.B },
                new Enrollment{ StudentId = 2, CourseId = 3141, Grade = Grade.F },
                new Enrollment{ StudentId = 2, CourseId = 2021, Grade = Grade.F },
                new Enrollment{ StudentId = 3, CourseId = 1050 },
                new Enrollment{ StudentId = 4, CourseId = 1050 },
                new Enrollment{ StudentId = 4, CourseId = 4022, Grade = Grade.F },
                new Enrollment{ StudentId = 5, CourseId = 4041, Grade = Grade.C },
                new Enrollment{ StudentId = 6, CourseId = 1045 },
                new Enrollment{ StudentId = 7, CourseId = 3141, Grade = Grade.A },
            };
            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }


        protected void AddOrUpdateInstructor(SchoolContext context, string courseTitle, string instructorName)
        {
            var crs = context.Courses.SingleOrDefault(c => c.Title == courseTitle);
            var inst = context.Instructors.SingleOrDefault(i => i.LastName == instructorName);
            if (inst == null)
            {
                crs.Instructors.Add(context.Instructors.Single(i => i.LastName == instructorName));
            }
        }


        /* Seed方法将数据库的上下文对象作为输入参数，并在方法中的代码使用该上下文对象将新的实体添加到数据库中。
         * 对于每个实体模型，代码创建新的实体集合添加他们到相应的DbSet属性，然后将更改保存到数据库。
         * 它并不是必须在每组实体后立即调用SaveChanges方法
         */
    }
}