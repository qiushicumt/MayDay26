using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06JiCheng
{
    class Student:Person
    {        
        int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            this.ID = id;
        }

        public void Study()
        {
            Console.WriteLine("学生会学习！");
        }
    }
}
