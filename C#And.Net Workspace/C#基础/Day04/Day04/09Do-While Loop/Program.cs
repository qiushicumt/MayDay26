using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //  do-while循环，do后接循环体，while后接循环条件。在do-while循环中，先执行一遍do循环体，然后再进行循环条件的判断
            //  在do-while循环中，无论循环条件是否符合，都会先执行一遍循环体
            /*
            //  练习2：要求用户输入用户名和密码，只要不是admin、888888就一直提示用户名或密码错误,请重新输入。
            string userName = "";
            string userPwd = "";
            do
            {
                Console.Write("请输入用户名：");
                userName = Console.ReadLine();
                Console.Write("请输入密码：");
                userPwd = Console.ReadLine();
            }
            while (userName!="admin" || userPwd!="88888");
            Console.WriteLine("登录成功！");
            Console.ReadKey();
            
            //  练习3: 不断要求用户输入学生姓名,输入q结束.
            string name = "";
            do {
                Console.Write("请输入学生的姓名：");
                name = Console.ReadLine();
                if(name != "q")
                    Console.WriteLine("你输入的学生姓名是：{0}", name);
            } while (name!="q");
            Console.WriteLine("程序结束！");
            Console.ReadKey();
            
            //  练习4：不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候程序退出。
            //  使用while循环更合理
            string str = "";
            bool flag = true;
            while (str != "q")
            {
                Console.Write("请输入一个数字：");
                str = Console.ReadLine();
                int num = 0;
                if (str != "q")
                {
                    try
                    {
                        num = Convert.ToInt32(str);
                        Console.WriteLine("你输入的数字的2倍是：{0}", num * 2);
                    }
                    catch
                    {
                        Console.WriteLine("你输入的数字的格式不正确，程序退出！");
                        flag = false;
                        break;
                    }
                }              
            }
            if(flag)
            {
                Console.WriteLine("退出while循环！");
            }
            Console.ReadKey();
            */
            //  练习5：不断要求用户输入一个数字（假定用户输入的都是正整数），当用户输入end的时候显示刚才输入的数字中的最大值
            string str = "";
            bool flag = true;
            int num = 0;
            while (str != "end")
            {
                Console.Write("请输入一个数字(输入end停止输入，显示最大数字)：");
                str = Console.ReadLine();
                if (str != "end") {
                    try {
                        int temp = Convert.ToInt32(str);
                        if (num < temp) {
                            num = temp;
                        }
                    }
                    catch {
                        Console.WriteLine("输入的数字格式不正确！程序退出！");
                        flag = false;
                        break;
                    }
                }
            }
            if(flag)
                Console.WriteLine("刚刚输入的数字中的最大值是：{0}", num);
            Console.ReadKey();
        }
    }
}
