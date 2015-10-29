using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            //  if条件语句，if的括号中的条件满足时，执行if后面的代码块；if括号中的条件不满足时，跳过if代码块
            //  练习
            //  1、让用户输入年龄，当用户的年龄大于（包含）23岁时，返回输出“你该结婚了”
            Console.Write("请输入你的年龄：");
            var age = Convert.ToInt32(Console.ReadLine());
            if(age >= 23)
            {
                Console.WriteLine("你该结婚了！");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("你还很年轻！");
                Console.ReadKey();
            }
            //  2、输入老苏的语文和音乐成绩，如果语文成绩大于90且音乐成绩大于80，语文成绩等于100且音乐成绩大于70，则奖励100元

            //  3、让用户输入用户名和密码，如果用户名为admin，密码为mypass，则提示登录成功
        }
    }
}
