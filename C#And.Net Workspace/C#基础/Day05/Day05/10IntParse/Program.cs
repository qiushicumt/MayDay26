using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10IntParse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  int.parse方法可以将字符串类型转换为int类型
             *  Int32.Parse相当于调用Int32类的方法Parse，传入一个string类型参数，返回一个int类型值
             *  注：当传入的string类型数据无法转换为数字时，程序一样会抛出异常，所以也要使用try-catch。
             *  同理还可以有Double.Parse()、Decimal.Parse()
            //  示例代码
            Console.Write("请输入一个数字：");
            string str = Console.ReadLine();
            try
            {
                int number = Int32.Parse(str);
                Console.WriteLine("{0}的平方为：{1}", number, number * number);
            }
            catch 
            {
                Console.WriteLine("输入的数字格式不正确！");
            }
            Console.ReadKey();
            */

            //  int.TryParse同样可以用于转换数据类型
            //  语法:Int32.TryParse(string s, out int result)
            //  转换成功时，方法返回true，result为s转换后的int类型数据，转换失败，方法返回false，result为0
            //  注：当数据类型无法转换时，此方法不会抛出异常，不需要try-catch
            Console.Write("请输入一个数字：");
            string str = Console.ReadLine();
            int number;
            bool result = Int32.TryParse(str, out number);
            Console.WriteLine("{0}的三次方为:{1}", number, number * number * number);
            Console.WriteLine("转换的结果为：{0}", result);
            Console.ReadKey();
        }
    }
}
