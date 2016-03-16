using _04Mvc4MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04Mvc4MusicStore.Controllers
{
    public class MusicStoreController : Controller
    {
        
        private MusicStoreEntities musicstoreDB = new MusicStoreEntities();

        public ActionResult Index()
        {
            var genres = musicstoreDB.Genres.ToList();
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = musicstoreDB.Genres.Include("Albums").Single(g=>g.GenreName == genre);

            return View(genreModel);
        }

        /// <summary>
        /// 显示专辑详情
        /// </summary>
        /// <param name="id">传入的专辑Id</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            //Find()方法根据传入的Id查找到专辑
            var album = musicstoreDB.Albums.Find(id);
            return View(album);
        }
    }
}
