using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Practise
{
    #region
    /*
    //  练习1、提示用户输入两个整数，计算这两个整数之间所有数字之和
    //  注：用户只能输入数字；计算两个数字之间和；要求第一个数字必须比第二个数字小，否则就重新输入
    //  初级写法
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, sum;
            bool flag1 = true, flag2 = true;
            try
            {
                while (flag1)
                {
                    Console.Write("请输入第一个整数：");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("请输入第二个整数：");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num1 >= num2)
                    {
                        Console.WriteLine("第一个数字大于等于第二个数字，请重新输入！");
                        continue;
                    }
                    flag1 = false;
                }
            }
            catch
            {
                Console.WriteLine("输入的不是数字格式的数据，程序退出！");
                flag2 = false;
            }
            if (flag2 == true)
            {
                sum = AddNum(num1, num2);
                Console.WriteLine("{0}和{1}之间所有整数的和为：{2}", num1, num2, sum);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 计算两个整数之间所有数字的和
        /// </summary>
        /// <param name="num1">第一个int型数字</param>
        /// <param name="num2">第二个int型数字</param>
        /// <returns>返回两个数字间所有整数的和</returns>
        public static int AddNum(int num1, int num2)
        {
            int sum = num1;
            while (num1 < num2)
            {
                num1++;
                sum += num1;
            }
            return sum;
        }
    }
    */
    #endregion

    //  练习1、提示用户输入两个整数，计算这两个整数之间所有数字之和
    //  注：方法1、用户只能输入数字；
    //  方法2、计算两个数字之间和；
    //  方法3、要求第一个数字必须比第二个数字小，否则就重新输入

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个整数：");
            string str1 = Console.ReadLine();
            int num1 = StrToInt(str1);
            Console.Write("请输入第二个整数：");
            string str2 = Console.ReadLine();
            int num2 = StrToInt(str2);
            JudgeNum(ref num1, ref num2);
            int sum = NumSum(num1, num2);
            Console.WriteLine("{0}和{1}之间所有数字的和为：{2}", num1, num2, sum);
            Console.ReadKey();
        }

        /// <summary>
        /// 将string类型数据转换为int类型
        /// </summary>
        /// <param name="str">传入的string类型</param>
        /// <returns>返回int类型</returns>
        public static int StrToInt(string str)
        {
            while (true)
            {
                try
                {
                    int num1 = Convert.ToInt32(str);
                    return num1;    //  转换成数字后，直接退出函数的调用
                }
                catch
                {
                    Console.WriteLine("你输入的数据格式不正确，请重新输入!!");                        
                    str = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 计算两个整数之间所有数字的和
        /// </summary>
        /// <param name="num1">第一个整数</param>
        /// <param name="num2">第二个整数</param>
        /// <returns>返回两个数字之间所有整数的和</returns>
        public static int NumSum(int num1, int num2)
        {
            int sum = num1;
            while (num1 < num2)
            {
                num1++;
                sum += num1;
            }
            return sum;
        }

        /// <summary>
        /// 判断第一个整数是否大于第二个整数
        /// </summary>
        /// <param name="num1">第一个整数</param>
        /// <param name="num2">第二个整数</param>
        public static void JudgeNum(ref int num1, ref int num2) //  使用ref参数，当重新输入两个整数时，可以把新的整数的值返回到函数外面
        {
            while (true)
            {
                if (num1 < num2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("输入的第一个整数大于等于第二个整数，请重新输入！");
                    Console.Write("请重新输入第一个整数：");
                    string str1 = Console.ReadLine();
                    num1 = StrToInt(str1);
                    Console.Write("请重新输入第二个整数：");
                    string str2 = Console.ReadLine();
                    num2 = StrToInt(str2);
                }
            }
        }
    }
}