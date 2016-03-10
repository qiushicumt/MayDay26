using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;          //实例化一个存储库实例对象

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ActionResult List()
        {
            return View(repository.Products);
        }

    }
}
