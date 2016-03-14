using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShoppingPro.Controllers
{
    public class HomeController : Controller
    {
        #region 商品分类
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult ProductDetail()
        {
            return View();
        }
    }
}
