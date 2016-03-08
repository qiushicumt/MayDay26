using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EssentialTools.Models
{
    /// <summary>
    /// 声明一个计算的接口
    /// </summary>
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}
