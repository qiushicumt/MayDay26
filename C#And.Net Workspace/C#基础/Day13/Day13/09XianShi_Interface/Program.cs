using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09XianShi_Interface
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Bird birdOne = new Bird();
            //  此处调用子类自身定义的Fly方法
            birdOne.Fly();              
                
            IFlyable birdTwo = new Bird();
            //  此处调用接口的方法，接口的方法是由子类实现的，所以可以被调用
            birdTwo.Fly();


            Console.ReadKey();
        }
    }
}
