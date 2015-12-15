using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09XianShi_Interface
{
    //  显式实现接口  当子类自己的方法与继承的接口的方法出现重名时，通过显式实现接口，可以在子类中保留这两个同名方法
    //  语法：返回类型 接口名.方法

    //  在Bird类中，声明一个与接口同名的方法
    public class Bird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
        //  在接口的方法前使用 “接口名.” 可显式实现接口的Fly方法
        //  在子类中显式实现接口的方法时，不需要在方法前添加任何访问修饰符
        void IFlyable.Fly()
        {
            Console.WriteLine("接口中的鸟会飞");
        }
    }
}
