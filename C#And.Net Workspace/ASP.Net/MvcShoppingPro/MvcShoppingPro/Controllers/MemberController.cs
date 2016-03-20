using MvcShoppingPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcShoppingPro.Controllers
{
    public class MemberController : Controller
    {
        //
        // GET: /Member/

        public ActionResult Index()
        {
            return View();
        }

        #region 会员注册
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register([Bind(Exclude = "RegisterTime, AuthCode")]Members member)  //[Bind()]特性修饰Members，用于指定Members的特性
        {
            return View();
        }
        #endregion

        #region 会员登录账号
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userEmail, string password)
        {
            return View();
        }
        #endregion

        private bool ValidateUser(string userEmail, string password)
        {
            throw new NotImplementedException();
        }

        #region 会员帐号注销
        public ActionResult LoginOut()
        {
            //清除验证的Cookies
            FormsAuthentication.SignOut();

            //清除Session
            Session.Clear();

            return RedirectToAction("Index", "Home");
        }
        #endregion
        
    }
}
