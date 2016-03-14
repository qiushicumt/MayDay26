using _03MVC4MovieDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movies);
                _db.SaveChanges();
                //return RedirectToAction("Index", movies);
                return RedirectToAction("Index");
            }
            else
            {
                return View(movies);
            }
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
            #region 修改实体属性的方式
            /*           	 
            if (ModelState.IsValid)
            {
                int movieId = movie.Id;
                Movie myMovie = _db.Movies.Find(movieId);
                //实体的修改是将相应的实体的属性进行修改，然后直接调用_db.SaveChanges()方法，Entity会检测到实体的属性发生了变化，然后保存
                myMovie.Name = movie.Name;
                myMovie.ReleaseTime = movie.ReleaseTime;
                myMovie.Genre = movie.Genre;
                myMovie.Price = movie.Price;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }
             * */
            #endregion

            #region 通过获取指定实体的状态改变来改变数据
            if (ModelState.IsValid)
            {
                _db.Entry(movie).State = EntityState.Modified;          //_db.Entry(entity)方法传入指定的实体，获取实体的状态信息
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }
            #endregion
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

        public ActionResult SearchIndex(string searchString)
        {
            var movies = from m in _db.Movies select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.Name.Contains(searchString));
            }

            return View(movies);
        }

        /*
        public ActionResult SearchIndex(string searchString, string Genre)
        {
            
            var GenreLst = new List<string>();
            var GenreQry = from d in _db.Movies orderby d.Genre select d.Genre;
            GenreLst.AddRange(GenreQry);
            ViewBag.MovieGenre = new SelectList(GenreLst);

            var movies = from m in _db.Movies select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.Name.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(Genre))
            {
                movies = 
            }
            return View(movies);
        }
         * */
    }
}
