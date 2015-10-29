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
            Console.Write("请输入一个年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("True，{0}是闰年", year);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("False，{0}不是闰年", year);
                Console.ReadKey();
            }
        }
    }
}
