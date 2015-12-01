using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ConstructorFunc
{
    //  构造函数
    //  作用：构造函数用于初始化实例对象。在声明一个类的实例对象后，程序调用类的构造函数对这个实例对象进行初始化，即给对象的属性进行赋值
    //  定义：构造函数名称与类名相同。构造函数可以有参数，但是构造函数没有返回值，也不需要写void返回类型。
    //  注:1、声明一个类后，若不声明构造函数，系统会默认自动生成一个空的构造函数，在声明一个实例对象时，会调用这个默认的构造函数
    //     2、声明自己的构造函数后，系统默认的构造函数就会被覆盖掉。
    //     3、构造函数可以进行重载，即可以在类中重载多个构造函数
    //     4、构造函数必须设置为public访问类型，因为想要成功声明一个类的实例对象，必须有一个可被访问调用的构造函数
    class Program
    {
        static void Main(string[] args)
        {
            Student zsStudent = new Student("张三", '男', 16);     //  调用Student类中的含有3个参数的构造函数
            zsStudent.Chinese = 82;
            zsStudent.Math = 94;
            zsStudent.English = 88;
            zsStudent.SayHello();
            zsStudent.ShowScore();

            Student hmmStudent = new Student("韩梅梅", '女', 17, 89, 81, 90);     //  调用Student类中的含有6个参数的构造函数
            hmmStudent.SayHello();
            hmmStudent.ShowScore();

            Console.ReadKey();
        }
    }
}
