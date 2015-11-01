using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //  while循环。当while条件被满足时，执行while代码块中的语句
            //  执行完语句以后，继续判断while条件是否成立，成立则继续进入while代码块中执行语句。
            //  只有当while条件不成立时才会跳出while循环体

            /*
            //  示例代码
            //  打印输出100遍“下次考试我一定要细心！”
            int num = 0;
            while (num < 100)   //  循环条件
            {
                Console.WriteLine("下次考试我一定要细心！\t{0}", num);
                num++;          //  用于改变循环条件的语句，若不含此语句，程序容易进入死循环
            }
            Console.ReadKey();
            
            //  练习1、求1~100之间所有偶数的和
            int num = 1, sum = 0;
            while (num <= 100) {
                if (num % 2 == 0)
                    sum += num;
                num++;
            }
            Console.WriteLine("1~100之间所有偶数的和为：{0}", sum);
            Console.ReadKey();
            
            //  练习2、输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            Console.Write("请输入班级人数：");
            int peopleNum = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            double score = 0;
            while (i <= peopleNum)
            {
                Console.Write("请输入第{0}个学员的成绩：", i);
                score += Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine("{0}个学员的总成绩为：{1}，平均成绩为：{2}。",peopleNum, score, (score/peopleNum));
            Console.ReadKey();
            
            //练习3、老师问学生,这道题你会做了吗?如果学生答"会了(y)",则可以放学.如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
            //--直到学生会为止,才可以放学。  --直到学生会或老师给他讲了10遍还不会,都要放学。
            int num = 0;
            while (num < 10) {
                Console.WriteLine("这道题你会做了吗？");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    break;      //  此处利用break语句跳出整个while循环
                }
                else {
                    num++;
                }
            }
            Console.WriteLine("可以放学了！");
            Console.ReadLine();
            */
            //  练习4、2006年培养学员80000人，每年增长25%，请问按此增长速度，到哪一年培训学员人数将达到20万人？
            int year = 2006;
            double num = 80000;
            while (num <= 200000) {
                num *= 1.25;
                year++;
            }
            Console.WriteLine("到{0}年培训学员人数达到20万人，人数为：{1}", year, num);
            Console.ReadKey();
        }
    }
}
