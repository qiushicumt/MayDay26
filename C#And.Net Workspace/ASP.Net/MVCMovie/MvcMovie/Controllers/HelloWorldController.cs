using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        

        public string Index()
        {
            return "<h1>This is the default action.</h1>";
        }
        
        public string Welcome(string name, int times)
        {
            return "<h2>Welcome " + name + ", this is the " + times + " times.</h2>";
        }

        public string Welcome2(int times, string name)
        {
            return "<h2>Welcome " + name + ", this is the " + times + " times.</h2>";
        }

        public string Welcome3(string name, int id = 6)
        {
            return "<h2>Welcome " + name + ", this is the " + id + " times.</h2>";
        }

        public ActionResult HelloWorld()
        {
            return View();
        }
         * * */

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}