using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Net;
using ContosoUniversityDemo.Models;
using ContosoUniversityDemo.DAL;
using ContosoUniversityDemo.ViewModels;

namespace ContosoUniversityDemo.Controllers
{
    //  1、延迟加载(Lazy Loading)。当实体第一次被读取时，相关数据不会被获取。但是，当第一次尝试存取导航属性时，该导航属性所需的数据会自动加载。
    //  结果会使用多个查询发送到数据库——一次是读取实体本身，然后是每个相关的实体。DbContext类默认是使用延迟加载的。

    //  2、预先加载(Eager Loading)。当实体读取时立即获取与该实体相关的数据。
    //  这通常会导致在单个连接查询中检索出所有所需要的数据。可以通过使用Include方法来指定预先加载。

    //  3、显式加载(Explicit Loading)。有点类似于延迟加载，只是你在代码中显式地获取相关数据。您访问一个导航属性时，它不会自动加载。
    //  需要通过使用实体的对象状态管理器并调用集合上的Collection.Load方法或通过持有单个实体的属性的Reference.Load方法来手动加载相关数据。

    public class InstructorController : Controller
    {
        private SchoolContext dbContext = new SchoolContext();

        //  代码首先创建视图模型的实例并将讲师列表放进模型中，该代码指定在OfficeAssignment和Courses导航属性上使用预先加载。
        //  第二个Include方法加载课程，并且为每个课程预先加载Department导航属性。
        public ActionResult Index(int? id, int? courseID)
        {
            var viewmodel = new InstructorIndexData();
            viewmodel.Instructors = dbContext.Instructors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.Courses.Select(c => c.Department))
                .OrderBy(i => i.LastName);
            if (id != null)
            {
                ViewBag.InstructorID = id.Value;
                viewmodel.Courses = viewmodel.Instructors.Where(i => i.InstructorID == id.Value).Single().Courses;
            }
            if (courseID != null)
            {
                ViewBag.CourseID = courseID.Value;
                //  延迟加载
                //  viewmodel.Enrollments = viewmodel.Courses.Where(c => c.CourseID == courseID.Value).Single().Enrollments;
              
                //  显式加载
                var selectedCourse = viewmodel.Courses.Where(c => c.CourseID == courseID.Value).Single();
                dbContext.Entry(selectedCourse).Collection(x => x.Enrollments).Load();
                foreach (Enrollment enrollmentItem in selectedCourse.Enrollments)
                {
                    dbContext.Entry(enrollmentItem).Reference(x => x.Student).Load();
                }
                viewmodel.Enrollments = selectedCourse.Enrollments;
            }
            return View(viewmodel);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int InstructorID = (int)id;
            var instructor = dbContext.Instructors.Include(i => i.OfficeAssignment).Where(i => i.InstructorID == InstructorID).Single();
            if (instructor == null)
            {
                return HttpNotFound();
            }
            return View(instructor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind]Instructor instructor)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int? id)
        {
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int InstructorID = (int)id;
            var instructor = dbContext.Instructors.Find(InstructorID);
            if (instructor == null)
            {
                return HttpNotFound();
            }
            dbContext.Instructors.Remove(instructor);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        //  释放数据库上下文
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
	}
}