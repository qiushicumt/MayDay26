using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Params
{
    //  params参数用于可变参数组，当声明的一个方法中的参数为一个数组，并且数组被params修饰时。方法在被调用的时候，可以给这个可变参数组传递跟数组类型相同的实参，而不必传递一个数组
    //  例如：public  static void MyFunc(string name, params int[] nums) 方法
    //  调用此方法：MyFunc("张三", 20, 30, 40)   //  可以给nums传递多个int实参，而不必传递一个数组

    //  示例代码  计算可变数组的最大值、最小值、总和、平均值
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum, minNum, sum, avg;
            string str = "Frank";
            GetMaxMinSumAvg(str, out maxNum, out minNum, out sum, out avg, 12, 24, 31, 46, 58);
            Console.WriteLine("String is:{0}，数组中最大值为：{1}，最小值为：{2}，总和为：{3}，平均值为：{4}", str, maxNum, minNum, sum, avg);
            Console.ReadKey();
        }

        /// <summary>
        /// 得到数组中的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="n">string类型变量</param>
        /// <param name="max">int类型变量</param>
        /// <param name="min">int类型变量</param>
        /// <param name="sum">int类型变量</param>
        /// <param name="avg">int类型变量</param>
        /// <param name="nums">int类型的可变参数组</param>
        public static void GetMaxMinSumAvg(string n, out int max, out int min, out int sum, out int avg, params int[] nums)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            n = "张三";
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }
    }
}
