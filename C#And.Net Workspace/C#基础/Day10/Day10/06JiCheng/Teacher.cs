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

        public void Teach()
        {
            Console.WriteLine("老师会教书");
        }
    }
}
