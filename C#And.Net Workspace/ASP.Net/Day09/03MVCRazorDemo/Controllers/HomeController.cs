using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _03MVCRazorDemo.Models;

namespace _03MVCRazorDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            #region
            /*
            UserInfo newUser = new UserInfo();
            newUser.Age = 38;
            newUser.Email = "frank@163.com";
            newUser.UserName = "frank";

            ViewBag.UserName = newUser.UserName;
            ViewBag.Age = newUser.Age;
            ViewBag.Email = newUser.Email;
            */
            #endregion

            ViewData["Now"] = DateTime.Now.ToString();

            ViewBag.UserName = "frank";
            ViewBag.Email = "john@qq.com";

            return View();
        }
	}
}