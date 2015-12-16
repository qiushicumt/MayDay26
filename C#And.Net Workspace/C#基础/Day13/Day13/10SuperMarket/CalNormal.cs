using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    //  不打折的类
    public class CalNormal:CalFather
    {
        public override double GetRealMoney(double totalMoney)
        {
            return totalMoney;           
        }
    }
}
