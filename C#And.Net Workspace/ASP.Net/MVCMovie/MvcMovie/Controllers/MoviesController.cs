using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCMovie.Models;

namespace MVCMovie.Controllers
{
    public class MoviesController : Controller
    {
        //  生成一个Movie的数据库的实例，实例可用于对数据库进行查询、编辑、删除等操作
        private MovieDBContext db = new MovieDBContext();

        /*
        // GET: Movies
        public ActionResult Index(string searchStr)
        {
            //LINQ查询语句，查询包含searchStr的MovieName
            var movies = from m in db.Movies select m;
            if (!String.IsNullOrEmpty(searchStr))
            {
                movies = movies.Where(s => s.MovieName.Contains(searchStr));
            }
            
            return View(movies);    //  给index视图返回Movies数据的list形式
        }
        */

        public ActionResult Index(string movieGenre, string searchStr)
        {
            var GenreList = new List<string>();     //定义MovieGenre的list集合
            var GenreQry = from d in db.Movies orderby d.Genre select d.Genre;  // 从数据库中检索所有的Genre的LINQ查询
            GenreList.AddRange(GenreQry.Distinct());
            ViewBag.movieGenre = new SelectList(GenreList);

            var movies = from m in db.Movies select m;
            if(!String.IsNullOrEmpty(searchStr))
            {
                movies = movies.Where(s => s.MovieName.Contains(searchStr));
            }

            if (!String.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            return View(movies);
        }

        #region 显示详情的action        
        // GET: Movies/Details/5
        /// <summary>
        /// Details Action
        /// </summary>
        /// <param name="id">传入显示详情的数据的ID</param>
        /// <returns>返回详情的视图，传入一条movie数据</returns>
        public ActionResult Details(int? id)    
        {
            //  判断url请求的querystring，判断是否传入id参数
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);       // Find方法查询id的movie数据赋值给一个movie实例对象
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);     //  将查询到的movie实例对象传给视图，并返回
        }
        #endregion

        // GET: Movies/Create
        /// <summary>
        /// 创建一条数据的Create Action
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        
        // 保存创建的信息时，提交到此Create Action。通过属性标签[HttpPost]来对create的url进行判断 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MovieName,ReleaseDate,Genre,Price")] Movie movie)
        {
            // ModelState.IsValid用于在后台对数据进行校验
            if (ModelState.IsValid)
            {
                //Movie实例添加一条数据到数据库中，然后保存数据库，最后页面跳转到Index视图
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // 编辑修改数据时，根据方法进行判断是编辑显示页面还是编辑保存页面
        // GET: Movies/Edit/5
        /// <summary>
        /// 编辑更改数据
        /// </summary>
        /// <param name="id">数据的id</param>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);     //返回一个编辑显示视图
        }

        // 编辑保存页面
        // POST: Movies/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MovieName,ReleaseDate,Genre,Price")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                // 编辑数据库中的数据，保存对数据库的编辑，最后重定向到Index视图
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // 删除数据时，根据传递参数的方法判断是删除数据显示还是删除数据
        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
