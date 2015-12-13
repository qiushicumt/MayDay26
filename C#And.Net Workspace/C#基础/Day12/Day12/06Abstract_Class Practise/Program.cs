using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Abstract_Class_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle oneRect = new Rectangle(20, 12);
            //Circle oneCircle = new Circle(10);
            Sharp oneRect = new Rectangle(20, 12);
            Sharp oneCircle = new Circle(10);
            Console.WriteLine("矩形的周长为：{0}，面积为：{1}", oneRect.zhouchang(), oneRect.area());
            Console.WriteLine("圆的周长为：{0}，面积为：{1}", oneCircle.zhouchang(), oneCircle.area());
            Console.ReadKey();
        }
    }
}
