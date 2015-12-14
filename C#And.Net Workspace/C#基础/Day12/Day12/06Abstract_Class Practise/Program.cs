using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Abstract_Class_Practise
{
    /*
    //  练习1、求面积和周长
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle oneRect = new Rectangle(20, 12);
            //Circle oneCircle = new Circle(10);
            Sharp oneRect = new Rectangle(20, 12);
            Sharp oneCircle = new Circle(10);
            Console.WriteLine("矩形的周长为：{0}，面积为：{1}", oneRect.zhouchang(), oneRect.area());
            Console.WriteLine("圆的周长为：{0}，面积为：{1}", oneCircle.zhouchang(), oneCircle.area());
            Console.ReadKey();
        }
    }
    */
    //  练习2、模拟移动硬盘、U盘、MP3插入电脑读取和写入数据
    class Program
    {
        static void Main(string[] args)
        {
            MobileStorages msOne = new UDisk();
            Computer oneComp = new Computer();
            oneComp.MS = msOne;                     //  给Computer的属性赋值一个MobileStorages对象  
            oneComp.cpuRead();
            oneComp.cpuWrite();
            Console.ReadKey();
            /*
            //  MobileStorages mobileOne = new MobileDisk();
            MobileStorages mobileOne = new MP3();
            Computer oneCPU = new Computer();
            oneCPU.cpuRead(mobileOne);
            oneCPU.cpuWrite(mobileOne);
            Console.ReadKey();
            */
        }
    }
}
