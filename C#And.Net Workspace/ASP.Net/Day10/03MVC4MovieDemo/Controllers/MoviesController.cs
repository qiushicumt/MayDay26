using _03MVC4MovieDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03MVC4MovieDemo.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/
        private MovieContext _db = new MovieContext();
        public ActionResult Index()
        {
            
            return View(_db.Movies.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movies)
        {
            _db.Movies.Add(movies);
            _db.SaveChanges();
            //return RedirectToAction("Index", movies);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id=0)
        {
            //_db.Movies.Find(id)在数据中查找id的数据。Find()方法用于查找给定主键值得实体并返回
            Movie myMovie = _db.Movies.Find(id);
            if (myMovie == null)
            {
                return Content("没有这条数据");
            }
            return View(myMovie);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id = 0)
        {
            Movie myMovie = _db.Movies.Find(id);
            if (myMovie == null)
            {
                return HttpNotFound();
            }
            return View(myMovie);
        }

        public ActionResult Delete(int id = 0)
        {
            Movie myMovie = _db.Movies.Find(id);
            if (myMovie == null)
            {
                return HttpNotFound();
            }
            _db.Movies.Remove(myMovie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
