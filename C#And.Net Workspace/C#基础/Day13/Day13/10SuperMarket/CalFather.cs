using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    //  创建打折的父类，有一个打折的抽象方法
    public abstract class CalFather
    {
        /// <summary>
        /// 获取打折后的价钱
        /// </summary>
        /// <param name="totalMoney">原来的总价</param>
        /// <returns>打折后的总价</returns>
        public abstract double GetRealMoney(double totalMoney);
    }
}
