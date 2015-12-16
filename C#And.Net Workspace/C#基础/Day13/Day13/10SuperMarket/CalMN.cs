using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    //  满300减50，满500减100类
    public class CalMN:CalFather
    {
        double _m;
        double _n;
        public double M
        {
            get;
            set;
        }
        public double N
        {
            get;
            set;
        }

        //  构造函数
        public CalMN(double m, double n)
        {
            this.M = m;
            this.N = n; 
        }

        public override double GetRealMoney(double totalMoney)
        {
            double realMoney = 0;
            if(totalMoney >= M && totalMoney < 500)
            {
                realMoney = totalMoney - N;
            }
            else if (totalMoney >= 500)
            {
                realMoney = totalMoney - (int)(totalMoney / M) * N;
            }
            return realMoney; 
        }
    }
}
