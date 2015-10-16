using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zhanwei
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "卡卡西";
            int myAge = 28;
            string myAddress = "火影村128号";
            decimal mySalary = 5000m;

            //  +运算符，+的两端是字符串时，+起连接字符串的作用
            Console.WriteLine("我叫：" + myName +", 我的年龄是："+myAge+"岁，住在："+myAddress+"，我的收入是："+mySalary+"\n");
            //  {}在字符串输出中表示占位符，{0}表示第一个变量，以此类推
            Console.WriteLine("我叫{0}，我的年龄是{1}，住在{2}，我的收入是{3}", myName, myAge, myAddress, mySalary);
            Console.ReadKey();
        }
    }
}
