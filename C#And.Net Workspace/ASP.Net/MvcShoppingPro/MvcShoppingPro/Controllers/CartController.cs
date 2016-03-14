using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShoppingPro.Controllers
{
    public class CartController : Controller
    {
        #region 显示购物车中项目
		
        public ActionResult Index()
        {
            return View();
        }
	    
        #endregion

        
        #region 添加商品到购物车
		[HttpPost]
        public ActionResult AddToCart(int productId, int amount = 1)
        {
            return View();
        } 
	    #endregion

        #region 从购物车中移除商品
        public ActionResult Remove(int productId)
        {
            return View();
        }
        #endregion

        #region 更新购物车数量
        [HttpPost]
        public ActionResult UpdateAmount(int newAmount)
        {
            return View();
        }
        #endregion
    }
}
