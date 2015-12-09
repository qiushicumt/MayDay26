using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LiShiZhuanHuan
{
    //  里氏转换原则
    //  1、子类可以赋值给父类--子类的实例对象可以直接赋值给父类变量
    //  当子类实例对象赋值给父类的变量时，子类实例对象可以将父类的数据填满，多余的数据可以不处理，程序不会报错
    //  但是，若把父类实例对象直接赋值给子类的变量，父类的实例对象无法将子类所需数据填满，所以不可以这样赋值，程序会报错

    //  2、当一个父类的实例变量存储的是子类的对象时，可以将此父类实例变量强转为子类类型的实例变量

    //  3、is：用于判断是否能够进行类型转换，能转换，则返回true，不能转换，则返回false，写法如 objA is objB
    //      as：用于判断是否能够进行类型转换，能转换，则返回转换后的对象，不能转换，则返回null，写法如 objA as objB
    class Program
    {
        static void Main(string[] args)
        {
            Teacher oneTeacher = new Teacher("李雷", 28, 3500);
            Person p = oneTeacher;
            p.PersonSayHello();
            if(p is Teacher)
            {
                Console.WriteLine("可以转换");
            }
            else
            {
                Console.WriteLine("不可以转换");
            }

            Person p2 = new Student("韩梅梅", 18, 05164);
            //Teacher t2 = (Teacher)p2;           
            //t2.PersonSayHello();
            Teacher t2 = p2 as Teacher;     //  p2不能转换为Teacher类，所以返回null，即t2=null
            Student s2 = (Student)p2;       //  将父类变量的类型强转为子类类型，只能强转为所存储的那个子类的类型
            s2.PersonSayHello();

            Console.ReadKey();
        }
    }
}
