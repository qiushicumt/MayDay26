using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10If_Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1、if-else if是多条件分支结构，判断条件成功与否，则执行相应的代码，当条件都不满足，则执行else代码，若不存在else，则直接跳过
            
            //  练习1、提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”并且密码是“88888”，则提示正确
            //  否则，如果用户名不是admin还提示用户用户名不存在,如果用户名是admin则提示密码错误
            Console.Write("请输入用户名：");
            string username = Console.ReadLine();
            Console.Write("请输入密码：");
            string password = Console.ReadLine();
            if (username == "admin" && password == "88888") {
                Console.WriteLine("登陆成功！");
            }
            else if(username != "admin") {
                Console.WriteLine("用户名不存在！");
            }
            else {
                Console.WriteLine("密码错误！");
            }
            Console.ReadKey();
            
            //  练习2、提示用户输入年龄，如果大于等于18，则告知用户可以查看
            //  如果小于10岁，则告知不允许查看
            //  如果大于等于10岁并且小于18，则提示用户是否继续查看（yes、no）
            //  如果输入的是yes则提示用户请查看，否则提示"退出,你放弃查看"。
            Console.Write("请输入你的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18) {
                Console.WriteLine("可以查看！");
            }
            else if(age < 10) {
                Console.WriteLine("不允许查看！");
            }
            else if (age >= 10 && age < 18) {
                Console.WriteLine("是否继续查看? Yes?No?");
                string str = Console.ReadLine();
                if (str == "yes")
                {
                    Console.WriteLine("你可以查看！");
                }
                else {
                    Console.WriteLine("退出，你放弃查看");
                }
            }
            Console.ReadKey();
        }
    }
}
