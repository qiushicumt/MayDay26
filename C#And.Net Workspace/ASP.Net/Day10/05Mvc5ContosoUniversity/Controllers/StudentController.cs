using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _05Mvc5ContosoUniversity.DAL;
using _05Mvc5ContosoUniversity.Models;
using System.Data.Entity;
using System.Net;

namespace _05Mvc5ContosoUniversity.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _dbContext = new SchoolContext();

        public ActionResult Index()
        {
            var students = _dbContext.Students.ToList();
            return View(students);
        }

        #region 创建学生信息
        public ActionResult Create()
        {
            return View();
        }
        
        /*
        [HttpPost]
        public ActionResult Create(Student student)
        {
            Student newStudent = student;
            newStudent.EnrollmentDate = DateTime.Now;
            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {

            return RedirectToAction("Index");
        }
        #endregion

        #region 编辑学生信息
        public ActionResult Edit(int Id)
        {
            var student = _dbContext.Students.Find(Id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            //调用dbContext.Entry()方法，传入获得的实体student，将EntityState.Modified赋值给dbContext.Entry(Entity实体).State
            //即，将实体中的改变的数据传递给实体上下文。然后将上下文保存
            _dbContext.Entry(student).State = EntityState.Modified;         
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion

        #region 显示学生信息详情
        public ActionResult Detail(int Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student theStudent = _dbContext.Students.Find(Id);
            if (theStudent == null)
            {
                return HttpNotFound();
            }
            return View(theStudent);
        }
        #endregion

        #region 删除学生信息
        public ActionResult Delete(int Id)
        {
            Student student = _dbContext.Students.Find(Id);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
    }
}