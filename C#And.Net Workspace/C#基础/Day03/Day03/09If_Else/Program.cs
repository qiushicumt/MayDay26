using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  if-else语句结构，满足if条件时，执行if语句块，不满足if条件时，执行else语句块
            //  注：else只与其最近的if语句配对
            //  练习1、老苏买了一筐鸡蛋，如果坏蛋少于5个，他就吃掉，否则他就去退货
            Console.Write("老苏，请输入坏鸡蛋的个数：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 5)
            {
                Console.WriteLine("吃鸡蛋！");
            }
            else
            {
                Console.WriteLine("退鸡蛋！");
            }
            Console.ReadKey();
            
            //  练习2、要求用户输入两个数a、b，如果a和b整除或者a加b大于100，则输出a的值，否则输出b的值
            Console.Write("请输入第一个数a：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第二个数b：");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0 || a + b > 100)
            {
                Console.WriteLine("a的值为：{0}",a);
            }
            else
            {
                Console.WriteLine("b的值为：{0}", b);
            }
            Console.ReadKey();
            
            //  练习3、对学员的结业考试成绩评测(考虑用if好还是用if-else好)：成绩 >= 90：A；90 > 成绩 >= 80：B；80 > 成绩 >= 70 ：C
            //  70 > 成绩 >= 60 ：D；成绩 < 60  ：E
            //  一、只使用if语句
            Console.Write("请输入你的成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            if(score >= 90)
            {
                Console.WriteLine("你的成绩是A！");
            }
            if (score < 90 && score >= 80)
            {
                Console.WriteLine("你的成绩是B！");
            }
            if (score < 80 && score >= 70)
            {
                Console.WriteLine("你的成绩是C！");
            }
            if (score < 70 && score >= 60)
            {
                Console.WriteLine("你的成绩是D！");
            }
            if (score < 60)
            {
                Console.WriteLine("你的成绩是E！");
            }
            Console.ReadKey();
            */
            //  二、使用if-else语句
            Console.Write("请输入你的成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            if(score >= 90)
            {
                Console.WriteLine("你的成绩是A！");
            }
            else
            {
                if (score >= 80)
                {
                    Console.WriteLine("你的成绩是B！");
                }
                else
                {
                    if(score >= 70)
                    {
                        Console.WriteLine("你的成绩是C！");
                    }
                    else
                    {
                        if(score >= 60)
                        {
                            Console.WriteLine("你的成绩是D！");
                        }
                        else
                        {
                            Console.WriteLine("你的成绩是E！");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
