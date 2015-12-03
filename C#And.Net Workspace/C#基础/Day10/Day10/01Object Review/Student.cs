using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Object_Review
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

            set
            {
                _name = value;
            }
        }
        
        public Student(string name)
        {
            this.Name = name;
        }        
    }
}
