using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Virtual_Func_Practise
{
    class Manager:Employee
    {
        public override void DaKa()             //  重写与父类同名的方法
        {
            Console.WriteLine("经理11点打卡");
        }
    }
}
