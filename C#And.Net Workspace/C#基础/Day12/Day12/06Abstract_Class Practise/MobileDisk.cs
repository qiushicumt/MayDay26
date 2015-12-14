using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Abstract_Class_Practise
{
    public class MobileDisk:MobileStorages
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘正在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘正在写入数据");
        }
    }
}
