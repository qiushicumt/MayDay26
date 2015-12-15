using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface_Practise
{
    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
