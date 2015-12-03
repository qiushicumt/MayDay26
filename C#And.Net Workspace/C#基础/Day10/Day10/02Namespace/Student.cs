using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Namespace
{
    public class Student
    {
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }
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
        public Student(int age)
        {
            this.Age = age;
            this._name = "赵四";
        }
    }
}
