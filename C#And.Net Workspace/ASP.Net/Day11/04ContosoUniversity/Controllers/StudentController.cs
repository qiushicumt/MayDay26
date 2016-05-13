using _04ContosoUniversity.Models;
using _04ContosoUniversity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data;
using System.Data.Entity;
using PagedList;

namespace _04ContosoUniversity.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _dbContext = new SchoolContext();

        #region 一般的Students索引展示
        /*
        public ActionResult Index()
        {
            return View(_dbContext.Students.ToList());
        }
        */
        #endregion

        #region 带排序功能的Students索引展示
        /*
        public ActionResult Index(string sortorder)
        {
            ViewBag.NameOrder = String.IsNullOrEmpty(sortorder) ? "des_name" : "";
            ViewBag.DateOrder = sortorder == "date" ? "des_date" : "date";
            var students = from s in _dbContext.Students select s;
            //根据sortorder的不同情况对students进行排序
            switch (sortorder)
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
            return View(students);
        }
        */ 
        #endregion

        #region 带查询、排序功能的Students索引展示
        /*
        public ActionResult Index(string sortorder, string search_str)
        {
            ViewBag.NameOrder = String.IsNullOrEmpty(sortorder) ? "des_name" : "";
            ViewBag.DateOrder = sortorder == "date" ? "des_date" : "date";
            var students = from s in _dbContext.Students select s;
            if (!String.IsNullOrEmpty(search_str))
            {
                students = students.Where(s => s.LastName.ToUpper().Contains(search_str.ToUpper()) || s.FirstMidName.ToUpper().Contains(search_str.ToUpper()));
            }
            switch (sortorder)
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

        #region 带查询、分页、排序功能的Students索引展示
        /// <summary>
        /// Students索引展示
        /// </summary>
        /// <param name="sortorder">排序参数</param>
        /// <param name="search_str">查询参数</param>
        /// <param name="currentFilter">当前搜索条件</param>
        /// <param name="page">传递的page参数</param>
        /// <returns></returns>
        public ActionResult Index(string sortorder, string search_str, string currentFilter, int? page)
        {
            ViewBag.NameSort = string.IsNullOrEmpty(sortorder) ? "des_name" : "";
            ViewBag.DateSort = sortorder == "date" ? "des_date" : "date";
            ViewBag.currentSort = sortorder;
            if (search_str != null)
            {
                page = 1;
            }
            else
            {
                search_str = currentFilter;
            }
            ViewBag.currentFilter = search_str;

            var students = from s in _dbContext.Students select s;
            if (!string.IsNullOrEmpty(search_str))
            {
                students = students.Where(s => s.LastName.ToUpper().Contains(search_str.ToUpper()) || s.FirstMidName.ToUpper().Contains(search_str.ToUpper()));
            }
            switch (sortorder)
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
            int pageNumber = (page ?? 1);
            return View(students.ToPagedList(pageNumber, pageSize));
        }
        #endregion

        #region 创建一条Student信息
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="LastName, FirstMidName, EnrollmentDate")]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dbContext.Students.Add(student);
                    _dbContext.SaveChanges();
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

        #region Student信息的详细展示
        public ActionResult Detail(int? id)      //  int?表示可为空的整型
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int StudentId = (int)id;
            Student student = _dbContext.Students.Find(StudentId);      //  上下文.Find()，查找id对应的student对象
            if (student == null)
            {
                return new HttpNotFoundResult();
            }
            return View(student);
        }
        #endregion

        #region Edit Students数据
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int StudentId = (int)id;
            Student theStudent = _dbContext.Students.Find(StudentId);
            if (theStudent == null)
            {
                return new HttpNotFoundResult();
            }
            return View(theStudent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,LastName,FirstMidName,EnrollmentDate")]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dbContext.Entry(student).State = EntityState.Modified;
                    _dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "数据错误，无法保存");
            }
            return View(student);
        }
        #endregion

        #region Delete Students数据
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            int StudentId = (int)id;
            Student theStudent = _dbContext.Students.Find(StudentId);
            if (theStudent == null)
            {
                return new HttpNotFoundResult();
            }
            _dbContext.Students.Remove(theStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
        
        //销毁上下文，释放数据库的连接
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
	}
}