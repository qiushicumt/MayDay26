using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using System.Data;
using System.Data.Entity;
using PagedList;
using System.Net;

namespace ContosoUniversity.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext dbContext = new SchoolContext();

        public ActionResult Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "des_name" : "";
            ViewBag.DateSort = sortOrder == "date" ? "des_date" : "date";

            if(searchString != null)
            {
                page = 1;
            }
            else 
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var students = from s in dbContext.Students select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.LastName.ToUpper().Contains(searchString.ToUpper()) || s.FirstMidName.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "des_name":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "date":
                    students = students.OrderBy(s => s.EnrollmentDate);
                    break;
                case "des_date":
                    students = students.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }

            int pageSize = 4;
            int pageNum = (page ?? 1);
            return View(students.ToPagedList(pageNum, pageSize));
            //return View(students.ToPagedList());
        }

        #region 带排序和搜索功能的Student列表
        /*
        [HttpGet]
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "des_name" : "";
            ViewBag.DateSort = sortOrder == "date" ? "des_date" : "date";

            var students = from s in dbContext.Students select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.LastName.ToUpper().Contains(searchString.ToUpper()) || s.FirstMidName.ToUpper().Contains(searchString.ToUpper()));
            }
            switch(sortOrder)
            {
                case "des_name":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "date":
                    students = students.OrderBy(s => s.EnrollmentDate);
                    break;
                case "des_date":
                    students = students.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }
            return View(students.ToList());
        }
        */ 
        #endregion

        #region 带排序功能的Student列表
        /*
        public ActionResult Index(string sortOrder)
        {
            ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "des_name" : "";
            ViewBag.DateSort = sortOrder == "date" ? "des_date" : "date";

            var students = from s in dbContext.Students select s;
            switch (sortOrder)
            {
                case "des_name":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "date":
                    students = students.OrderBy(s => s.EnrollmentDate);
                    break;
                case "des_date":
                    students = students.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }

            return View(students.ToList());
        }
        */
        #endregion       

        #region Student ListIndex
        /*
        public ActionResult Index()
        {
            var students = dbContext.Students.ToList();
            return View(students);
        }
        */
        #endregion
        
        #region Create A New Student

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="LastName,FirstMidName,EnrollmentDate")]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Students.Add(student);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "保存数据时出现错误。请重试，如果问题依旧存在请联系系统管理员。");
            }
            return View(student);
        }

        #endregion

        #region Edit A Student

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int StudentID = (int)id;
            var student = dbContext.Students.Find(StudentID);
            if (student == null)
            {
                return new HttpNotFoundResult();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="StudentID,LastName,FirstMidName,EnrollmentDate")]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Entry(student).State = EntityState.Modified;
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(DataException)
            {
                ModelState.AddModelError("", "保存数据错误，请与管理员联系！");
            }
            return View(student);
        }

        #endregion

        #region Student Details

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int StudentID = (int)id;
            var student = dbContext.Students.Find(StudentID);
            if (student == null)
            {
                return new HttpNotFoundResult();
            }
            return View(student);
        }

        #endregion

        #region Delete Student

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int StudentID = (int)id;
            var student = dbContext.Students.Find(StudentID);
            if (student == null)
            {
                return new HttpNotFoundResult();
            }
            dbContext.Students.Remove(student);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion

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