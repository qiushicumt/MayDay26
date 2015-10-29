using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LuoJiYunSuanFu
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1、逻辑运算符，&&、||和！，分别为与、或、非
            //  当"&&"符号的两侧的表达式都为true时，整个表达式的结果为true，若有一个为false，则整个表达式结果为false
            //  当"||"符号的两侧的表达式都为false时，整个表达式的结果为false，若有一个为true，则整个表达式结果为true
            //  "!"表示取反
            //  练习：让用户输入老苏的语文和数学成绩，输出以下判断是否正确，正确则输出true，错误则输出false
            
            Console.WriteLine("你好，老苏，请输入你的语文成绩和数学成绩");
            Console.Write("请输入你的语文成绩：");
            int myChinese = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入你的数学成绩：");
            int myMath = Convert.ToInt32(Console.ReadLine());
            /*
            //  (1)、老苏的语文和数学成绩都大于90分
            if (myChinese > 90 && myMath > 90) {
                Console.WriteLine("True");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("False");
                Console.ReadKey();
            }
             */
            //  (2)、语文和数学有一门的成绩是大于90分的      
            if (myChinese > 90 || myMath > 90) {
                Console.WriteLine("True");
                Console.ReadKey();
            } 
            else {
                Console.WriteLine("False");
                Console.ReadKey();
            }           
        }
    }
}
