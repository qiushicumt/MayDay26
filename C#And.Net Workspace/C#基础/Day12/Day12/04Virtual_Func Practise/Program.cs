using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Virtual_Func_Practise
{
    /*
    //  练习1、真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫
    class Program
    {
        static void Main(string[] args)
        {
            Realduck oneDuck = new Realduck();
            Woodduck twoDuck = new Woodduck();
            XPDuck threeDuck = new XPDuck();
            Realduck[] ducks = {oneDuck, twoDuck, threeDuck};
            for (int i = 0; i < ducks.Length; i++)
            {
                ducks[i].Buck();
            }
            Console.ReadKey();
        }
    }
    */

    //  练习2、经理11点打卡，员工9点打卡，程序员不打卡
    class Program
    {
        static void Main(string[] args)
        {
            Employee oneEmployee = new Employee();
            Manager oneManager = new Manager();
            Programer oneProgramer = new Programer();
            Employee[] emps = { oneEmployee, oneManager, oneProgramer };
            for (int i = 0; i < emps.Length; i++)
            {
                emps[i].DaKa();
            }
            Console.ReadKey();
        }
    }

}
