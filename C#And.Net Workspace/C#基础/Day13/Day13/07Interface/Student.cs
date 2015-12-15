using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Interface
{
    public class Student:Person, Info
    {
        public Student(string name, int age, char gender):base(name, age, gender)
        {

        }
        //   实现接口的两个方法GetName和GetAge
        public string GetName()
        {
            return this.Name;
        }

        public int GetAge()
        {
            return this.Age;
        }
    }
}
