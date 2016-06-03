using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversityDemo.DAL;
using ContosoUniversityDemo.Models;
using System.Data.Entity.Infrastructure;

namespace ContosoUniversityDemo.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext dbContext = new SchoolContext();

        /// <summary>
        /// PopulateDepartmentsDropDownList方法获取所有的系列表并按照名称进行排序来创建一个下拉列表。并通过ViewBag属性传递到视图上
        /// </summary>
        /// <param name="selectedDepartment"></param>
        private void PopulateDepartmentDropdownList(object selectedDepartment = null)
        {
            var departmentQuery = from d in dbContext.Departments orderby d.Name select d;
            ViewBag.DepartmentID = new SelectList(departmentQuery, "DepartmentID", "Name", selectedDepartment);
        }

        public ActionResult Index()
        {
            //  var courses = dbContext.Courses.ToList();
            var courses = dbContext.Courses.Include(c => c.Department);
            return View(courses.ToList());
        }

        public ActionResult Create()
        {
            PopulateDepartmentDropdownList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CourseID, Title, Credits, DepartmentID")]Course course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Courses.Add(course);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(RetryLimitExceededException)
            {
                ModelState.AddModelError("", "保存数据出现错误!");
            }
            PopulateDepartmentDropdownList();
            return View(course);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int CourseID = (int)id;
            var course = dbContext.Courses.Find(CourseID);
            if (course == null)
            {
                return new HttpNotFoundResult();
            }
            PopulateDepartmentDropdownList();
            ViewBag.DepartmentString = course.Department.Name;
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseID, Title, Credits, DepartmentID")]Course course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Entry(course).State = EntityState.Modified;
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(DataException)
            {
                ModelState.AddModelError("", "保存数据出现错误!");
            }
            PopulateDepartmentDropdownList();
            ViewBag.DepartmentString = course.Department.Name;
            return View(course);
        }


        public ActionResult Detail(int )
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
	}
}