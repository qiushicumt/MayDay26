using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Interface
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

        public char Gender
        {
            get;
            set;
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
}
