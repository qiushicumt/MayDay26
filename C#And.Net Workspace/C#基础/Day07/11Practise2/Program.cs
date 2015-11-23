using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Practise2
{
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
}
