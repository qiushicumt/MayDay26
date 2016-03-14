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

        public ActionResult Details()
        {
            return View();
        }
    }
}
