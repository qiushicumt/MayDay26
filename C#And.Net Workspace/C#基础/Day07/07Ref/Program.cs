using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Ref_Params
{
    /*
    //  ref参数，在函数或者方法的形参前面加上ref参数，可以使此变量的作用域延伸到方法外面
    //  例如  public static void MyFunc(ref int num1)
    //  num1在 调用者传入后，在方法内发生变化，不必通过ruturn语句返回，可直接把变化后的值传递给调用者
    //  注：ref参数修饰的变量必须在方法调用前进行赋值，在方法中可以不进行赋值操作
    //  相反的，out参数修饰的变量在方法调用前可以不进行赋值，在方法中必须进行赋值操作

    //  ref的示例代码
    class Program
    {
        static void Main(string[] args)
        {
            double salary1 = 5000;
            JiangJin(ref salary1);
            Console.WriteLine("张三这个月的工资为：{0}", salary1);
            double salary2 = 6200;
            FaKuan(ref salary2);
            Console.WriteLine("李四这个月的工资为：{0}", salary2);
            Console.ReadKey();
        }

        /// <summary>
        /// 输入的参数加500
        /// </summary>
        /// <param name="s">传入的整数</param>
        public static void JiangJin(ref double s)
        {
            s += 500;
        }

        /// <summary>
        /// 输入的参数减去500
        /// </summary>
        /// <param name="s">传入的整数</param>
        public static void FaKuan(ref double s)
        {
            s -= 500;
        }
    }
    */
    //  ref参数练习 交换两个变量的值
    class Program
    {
        static void Main(string[] args) 
        {
            int num1 = 30;
            int num2 = 22;
            Console.WriteLine("交换前num1的值为：{0}，num2的值为：{1}", num1, num2);
            //ChangeValue1(ref num1, ref num2);
            ChangeValue2(ref num1, ref num2);
            Console.WriteLine("交换后num1的值为：{0}，num2的值为：{1}", num1, num2);
            Console.ReadKey();
        }

        /// <summary>
        /// 通过使用第三个变量来交换两个变量的值
        /// </summary>
        /// <param name="num1">int类型变量</param>
        /// <param name="num2">int类型变量</param>
        public static void ChangeValue1(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        /// <summary>
        /// 不使用第三个变量进行两个变量的值的交换
        /// </summary>
        /// <param name="num1">int类型变量</param>
        /// <param name="num2">int类型变量</param>
        public static void ChangeValue2(ref int num1, ref int num2)
        {
            num1 = num1 - num2;
            num2 = num2 + num1;
            num1 = num2 - num1;
        }
    }
}
