using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RunNian
{
    class Program
    {
        static void Main(string[] args)
        {
            //  练习，输入年份判断闰年，判断条件为：1、能够整除400的 2、能够整除4但是不能整除100的
            Console.Write("请输入一个年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("你输入的是闰年！");
            }
            Console.ReadKey();
        }
    }
}
