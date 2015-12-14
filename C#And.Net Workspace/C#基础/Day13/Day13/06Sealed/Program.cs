using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Sealed
{
    //  密封类，完全被封闭的类，由sealed关键字修饰
    //  sealed修饰的密封类，不能够被继承，但是可以继承别的类
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("我的名字是：{0}", this.Name);
        }
    }
    public sealed class Student : Person
    {
        int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void MySayHello()
        {
            Console.WriteLine("我的年龄是：{0}", this.Age);
        }
    }
    /*
    public class LittleStudent : Student        //  无法从密封类继承
    {
    }
     * */
}
