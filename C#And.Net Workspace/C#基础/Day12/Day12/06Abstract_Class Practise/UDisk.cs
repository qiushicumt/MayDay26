using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Abstract_Class_Practise
{
    public class UDisk:MobileStorages
    {
        public override void Read()
        {
            Console.WriteLine("U盘正在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘正在写入数据");
        }
    }
}
