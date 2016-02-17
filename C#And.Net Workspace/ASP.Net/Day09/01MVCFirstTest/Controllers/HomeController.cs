using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01MVCFirstTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.Name = "XiaoMing";
            return View();      //View括号内部可以添加想要返回的视图页面
        }

        public ActionResult Index2()
        {
            return View();
        }
	}
}