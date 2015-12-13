using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DuoTai
{
    class Person
    {
        string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public Person(string name)
        {
            this.Name = name;
        }
        //  将父类的方法设置为虚函数
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
}
