using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07JiCheng_Practise
{
    class Person
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

        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
}
