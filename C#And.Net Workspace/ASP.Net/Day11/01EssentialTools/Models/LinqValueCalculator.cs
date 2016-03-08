using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01EssentialTools.Models
{
    /// <summary>
    /// LinqValueCalculator实现IValueCalculator
    /// </summary>
    public class LinqValueCalculator:IValueCalculator
    {
        /// <summary>
        /// 计算产品对象集合的总价
        /// </summary>
        /// <param name="products">产品集合参数</param>
        /// <returns>返回产品集合的总价</returns>
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}