using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
        #region 对模拟数据库的绑定
        /*
        private void AddBindings()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>{
                new Product{ProductName="Football", Price=25},
                new Product{ProductName="Surf board", Price=179},
                new Product{ProductName="Running shoes", Price=95}
            }.AsQueryable());       //AsQueryable()方法用于将IEnumerable<T>转换成IQueryable<T>
            ninjectKernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
        */
        #endregion

        private void AddBindings()
        {
            //  通过创建EFProductRepository类的实例来实现接口IProductRepository的绑定
            ninjectKernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}