using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Practise2
{
    /*
    //  练习5、接收用户的输入后，根据用户的输入判断用户等级并输出
    //  优(90~100)、良(80~89)、中(70~79)、及格(60~69)、不及格(0~59)
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.Write("请输入你的成绩得分(0~100)：");
            try {
                score = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("你输入的不是一个有效的成绩分数，程序退出！");
            }
            string str = JudgeScore(score);
            Console.WriteLine("你的成绩等级是：{0}", str);
            Console.ReadKey();
        }
        /// <summary>
        /// 对成绩分数的等级进行判断
        /// </summary>
        /// <param name="score">传入一个int型的成绩分数</param>
        /// <returns>返回一个string类型的成绩等级</returns>
        public static string JudgeScore(int score)
        {
            switch (score/10)
            {
                case 10:
                case 9:
                    return "优";
                case 8:
                    return "良";
                case 7:
                    return "中";
                case 6:
                    return "及格";
                default:
                    return "不及格";
            }
        }
    }
    
    //  练习6、请将字符串数组{'中国','美国','巴西','澳大利亚','加拿大'}中的内容反转
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            SortString(ref countries);
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine(countries[i]);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 将字符串数组中的内容反转
        /// </summary>
        /// <param name="strs">被反转的string类型数组</param>
        public static void SortString(ref string[] strs)
        {
            for (int i = 0; i < strs.Length/2; i++)
            {
                string temp = strs[i];
                strs[i] = strs[strs.Length - i - 1];
                strs[strs.Length - i - 1] = temp;
            }
        }
    } 

    //  练习7、写一个方法计算圆的面积和周长
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入圆的半径：");
            double area = 0.00, circum = 0.00;
            int r = 0;
            try
            {
                r = Convert.ToInt32(Console.ReadLine());
                JiSuan(r, out area, out circum);
                Console.WriteLine("圆的半径为：{0}，周长为：{1}，面积为：{2}", r, circum, area);
            }
            catch
            {
                Console.WriteLine("输入的不是一个有效的数字，程序退出！");
            }
            Console.ReadKey();
        }
        public static void JiSuan(int r, out double area, out double circum)
        {
            area = Math.PI * r * r;
            circum = 2 * Math.PI * r;
        }
    }
    */
    //  练习8、将一个字符串数组输出为|分割的形式，如"梅西|苏亚雷斯|内马尔"
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "梅西", "苏亚雷斯", "内马尔" };
            string[] names2 = { "C罗", "笨马", "大圣", "水爷", "猴子", "学霸", "魔笛" };
            string name = FenGe(names);
            string name2 = FenGe(names2);
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.ReadKey();
        }

        public static string FenGe(string[] strs)
        {
            string str = "";
            for (int i = 0; i < strs.Length-1; i++)
            {
                str += strs[i];
                str += "|";
            }
            str += strs[strs.Length - 1];
            return str;
        }
    }
}
