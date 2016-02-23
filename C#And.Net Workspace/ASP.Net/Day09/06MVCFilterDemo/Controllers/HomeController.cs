using _06MVCFilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06MVCFilterDemo.Controllers
{
    [MyFilterAttribute(Name="HomeController")]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //Index的Action包含过滤器标签，所以在访问Index视图时，
        [MyFilterAttribute(Name="Index Action")]
        public ActionResult Index()
        {
            Response.Write("<p>Action被执行了，视图还未渲染</p>");
            return Content("<p>OK！视图渲染了</p>");
        }

        //此处，About的Action不包含过滤器标签，所以当访问About视图时，HomeController的过滤器标签起作用
        public ActionResult About()
        {
            return Content("<p>About视图渲染了</p>");
        }
	}
}