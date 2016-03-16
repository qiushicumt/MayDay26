using MvcShoppingPro.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            //传递商品类别数据
            List<ProductCategory> proCat = new List<ProductCategory>() { 
                new ProductCategory() { Id = 1, Name = "文具" },
                new ProductCategory() { Id = 2, Name = "礼品" },
                new ProductCategory() { Id = 3, Name = "书籍" },
                new ProductCategory() { Id = 4, Name = "电子产品" }
            };
            return View(proCat);
        }
        #endregion

        #region 商品列表
        public ActionResult ProductList(int Id)
        {
            //传递商品数据
            var productCat = new ProductCategory() { Id = Id, Name = "类别" + Id };
            var products = new List<Product>()
            {
                new Product(){ Id=1,Category=productCat, Name="原子笔", Description="N/A",Price=30.00M, PublishOn = DateTime.Now, ProductColor = Color.Black },
                new Product(){ Id = 1, Category = productCat, Name = "铅笔", Description = "N/A", Price = 5M, PublishOn = DateTime.Now, ProductColor = Color.Green }
            };

            return View(products);
        }
        #endregion

        #region 商品详情
        public ActionResult ProductDetail(int Id)
        {

            return View();
        }
        #endregion
        
    }
}
