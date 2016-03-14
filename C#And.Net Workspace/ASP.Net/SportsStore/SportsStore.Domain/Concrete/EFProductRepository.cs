using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Concrete
{
    #region 存储库类  从数据表中读取到数据，存在_dbContext变量中，然后赋值给存储库的属性Products
    
    public class EFProductRepository:IProductRepository
    {
        private EFDbContext _dbContext = new EFDbContext();

        public IQueryable<Product> Products { get { return _dbContext.Products; } }
    }

    #endregion
}
