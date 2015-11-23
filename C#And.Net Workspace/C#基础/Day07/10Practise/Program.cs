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

    //  练习2、用方法来实现，一个字符串数组为{"卡尔马龙","迈克尔乔丹","雷吉米勒","诺维茨基","蒂姆邓肯","科比布莱恩特"}，输出最长的字符串
    //  字符串的长度可以通过str.Length获得
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameStr = { "卡尔马龙", "迈克尔乔丹", "雷吉米勒", "诺维茨基", "蒂姆邓肯", "科比布莱恩特" };
            string myStringName = judgeStr(nameStr);
            Console.WriteLine("最长的字符串是：{0}", myStringName);
            Console.ReadKey();
        }

        /// <summary>
        /// 判断一个字符串数组中最长的字符串并输出
        /// </summary>
        /// <param name="strArray">传入一个字符串数组</param>
        /// <returns>返回最长的字符串</returns>
        public static string judgeStr(string[] strArray)
        {
            string myStr = strArray[0];
            for (var i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > myStr.Length)
                {
                    myStr = strArray[i];
                }
            }
            return myStr;
        }
    } 

    //  练习3、用方法实现计算一个整型数组的平均值
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 21, 43, 54, 1, 12, 36, 68 };
            double avgNum = arrayAvg(numArray);
            Console.WriteLine("数组的平均值为：{0}", avgNum);
            Console.ReadKey();
        }

        /// <summary>
        /// 计算一个整型数组的平均值
        /// </summary>
        /// <param name="nums">传入一个int型数组</param>
        /// <returns>返回数组的所有数字的平均值</returns>
        public static double arrayAvg(int[] nums) 
        {
            double sum = 0.00;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }
    }
    */
    #endregion

    //  练习4、写一个方法，判断用户输入的数字是否为质数。
    //  另写一个方法，若用户输入的不是数字，则要求用户一直输入数字
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个数字：");
            string str1 = Console.ReadLine();
            int num1 = StrToInt(str1);
            bool flag = ZhiShu(num1);
            if (flag)
                Console.WriteLine("{0}是一个质数!", num1);
            else
                Console.WriteLine("{0}不是质数!", num1);
            Console.ReadKey();
        }
        /// <summary>
        /// 将用户输入的string转换为int
        /// </summary>
        /// <param name="str">传入string类型数据</param>
        /// <returns>返回int型数据</returns>
        public static int StrToInt(string str)
        {
            while (true)
            {
                int num1 = 0;
                bool flag = Int32.TryParse(str, out num1);
                if (flag)
                {
                    return num1;    //  当用户输入正确转换为数字时，跳出函数，return数字                   
                }
                else
                {
                    Console.WriteLine("你输入的不是一个有效数字，请重新输入!");
                    str = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判断用户输入的数字是否为质数
        /// </summary>
        /// <param name="num">int型数据</param>
        /// <returns>返回一个bool值，用户输入质数，返回true，不是质数，返回false</returns>
        public static bool ZhiShu(int num)
        {
            bool flag = true;
            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}