using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ArrayList
{
    class Person
    {
        int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

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

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public void PersonSayHi()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁", this.Name, this.Age);
        }
    }
}
