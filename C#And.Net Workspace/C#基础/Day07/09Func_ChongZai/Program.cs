using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Func_ChongZai
{
    //  方法的重载：具有相同的函数名或者方法名，但是方法或者函数的参数不同
    //  参数不同可以分为：参数类型相同，但是参数的个数不同；参数个数相同，但是参数的类型不同
    //  注：方法的重载与返回值没有关系
    //  示例代码
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 23, num2 = 33, num3 = 44;
            double d1 = 1.32, d2 = 2.13;
            string str1 = "asdf", str2 = "zxcv";
            Console.WriteLine(MyPlus(num1, num2));
            Console.WriteLine(MyPlus(d1, d2));
            Console.WriteLine(MyPlus(num1, num2, num3));
            Console.WriteLine(MyPlus(str1, str2));
            Console.ReadKey();
        }

        public static int MyPlus(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double MyPlus(double num1, double num2)
        {
            return num1 + num2;
        }
        public static int MyPlus(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public static string MyPlus(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
