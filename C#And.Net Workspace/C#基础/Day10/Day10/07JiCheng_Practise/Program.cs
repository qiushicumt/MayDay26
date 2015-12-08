using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07JiCheng_Practise
{
    //  写一个Reporter类和一个Programmer类, Driver类,他们都有一个打招呼的方法,
    //  记者：我是记者  我的爱好是偷拍 我的年龄是34 我是一个男狗仔
    //  司机：我叫舒马赫 我的年龄是43 我是男人  我的驾龄是 23年
    //  程序员：我叫孙全 我的年龄是23 我是男生 我的工作年限是 3年
    //  不同的是 Reporter 打招呼是说"大家好,我叫XX,,我的爱好是XXX", 
    //  Programmer 的打招呼的方法是说"大家好,我叫XX,我今年XX岁了,我已经工作XX年了"?
    class Program
    {
        static void Main(string[] args)
        {
            Programmer zs = new Programmer("李雷", 24, '男', 2);
            zs.SayHello();

            Reporter xiaobai = new Reporter("记者", 34, '男', "摄影");
            xiaobai.SayHello();

            Driver zhaosi = new Driver("赵四", 40, '男', 10);
            zhaosi.SayHello();

            Console.ReadKey();
        }
    }
}
