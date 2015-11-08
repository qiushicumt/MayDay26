using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  数组用于一次性声明多个类型相同的变量
            //  语法： 数组类型[] 数组名 = new 数组类型[数组长度]
            //  例： int[] nums = new int[8];     //  声明一个int类型的数组，数组名为nums，数组长度为8
            //  另一种声明方式： int[] nums2 = {2,5,8,12,20};
            //  在声明一个数组的时候，程序默认为数组中的每一个元素赋初值0
            //  数组中的每一个元素的值都存储在内存为数组开辟的空间中，通过数组下标可以访问到数组中的元素，数组的下标是从0开始的。
            //  例： nums[3] = 12;    //  表示给数组中的第四个元素赋值为12。
            //  for循环可以用于对数组赋值和取值
            int[] nums = new int[10];
            for (var i = 0; i < nums.Length; i++) {
                nums[i] = i;
            }
            for (var i = 0; i < nums.Length / 2; i++) {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
            
            //  练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值
            int[] numbers = { 12, 3, 5, 8, 18, 22 };
            Console.WriteLine("数组中最大数是：{0}", numbers[5]);
            Console.WriteLine("数组中最小数是：{0}", numbers[1]);
            Console.WriteLine("数组中所有数字的和为：{0}", numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5]);
            Console.WriteLine("数组中所有数字的平均值为：{0}", (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5]) / 6.0);
            Console.ReadKey();                        //  练习2：计算一个整数数组的所有元素的和。
            int[] numbers = new int[8];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 2 + 4;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];            }
            Console.WriteLine("数组里所有数字的和为：{0}", sum);
            Console.ReadKey();                        //  练习3:数组里面都是人的名字,分割成:例如:老杨|老苏|老邹…”            //  (老杨,老苏,老邹,老虎,老牛,老蒋,老王,老马)            //  string[] names={"张三","李四","王五","赵六"};            //  张三|李四|王五|赵六

            //  提取成新的字符串
            string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老蒋", "老王", "老马" };
            string myStr = "";
            for (int i = 0; i < names.Length; i++ ) {
                myStr += names[i];
                if (i == names.Length - 1) {
                    break;
                }
                myStr += "|";
            }
            Console.WriteLine(myStr);
            Console.ReadKey();
            
            //  分割成新的数组
            string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老蒋", "老王", "老马" };
            string[] newNames = new string[names.Length * 2 - 1];
            for (int i = 0, j = 0; i < newNames.Length && j < names.Length; i++) {
                newNames[i] = names[j];
                i++;
                j++;
                if(i<newNames.Length)
                    newNames[i] = "|";
            }
            for (int i = 0; i < newNames.Length; i++) {
                Console.Write(newNames[i]);            }
            Console.ReadKey();                        //  练习4：将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素的值加1，如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。
            int[] numbers = { -2, 3, 10, 0, -4, 12, 22 };
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > 0) {
                    numbers[i] += 1;                }
                else if (numbers[i] < 0)
                {
                    numbers[i] -= 1;
                }
                else {
                    numbers[i] = 0;                }            }
            for (int i = 0; i < numbers.Length; i++) {                 Console.Write(numbers[i] + ",");             }
            Console.ReadKey();            */            //  练习5：将一个字符串数组的元素的顺序进行反转。{“我”,“是”,”好人”} {“好人”,”是”,”我”}。第i个和第length-i-1个进行交换。

        }
    }
}
