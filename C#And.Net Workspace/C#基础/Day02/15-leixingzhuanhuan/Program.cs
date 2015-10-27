using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_leixingzhuanhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            //  C#中等号的两侧数据类型应当一致，当不一致时，可以发生隐式类型转换和显示类型转换

            //  隐式类型转换发生的条件：（1）、两种类型是兼容的，如int和double都为数字类型；
            //  （2）、目标类型大于源类型，如double>int，此时，int型可以自动转换为double型；

            //  通过语句，可以将大的数据转换成小的数据，显示类型转换发生的条件：（1）、两种类型是兼容的；
            //  （2）、通过(目标类型)源类型进行显示类型转换，如 int n = (int)double;

            //int num = 10;
            //double d = num;
            //double e = 28;
            //num = (int)e;
            //Console.WriteLine(d);
            //Console.WriteLine(num);
            //Console.ReadKey();

            //  当表达式中有一个操作数的类型提升为更高一级的数值类型时，整个表达式的值也会提升为高一级的数值类型
            int num1 = 10;
            int num2 = 3;
            //  double d = num1 / num2;
            double d = num1 * 1.0 / num2;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
