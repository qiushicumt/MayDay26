using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05MvcAjaxDemo.Controllers
{
    public class AjaxController : Controller
    {
        //
        // GET: /Ajax/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDate()
        {
            string currentTime = DateTime.Now.ToString();
            return Content(currentTime);
        }
	}
}