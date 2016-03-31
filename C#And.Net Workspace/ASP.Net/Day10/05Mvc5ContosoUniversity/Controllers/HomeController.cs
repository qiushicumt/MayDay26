using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _05Mvc5ContosoUniversity.Models;
using _05Mvc5ContosoUniversity.DAL;
using _05Mvc5ContosoUniversity.Viewmodel;

namespace _05Mvc5ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext _dbSchoolContext = new SchoolContext();
        public ActionResult Index()
        {

            var aa = from s in _dbSchoolContext.Departments select s;
            return View();
        }

        public ActionResult About()
        {
            IQueryable<EnrollmentDateGroup> data = from s in _dbSchoolContext.Students group s by s.EnrollmentDate into dateGroup select new EnrollmentDateGroup() { EnrollmentDate = dateGroup.Key, StudentCount = dateGroup.Count() };
            return View(data.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// 释放数据库的连接
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            _dbSchoolContext.Dispose();
            base.Dispose(disposing);
        }
	}
}