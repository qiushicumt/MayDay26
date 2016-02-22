using _04MVCValidateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04MVCValidateDemo.Controllers
{
    public class UserInfoController : Controller
    {
        //
        // GET: /UserInfo/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Add(UserInfo user)
        {
            if (ModelState.IsValid)     //  ModelState.IsValid表示是否验证，验证成功为true
            {
                Response.Write("<script>alert('验证成功')</script>");
            }
            return View();
        }
        
	}
}