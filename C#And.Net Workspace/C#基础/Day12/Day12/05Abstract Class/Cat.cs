using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Abstract_Class
{
    //  子类继承抽象父类，必须在子类中实现父类的抽象方法，方法前添加override修饰符
    public class Cat:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫是喵喵叫");
        }
    }
}
