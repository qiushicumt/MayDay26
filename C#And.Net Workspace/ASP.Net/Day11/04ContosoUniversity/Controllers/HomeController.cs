using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _04ContosoUniversity.DAL;
using _04ContosoUniversity.ViewModels;

namespace _04ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext _dbContext = new SchoolContext();

        public ActionResult Index()
        {
            return View();
        }

        #region 带排序功能的数据显示

        public ActionResult About(string sortOrder)
        {
            ViewBag.countSort = string.IsNullOrEmpty(sortOrder) ? "count" : "";
            ViewBag.dateSort = sortOrder == "date" ? "des_date" : "date";
            IQueryable<EnrollmentDataGroup> studentData = from s in _dbContext.Students 
                                                          group s by s.EnrollmentDate 
                                                          into dataGroup select new EnrollmentDataGroup() 
                                                          { 
                                                              EnrollmentDate = dataGroup.Key,
                                                              StudentCount = dataGroup.Count()
                                                          };
            switch (sortOrder)
            {
                case "count":
                    studentData = studentData.OrderByDescending(s => s.StudentCount);
                    break;
                    
                case "des_date":
                    studentData = studentData.OrderByDescending(s => s.EnrollmentDate);
                    break;
                case "date":
                    studentData = studentData.OrderBy(s => s.EnrollmentDate);
                    break;
                default:
                    studentData = studentData.OrderBy(s => s.StudentCount);
                    break;
            }
            return View(studentData.ToList());
        }

        #endregion

        #region 普通数据显示
        /*
        public ActionResult About()
        {
            IQueryable<EnrollmentDataGroup> data = from s in _dbContext.Students
                                                   group s by s.EnrollmentDate into dataGroup
                                                   select new EnrollmentDataGroup()
                                                   {
                                                       EnrollmentDate = dataGroup.Key,
                                                       StudentCount = dataGroup.Count()
                                                   };
            return View(data.ToList());
        }
        */
        #endregion

        /// <summary>
        /// 释放数据上下文
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
            base.Dispose(disposing);
        }
	}
}