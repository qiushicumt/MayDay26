using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07If
{
    class Program
    {
        static void Main(string[] args)
        {
            //  if条件语句，当if后括号内的条件满足时，执行if后的代码块，不满足则跳过if语句
            //  练习1、让用户输入年龄,如果输入的年龄大于23(含)岁,则给用户显示你到了结婚的年龄了.
            Console.Write("请输入你的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 23) {
                Console.WriteLine("你该结婚了！");
            }
            
            //  练习2、如果老苏的(chinese  music)成绩：语文成绩大于90并且音乐成绩大于80或者语文成绩等于100并且音乐成绩大于70，则奖励100元。
            Console.Write("老苏，请输入你的语文成绩：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.Write("老苏，请输入你的音乐成绩：");
            int music = Convert.ToInt32(Console.ReadLine());
            if ((chinese > 90 && music > 80) || (chinese == 100 && music > 70)) {
                Console.WriteLine("奖励100元");
            }

            //  练习3、让用户输入用户名和密码，如果用户名为admin，密码为mypass，则提示登录成功。
            Console.Write("请输入用户名：");
            string username = Console.ReadLine();
            Console.Write("请输入密码：");
            string password = Console.ReadLine();
            if (username == "admin" && password == "mypass")
            {
                Console.WriteLine("登录成功！");
            }
            Console.ReadKey();
        }
    }
}
