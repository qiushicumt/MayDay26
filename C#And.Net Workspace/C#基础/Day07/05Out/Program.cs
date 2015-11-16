using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //  out参数。当需要在一个方法中返回多个不同类型的变量值时，可以使用out参数
            //  示例代码，计算一个数组中的最大值、最小值、总和、平均值
            int[] nums = {2,4,21,14,33,46,52};
            int max, min, sum, avg;
            GetMaxMinSumAvg(nums, out max, out min, out sum, out avg);
            Console.WriteLine("数组中的最大值是：{0}，最小值是：{1}，总和是：{2}，平均值是：{3}！", max, min, sum, avg);
            Console.ReadKey();
        }

        public static void GetMaxMinSumAvg(int[] nums, out int max, out int min, out int sum, out int avg) {
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > max) {
                    max = nums[i];
                }
                if (nums[i] < min) {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }
    }
}
