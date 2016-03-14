using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShoppingPro.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        #region 完成订单
        public ActionResult Complete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Complete(FormCollection form)
        {
            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}
