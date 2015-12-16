using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    //  打折的折扣类
    public class CalRate:CalFather
    {
        //  Rate为折扣率
        double _rate;
        public double Rate
        {
            get;
            set;
        }
        public CalRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetRealMoney(double totalMoney)
        {
            double realMoney = totalMoney * this.Rate;
            return realMoney;
        }
    }
}
