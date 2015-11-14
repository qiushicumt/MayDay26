using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Func_Practise
{
    //  方法练习
    #region  
    //  1、读取输入的整数，定义成方法，多次调用(如果用户输入的是数字,则返回,否则提示用户重新输入)
    /*  
    class Program
    {
        //  错误写法。
        //  说明--写一个方法的注意事项：(1)、一个方法要实现的功能要单一；(2)、方法要避免出现提示用户输入的代码（即：方法要有适用性广的特点）
        static void Main(string[] args)
        {
            int num = numberFunc();
            Console.WriteLine("你输入的数字是：{0}", num);
            Console.ReadKey();
        }
        
        public static int numberFunc() {
            bool flag = true;
            int num = 0;
            do
            {
                Console.Write("请输入一个数字：");                
                flag = Int32.TryParse(Console.ReadLine(), out num);
            } while (!flag);
            return num;
        }        
        =====================================================================================
        public static int _number;  //  设置一个静态变量，接收用户输入的数字
        static void Main(string[] args) 
        {
            while (true)
            {
                Console.Write("请输入一个数字：");
                string str = Console.ReadLine();
                if (judgeNumber(str))
                {
                    Console.WriteLine("你输入的数字是：{0}", _number);
                    break;
                }
                else {
                    Console.WriteLine("输入的不是数字！！！");
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 将字符串转换为数字
        /// </summary>
        /// <param name="num">需要转换的字符串</param>
        /// <returns>返回一个布尔值，转换成功返回true，转换失败返回false。</returns>
        public static bool judgeNumber(string num) {
            bool flag = Int32.TryParse(num, out _number);
            return flag;
        }
    }
    ====================================================================================
    //  练习2、查找两个整数中的最大值：int Max(int i1,int i2)
    class Program {
        static void Main(string[] args) {
            int num1, num2;
            Console.Write("请输入第一个整数：");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第二个整数：");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("两个整数中的最大值为：{0}", Max(num1, num2));
            Console.ReadKey();
        }

        /// <summary>
        /// 计算两个整数中的最大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回两个整数中的最大值</returns>
        public static int Max(int n1, int n2) {
            int num = n1 > n2 ? n1 : n2;
            return num;
        }
    }
    ============================================================================
    //  练习3、让用户输入yes或no，若输入不是yes或no，则重新输入
    class Program 
    {
        static void Main(string[] args) 
        {
            while (true) {
                Console.Write("请输入yes或no：");
                string str = Console.ReadLine();
                if (IsYesOrNo(str))
                {
                    Console.WriteLine("你输入的是：{0}", str);
                    break;
                }
                else {
                    Console.WriteLine("你输入的不是yes或no！！");
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 判断用户输入是否是yes或no
        /// </summary>
        /// <param name="input">用户输入的字符串</param>
        /// <returns>返回判断的结果，是则返回true，不是则返回false</returns>
        public static bool IsYesOrNo(string input)
        {
            if (input == "yes" || input == "no")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
    */
    #endregion
    //  练习4、计算输入数组的和
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNums = { 2, 43, 7, 19, 29, 6, 34 };
            Console.WriteLine("数组的和为：{0}", sumArray(myNums));
            Console.ReadKey();
        }
        /// <summary>
        /// 计算一个整数数组的和
        /// </summary>
        /// <param name="nums">想要计算的整数数组</param>
        /// <returns>返回数组所有元素的和</returns>
        public static int sumArray(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++) {
                sum += nums[i];
            }

            return sum;
        }
    }
}
