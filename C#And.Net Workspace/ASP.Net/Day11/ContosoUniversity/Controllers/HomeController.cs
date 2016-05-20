using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext dbContext = new SchoolContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var students = from s in dbContext.Students
                           group s by s.EnrollmentDate into dateGroup
                           select new EnrollmentDataGroup()
                           {
                               EnrollmentDate = dateGroup.Key,
                               StudentCount = dateGroup.Count()
                           };
            return View(students.ToList());
        }
	}
}