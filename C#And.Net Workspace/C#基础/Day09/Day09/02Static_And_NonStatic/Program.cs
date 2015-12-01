using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Static_And_NonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person onePerson = new Person();
            onePerson.M1();     //  实例对象只能调用实例方法(非静态)

            Person.M2();        //  非静态方法必须通过类进行调用

            Console.ReadKey();
        }
    }
}
