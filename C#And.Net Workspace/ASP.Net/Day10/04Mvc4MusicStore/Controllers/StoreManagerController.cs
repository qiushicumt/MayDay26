using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _04Mvc4MusicStore.Models;

namespace _04Mvc4MusicStore.Controllers
{
    public class StoreManagerController : Controller
    {
        private MusicStoreEntities _dbContext = new MusicStoreEntities();
        public ActionResult Index()
        {
            /*
             * 错误：var albums = _dbContext.Albums;
             * var albums = _dbContext.Albums.ToList();
             * var albums = _dbContext.Albums.Include("Genre").Include("Artist");
             * var albums = _dbContext.Albums.Include(a => a.Genre).Include(a => a.Artist);
             */
            // var albums = _dbContext.Albums.Include("Genre").ToList();
            //var albums = _dbContext.Albums.Include(a => a.Genre).Include(a => a.Artist);
            //return View(albums.ToList());
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}
