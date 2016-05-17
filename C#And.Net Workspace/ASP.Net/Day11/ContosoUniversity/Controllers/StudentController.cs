using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using System.Data;
using System.Net;

namespace ContosoUniversity.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext dbContext = new SchoolContext();

        public ActionResult Index()
        {
            var students = dbContext.Students.ToList();
            return View(students);
        }

        #region Create A New Student

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
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
        public ActionResult Edit(Student student)
        {
            return View();
        }

        #endregion

        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
	}
}