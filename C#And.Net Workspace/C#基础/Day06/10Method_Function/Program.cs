using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Method_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            //  函数(方法)就是将一段重复执行的代码封装起来，以便重用
            //  语法： [public] static 返回值类型 函数名 ([参数列表])
            //  方法调用语法： 类名.方法名 ([参数列表])
            //  注：调用某个方法时，当前方法与被调用的方法属于同一个类时，可省略类名，直接写方法名进行调用
            //  示例代码，通过调用一个方法，计算两个整数中的最大值
            
            Console.Write("请输入一个整数：");
            string str1 = Console.ReadLine();
            int num1 = 0, num2 = 0;
            bool flag = Int32.TryParse(str1, out num1);
            Console.Write("请输入另一个整数：");
            str1 = Console.ReadLine();
            flag = Int32.TryParse(str1, out num2);
            //  方法调用
            int maxNum = Program.IntMax(num1, num2);
            Console.WriteLine("{0}、{1}两个数中的最大值是：{2}", num1, num2, maxNum);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算两个整数中的最大值，并且将最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回两个整数中的最大值</returns>
        public static int IntMax(int n1, int n2) {
            return n1 > n2 ? n1 : n2;
        }
    }
}
