using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LiShiZhuanHuan
{
    class Teacher:Person
    {
        decimal _salary;
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Teacher(string name, int age, decimal salary):base(name, age)
        {
            this.Salary = salary;
        }

        public void TeacherSayHello()
        {
            Console.WriteLine("我是教师");
        }
    }
}
