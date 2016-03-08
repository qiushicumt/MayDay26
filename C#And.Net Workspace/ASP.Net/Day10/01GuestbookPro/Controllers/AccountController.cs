using _01GuestbookPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01GuestbookPro.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext _db = new AccountContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AccountModel account)
        {
            _db.Accounts.Add(account);
            _db.SaveChanges();
            return Content("<p>注册成功，请返回登录！<a href='Index'>返回</a></p>");
        }
    }
}
