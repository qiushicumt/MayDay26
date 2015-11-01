using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch-case：多条件的定值判断的分支结构。对条件进行判断，根据的到的不同结果，执行对应的case的语句
            /*
            //示例代码：
            //李四的年终工作评定,如果定为A级,则工资涨500元,如果定为B级,则工资涨200元,
            //如果定为C级,工资不变,如果定为D级工资降200元,如果定为E级工资降500元.
            //设李四的原工资为5000,请用户输入李四的评级,然后显示李四来年的工资.
            string score;
            decimal salary = 5000m;
            bool flag = true;
            Console.Write("请输入李四的年终评级：");
            score = Console.ReadLine();
            switch (score) { 
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C":
                    salary += 0;
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("输入的等级错误，退出程序！");
                    flag = false;
                    break;
            }
            if(flag)
                Console.WriteLine("李四来年的工资是：{0}", salary);
            Console.ReadKey();
            
            //  练习1、让用户输入姓名,然后显示出这个人上辈子是什么职业。（老杨,老苏,老邹,老马,老虎,老牛,老蒋,小杨）
            Console.Write("请输入姓名：");
            string name = Console.ReadLine();
            switch (name) {
                case "老杨":
                    Console.WriteLine("{0}上辈子是大夫。",name);
                    break;
                case "老苏":
                    Console.WriteLine("{0}上辈子是掌柜。", name);
                    break;
                case "老邹":
                    Console.WriteLine("{0}上辈子是教书先生。", name);
                    break;
                case "老马":
                    Console.WriteLine("{0}上辈子是仵作。", name);
                    break;
                case "老虎":
                    Console.WriteLine("{0}上辈子是师爷。", name);
                    break;
                case "老牛":
                    Console.WriteLine("{0}上辈子是将军。", name);
                    break;
                case "老蒋":
                    Console.WriteLine("{0}上辈子是书生。", name);
                    break;
                case "小杨":
                    Console.WriteLine("{0}上辈子是农夫。", name);
                    break;
                default:
                    Console.WriteLine("不认识这个人！");
                    break;
            }
            Console.ReadKey();
            
            //  练习2、根据输入的成绩进行评测，成绩>=90 ：A； 90>成绩>=80 ：B； 80>成绩>=70 ：C； 70>成绩>=60 ：D； 成绩<60   ：E
            Console.Write("请输入你的成绩：");
            int score;
            bool flag = true;
            try
            {
                score = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的成绩的格式不正确！");
                flag = false;            
            }
            if(flag) 
            {
                //  score原本为区间数值（90~80），当score/10后，得到的就是一个定值，即可以用于switch-case语句
                switch (score / 10)
                {
                    case 10:
                        Console.WriteLine("你的成绩是A！");
                        break;
                    case 9:
                        Console.WriteLine("你的成绩是A！");
                        break;
                    case 8:
                        Console.WriteLine("你的成绩是B！");
                        break;
                    case 7:
                        Console.WriteLine("你的成绩是C！");
                        break;
                    case 6:
                        Console.WriteLine("你的成绩是D！");
                        break;
                    default:
                        Console.WriteLine("你的成绩是E！");
                        break;
                }
            }
            Console.ReadKey();
            */
            //  练习3、请输入年份，然后输入月份，最后根据输入的月份，输出该月的天数（考虑闰年的2月）
            int year=0, month=0;
            bool flag = true;
            try
            {
                Console.Write("请输入年份：");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入月份：");
                month = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的日期的格式不正确！");
                flag = false;
            }
            if (flag)
            {
                if ((year % 400 == 0) ||((year % 4 == 0) && (year % 100 != 0)))                
                {                    
                    switch (month) { 
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("{0}年的{1}月共有31天！", year, month);
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("{0}年的{1}月共有30天！", year, month);
                            break;
                        case 2:
                            Console.WriteLine("{0}年的{1}月共有29天！", year, month);
                            break;
                        default:
                            Console.WriteLine("没有这个月份！");
                            break;
                    }
                }
                else
                {                   
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("{0}年的{1}月共有31天！", year, month);
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("{0}年的{1}月共有30天！", year, month);
                            break;
                        case 2:
                            Console.WriteLine("{0}年的{1}月共有28天！", year, month);
                            break;
                        default:
                            Console.WriteLine("没有这个月份！");
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
