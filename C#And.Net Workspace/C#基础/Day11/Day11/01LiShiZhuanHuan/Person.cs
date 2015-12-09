using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LiShiZhuanHuan
{
    class Person
    {
        string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public void PersonSayHello()
        {
            Console.WriteLine("我是父类，我叫{0}，今年{1}岁", this.Name, this.Age);
        }
    }
}
