using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //  创建超市对象
            SuperMarket myMarket = new SuperMarket();

            //  展示超市信息
            myMarket.SuperMarketShow();

            //  询问购买物品
            myMarket.AskBuying();

            Console.ReadKey();
        }
    }
}
