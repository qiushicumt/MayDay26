using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  练习1、用while、continue实现计算1到100(含)之间的除了能被7整除的之外的所有整数的和
            int sum = 0;
            int i = 1;
            while (i <= 100) {
                if (i % 7 == 0)
                {
                    i++;
                    continue;
                }
                else
                {
                    sum += i;
                    i++;
                }
            }
            Console.WriteLine("1~100之间除了能被7整除的数之外的所有整数的和为：{0}", sum);
            Console.ReadKey();
             */
            //  练习2、找出100以内所有的素数
            //  用当前数字i除以2~（i-1）的所有数字，都除不尽的话，该数字就是质数
            int i;            
            for (i = 2; i <= 100; i++) {
                bool flag = true;
                for (int j = 2; j < i; j++) {
                    if (i % j == 0)
                    {
                        flag = false;
                        continue;
                    }
                }
                if(flag)
                    Console.WriteLine("{0}是质数！", i);
            }
            Console.ReadKey();
        }
    }
}
