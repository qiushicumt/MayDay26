using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Abstract_Class
{
    //  抽象类，是可以实现多态的另一种办法，在父类的方法不知如何具体实现时，将父类设置为抽象类
    //  在声明父类的时候，加上修饰符abstract，同时，将方法设置为抽象方法
    //  抽象类不能被实例化，抽象类包含抽象的方法和抽象的访问器，抽象类也可以包含非抽象的成员
    //  抽象类的派生类必须实现基类中的所有的抽象成员
    //  抽象成员必须存在于抽象类中，不能存在于非抽象类中
    //  派生类也为抽象类时，可以不重写父类的抽象成员
    class Program
    {
        static void Main(string[] args)
        {
            Animal animalCat = new Cat();
            animalCat.Bark();       //  父类类型的变量调用的是子类Cat的Bark方法
            Animal animalDog = new Dog();
            animalDog.Bark();

            Console.ReadKey();
        }
    }
}
