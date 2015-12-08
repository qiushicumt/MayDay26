using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06JiCheng
{
    class Teacher:Person
    {       
        int _salary;
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        //  子类需要定义构造函数，并显式调用父类的构造函数
        public Teacher(string name, int age, char gender, int salary):base(name, age, gender)
        {
            this.Salary = salary;
        }

        public void Teach()
        {
            Console.WriteLine("老师会教书");
        }
    }
}
