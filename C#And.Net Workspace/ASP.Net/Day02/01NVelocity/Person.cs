using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01NVelocity
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

        public Person Dad
        {
            get;
            set;
        }
    }
}