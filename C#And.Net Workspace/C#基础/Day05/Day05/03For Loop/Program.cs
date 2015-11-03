using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //  for(语句1;语句2;语句3;){代码}   for循环多用于确定的循环次数的循环。
            //  语句1为初始化变量语句，语句2为用于判断的循环条件，语句3为用于改变循环条件

            /*
            //  练习1、求1-100间的所有偶数和、所有奇数和
            int sum1 = 0, sum2 = 0;     //  sum1为奇数和，sum2为偶数和
            for (var i = 1; i <= 100; i++) {
                if (i % 2 == 0)
                {
                    sum2 += i;
                }
                else
                {
                    sum1 += i;
                }
            }
            Console.WriteLine("1-100之间所有奇数的和为：{0}，所有偶数的和为：{1}", sum1, sum2);
            Console.ReadKey();

            //  test
            int num1 = 0, num2 = 0, num3 = 0;   //  num1是个位数字，num2是十位数字，num3是百位数字
            int i = 0;
            while (i < 10) {
                Console.Write("请输入一个三位数：");
                int num = Convert.ToInt32(Console.ReadLine());
                num1 = num % 10;
                num2 = (num % 100) / 10;
                num3 = num / 100;
                Console.WriteLine("{0}的百位数字是{1}，十位数字是{2}，个位数字是{3}", num, num3, num2, num1);
                i++;
            }           
            Console.ReadKey();     

            //  练习2、找出100-999间的水仙花数（水仙花数是指各位上的数字的立方和等于整个数字）
            int num1 = 0, num2 = 0, num3 = 0;   //  num1是个位数字，num2是十位数字，num3是百位数字            
            for(int i = 100; i <= 999; i++)
            {
                num1 = i % 10;
                num2 = (i % 100) / 10;
                num3 = i / 100;
                int tempNum = num1 * num1 * num1 + num2 * num2 * num2 + num3 * num3 * num3;
                if(tempNum == i)
                {
                    Console.WriteLine("{0}是水仙花数。", i);
                }
            }
            Console.ReadKey();
            
            //  练习3、输出九九乘法表     //  利用嵌套的for循环，可以得到乘法表
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.Write("\r\n");               
            }
            //	输出下三角乘法表
            for (int m = 1; m <= 9; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Console.Write("{0}*{1}={2}\t", m, n, m * n);
                }
                Console.Write("\r\n");
            }
            Console.ReadKey();
            */
            //  练习4、根据用户输入的值显示加法表  0+6=6,1+5=6,2+4=6,3+3=6,4+2=6,5+1=6,6+0=6
            Console.Write("请输入一个数字：");
            int number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= number; i++)
                {
                    int j = number - i;
                    Console.WriteLine("{0}+{1}={2}", i, j, i+j);             
                }
            }
            catch
            {
                Console.WriteLine("输入的数字格式不正确，程序退出！");
            }
            Console.ReadKey();
        }
    }
}
