using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Class_Practise
{
    public class Ticket
    {
        int _distance;
        double _price;
        //  Distance属性和Price属性均只有get方法，即两个属性都是只能获取数值，不能在外部对属性进行赋值
        public int Distance
        {
            get 
            {
                if (_distance < 0)
                    return _distance = 0;
                return _distance; 
            }
        }
        public double Price
        {
            get { return _price; }
        }        
        //  类的对象的构造函数，包含一个参数，参数用于给属性Distance赋值
        public Ticket(int distance)
        {
            this._distance = distance;
        }
        /// <summary>
        /// 根据用户输入的距离，计算票价并显示价格信息.
        /// </summary>
        public void ShowPrice()
        {
            if (this.Distance >= 0 && this.Distance <= 100)
            {
                this._price = this.Distance * 1;
            }
            else if (this.Distance > 100 && this.Distance <= 200)
            {
                this._price = this.Distance * 1 * 0.95;
            }
            else if (this.Distance > 200 && this.Distance <= 300)
            {
                this._price = this.Distance * 1 * 0.9;
            }
            else
            {
                this._price = this.Distance * 1 * 0.8;
            }
            Console.WriteLine("这张票的价格信息为，{0}公里{1}元钱", this.Distance, this.Price);
        }
    }
}
