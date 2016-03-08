using _01EssentialTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace _01EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products = { 
        new Product { Name="Kayak", Category="Watersports", Price=275M },
        new Product { Name="Lifejacket", Category="Watersports", Price=48.95M},
        new Product { Name="Soccer ball", Category="Soccer", Price=19.50M},
        new Product { Name="Corner flag", Category="Soccer", Price=34.95M}
        };

        #region 紧耦合的方式实现功能
        /*
        public ActionResult Index()
        {
            IValueCalculator calc = new LinqValueCalculator();      //实例化一个IValueCalculator对象
            ShoppingCart myCart = new ShoppingCart(calc);
            myCart.Products = products;
            decimal totalValue = myCart.CalculatorTotal();

            return View(totalValue);
        }
        */
        #endregion
        #region 使用Ninject实现松耦合
        public ActionResult Index()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();

            ShoppingCart myCart = new ShoppingCart(calc);
            myCart.Products = products;
            decimal totalValue = myCart.CalculatorTotal();

            return View(totalValue);
        }
	    #endregion
         
    }
}
