using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11For_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  for循环练习
            //  练习1:循环录入5个人的年龄并计算平均年龄,如果录入的数据出现负数或大于100的数,立即停止输入并报错。
            double sum = 0;
            bool flag = true;
            int i;
            for (i = 0; i < 5; i++) {
                Console.Write("请输入第{0}个人的年龄：", i + 1);
                int age = 0;
                bool result = Int32.TryParse(Console.ReadLine(), out age);               
                if (!result || age < 0 || age > 100)
                {
                    flag = false;
                    break;
                }
                sum += age;
            }
            if (flag) {
                Console.WriteLine("{0}个人的平均年龄是：{1}", i, sum/i);
            }
            else
            {
                Console.WriteLine("输入的年龄不正确！");
            }
            Console.ReadKey();

            //  练习2、在while中用break实现要求用户一直输入用户名和密码，只要不是admin、88888就一直提示要求重新输入,如果正确则提登录成功。
            string userName = "";
            string userPwd = "";
            //  while的括号中为true，则while循环一直执行。
            //  在while的代码块中，使用break来跳出循环
            while (true)
            {
                Console.Write("请输入用户名：");
                userName = Console.ReadLine();
                Console.Write("请输入密码：");
                userPwd = Console.ReadLine();
                if(userName == "admin" && userPwd == "88888")
                {
                    break;
                }
            }
            Console.WriteLine("登录成功！");
            Console.ReadKey();           
            */
            //  练习3、1~100之间的整数相加，得到累加值大于20的当前数(比如:1+2+3+4+5+6=21)结果6
            int sum = 0;
            int i;
            for(i = 1; i <= 100; i++)
            {
                sum += i;
                if (sum > 20)
                {
                    break;
                }
            }
            Console.WriteLine("累加值为：{0}，大于20，当前值为：{1}", sum, i);
            Console.ReadKey();
        }
    }
}
