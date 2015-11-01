using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01YiChang
{
    class Program
    {
        static void Main(string[] args)
        {
            //  C#中异常捕获，通过try-catch语句来执行异常捕获的相关操作。
            //  将有可能出现异常的语句放在try语句块中，将出现异常以后执行的操作放在catch语句块中。
            //  若语句发生异常，则程序直接跳入catch语句块中，执行catch语句，然后跳出整个try-catch结构，执行后续代码
            //  在try语句块中，发生的异常的语句后的代码不执行
            //  若try语句块中的语句没有出现异常，则程序不执行catch语句块中的语句

            //  注：在try{}--catch{}语句块中间不能写任何代码

            Console.WriteLine("请输入一个数字：");
            bool flag = true;
            int num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的内容不是有效的格式！");
                flag = false;
            }
            if(flag) {
                Console.WriteLine(num * 2);
            }
            Console.ReadKey();
            //  在此处，当程序出现异常时，本语句得到就不是有效的结果。可以在程序中设置一个标志位变量，进行判断是否需要执行本条语句
            //  Console.WriteLine(num * 2);     
        }
    }
}
