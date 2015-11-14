using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  方法调用。在同一类下，通过 方法名() 的形式进行方法或函数的调用。使用调用语句的函数称为调用者，被调用的函数或方法称为被调用者。
//  在方法调用的时候，方法的参数列表内可以声明形参，方法的返回值类型可以设置为想要返回的类型。
//  当被调用的方法需要形参时，由调用者向方法传递形参的值。当被调用的方法的返回类型不是void时，被调用的方法需要向调用者返回一个结果。
//  示例代码
namespace _02Func_Diaoyong
{
    class Program
    {
        static void Main(string[] args)
        {          
            int a = 3;
            a = Test(a);
            Console.WriteLine("a的值为：{0}", a);
            Console.ReadKey();
        }

        /// <summary>
        /// 计算a与5的相加结果
        /// </summary>
        /// <param name="a">传入a的值</param>
        /// <returns>返回a与5相加的结果</returns>
        public static int Test(int a)
        {
            return a = a + 5;
        }
    }
}
