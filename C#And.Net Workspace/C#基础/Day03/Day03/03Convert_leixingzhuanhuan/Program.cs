using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Convert_leixingzhuanhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  1、convert类型转换
            //  显式类型转换、隐式类型转换   两个类型必须是兼容的
            //  double-->int(显式类型转换)    int-->double(隐式类型转换)
            //  当两个数据类型不兼容时，使用Convert对象的方法进行转换，如string-->double，使用Convert.ToDouble()方法
            string str1 = "32131";
            double d = Convert.ToDouble(str1);                       
            Console.WriteLine(d*2.0);

            Console.Write("请输入数字：");
            string str2 = Console.ReadLine();
            int num = Convert.ToInt32(str2);
            Console.WriteLine(num);
            Console.ReadKey();    
            */

            //  练习1、让用户输入姓名，然后输入语文、数学、外语三门课的成绩
            //        输出显示：XX，你的总成绩为xx分，平均分为xx
            Console.Write("请输入你的姓名：");
            string oName = Console.ReadLine();
            Console.Write("请输入你的语文成绩：");
            int yuwen = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入你的数学成绩：");
            int shuxue = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入你的英语成绩：");
            int yingyu = Convert.ToInt32(Console.ReadLine());
            int total = yuwen + shuxue + yingyu;
            double pingjun = total / 3.0;
            Console.WriteLine("{0}，你的总成绩为{1}分，平均分为{2:f2}", oName, total, pingjun);  //  {2:f2}，:f2用于表示保留两位小数，或者使用{2:0.00}
            Console.ReadKey();
        }
    }
}
