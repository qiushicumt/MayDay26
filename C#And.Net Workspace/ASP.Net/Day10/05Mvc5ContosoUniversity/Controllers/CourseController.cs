using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _05Mvc5ContosoUniversity.Models;
using _05Mvc5ContosoUniversity.DAL;

namespace _05Mvc5ContosoUniversity.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext _dbSchoolContext = new SchoolContext();

        public ActionResult Index()
        {
            //var courses = _dbSchoolContext.Courses.Include(c => c.Department);
            var courses = _dbSchoolContext.Courses;
            //var a = from a in _dbSchoolContext.Courses
            return View(courses.ToList());
            //return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Course course)
        {
            return RedirectToAction("Index");
        }
	}
}