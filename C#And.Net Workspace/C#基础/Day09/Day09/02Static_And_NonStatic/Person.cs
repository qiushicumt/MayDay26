using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Static_And_NonStatic
{
    //  非静态的类中，可以有静态成员也可以有非静态成员
    //  在通过实例化的类的对象来调用方法的时候，可以使用.调用非静态的方法，不能调用静态的方法
    //  类的静态成员的调用，必须通过类名.静态成员名的方式进行调用
    //  注：静态成员的调用，只能通过类名进行调用，不能通过对象名进行调用。
    //     实例成员的调用，只能通过对象名进行调用，不能通过类名进行调用。
    
    public class Person
    {
        static string _name;
        int _age;

        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //  实例方法既可以访问类的静态成员变量，也可以访问类的非静态成员变量
        public void M1()    
        {
            //_age = 21;
            //_name = "21";
            Console.WriteLine("我是实例方法");
        }
        //  静态方法只能访问类的静态成员变量，不能访问类的非静态成员变量
        public static void M2()
        {
            //  _name = "dwa";
            Console.WriteLine("我是静态方法");
        }
    }
}
