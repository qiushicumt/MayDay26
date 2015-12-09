using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LiShiZhuanHuan
{
    class Student:Person
    {
        int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }
        public Student(string name, int age, int ID):base(name, age)
        {
            this.Id = ID;
        }
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
}
