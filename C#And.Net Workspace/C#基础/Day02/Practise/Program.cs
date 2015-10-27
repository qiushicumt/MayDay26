using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  练习1、根据输入的天数（46），输出是几周几天
            int day = 46;
            int oWeek, oDay;
            oWeek = day / 7 + 1;
            oDay = day % 7;
            Console.WriteLine("46天是第{0}周第{1}天", oWeek, oDay);
            Console.ReadKey();
            */
            //  练习2、编程实现107653秒是几天几小时几分几秒
            int oTime = 187653;
            int oDay, oHour, oMinute, oSecond;
            int temp;
            oSecond = oTime % 60;
            temp = oTime / 60;
            oMinute = temp % 60;
            temp = temp / 60;
            oHour = temp % 24;
            temp = temp / 24;
            oDay = temp % 24;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒",oTime,oDay,oHour,oMinute,oSecond);
            Console.ReadKey();
        }
    }
}
