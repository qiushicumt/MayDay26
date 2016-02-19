using _02MVCDemoUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02MVCDemoUser.Controllers
{
    public class HHTestController : Controller
    {
        //
        // GET: /HHTest/

        public ActionResult Index()
        {
            UserInfo user = new UserInfo();
            user.Id = 16;
            user.UserName = "刘能";
            user.Age = 42;
            ViewBag.Name = user.UserName;
            ViewBag.Id = user.Id;
            ViewBag.Age = user.Age;

            return View();
        }

    }
}
