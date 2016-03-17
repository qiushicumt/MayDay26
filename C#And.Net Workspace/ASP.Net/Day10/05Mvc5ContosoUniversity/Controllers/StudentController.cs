using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _05Mvc5ContosoUniversity.DAL;
using _05Mvc5ContosoUniversity.Models;
using System.Data.Entity;
using System.Net;
using System.Data;
using PagedList;

namespace _05Mvc5ContosoUniversity.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _dbContext = new SchoolContext();

        #region 学生信息列表展示
        /*
        //带有排序功能的Students列表展示Action，通过接收传递过来的sortOrder参数，判断是否进行排序以及按照何种规则进行排序
        public ActionResult Index(string sortOrder, string SearchString)
        {
            //  设置两个参数用于设置排序状态。
            //  NameSortParm参数初始值为"namc_desc"，DateSortParm参数初始值为"Date"，即当url中不传入sortOrder参数时，NameSortParma=name_desc，DateSortParm=Date
            //  此时，前台页面点击url后，相当于给本方法传入了sortOrder参数，当传入sortOrder参数后，方法立即将sortOrder参数的值，设置为相反的值
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            
            //  从数据上下文中查询students数据
            var students = from s in _dbContext.Students select s;

            //  根据查询条件对students结果进行筛选
            if (!String.IsNullOrEmpty(SearchString))
            {
                students = students.Where(s => s.LastName.Contains(SearchString) || s.FirstMidName.Contains(SearchString));
            }

            //  根据sortOrder参数，对students进行不同的种类的排序
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }

            return View(students.ToList());
        }
        */
        public ActionResult Index(string sortOrder, string currentFilter, string SearchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            if (SearchString != null)
            {
                page = 1;
            }
            else
            {
                SearchString = currentFilter;
            }
            ViewBag.CurrentFilter = SearchString;

            var students = from s in _dbContext.Students select s;

            if (!String.IsNullOrEmpty(SearchString))
            {
                students = students.Where(s => s.LastName.Contains(SearchString) || s.FirstMidName.Contains(SearchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }

            int pageSize = 3;
            int pageNum = (page ?? 1);

            return View(students.ToPagedList(pageNum, pageSize));
        }

        #endregion

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
        public ActionResult Create([Bind(Include="Id, LastName, FirstMidName")]Student student)     //Bind给实体绑定属性，Include属性表示允许绑定的属性，Include=属性字符串
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Student theStudent = student;
                    _dbContext.Students.Add(theStudent);
                    _dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(student);       //当出错时，返回Create页面
        }
        #endregion

        #region 编辑学生信息
        public ActionResult Edit(int Id)
        {
            var student = _dbContext.Students.Find(Id);
            return View(student);
        }

        /*
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            //调用dbContext.Entry()方法，传入获得的实体student，将EntityState.Modified赋值给dbContext.Entry(Entity实体).State
            //即，将实体中的改变的数据传递给实体上下文。然后将上下文保存
            _dbContext.Entry(student).State = EntityState.Modified;         
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        */
        [HttpPost, ActionName("Edit")]
        //[ValidateAntiForgeryToken]
        public ActionResult PostEdit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var studentUpdate = _dbContext.Students.Find(Id);

            if (TryUpdateModel(studentUpdate, new string[]{"LastName", "FirstMidName", "EnrollmentDate"}))
            {
                try
                {
                    _dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DataException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                }
            }

            return View(studentUpdate);
        }

        #endregion

        #region 显示学生信息详情
        public ActionResult Detail(int? Id)
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

        protected override void Dispose(bool disposing)
        {
            //db.Dispose();
            _dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}