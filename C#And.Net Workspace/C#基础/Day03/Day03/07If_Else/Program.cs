using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //  if条件语句，if的括号中的条件满足时，执行if后面的代码块；if括号中的条件不满足时，跳过if代码块
            //  练习
            //  1、让用户输入年龄，当用户的年龄大于（包含）23岁时，返回输出“你该结婚了”
            Console.Write("请输入你的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 23)
            {
                Console.WriteLine("你该结婚了！");
                //Console.ReadKey();
            }
            else
            {
                Console.WriteLine("你还很年轻！");
                //Console.ReadKey();
            }

            //  2、输入老苏的语文和音乐成绩，如果语文成绩大于90且音乐成绩大于80，语文成绩等于100且音乐成绩大于70，则奖励100元
            Console.WriteLine("老苏，请输入你的语文成绩和音乐成绩");
            Console.Write("老苏，你的语文成绩为：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.Write("老苏，你的音乐成绩为：");
            int music = Convert.ToInt32(Console.ReadLine());
            if ((chinese > 90 && music > 80) || (chinese == 100 && music > 70))
            {
                Console.WriteLine("你可以获得奖励100元！");
                //Console.ReadKey();
            }
            else
            {
                Console.WriteLine("你考的不好，没有奖励！");
                //Console.ReadKey();
            }

            //  3、让用户输入用户名和密码，如果用户名为admin，密码为mypass，则提示登录成功
            Console.Write("请输入你的用户名：");
            string userName = Console.ReadLine();
            Console.Write("请输入你的密码：");
            string password = Console.ReadLine();
            if(userName=="admin"&&password=="mypass")
            {
                Console.WriteLine("登录成功");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("登录失败");
                Console.ReadKey();
            }
        }
    }
}
