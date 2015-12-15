using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface_Practise
{
    public class Student : Person, IComparable
    {
        int _Id;
        public int ID
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public Student(string name, int age, int id):base(name, age)
        {
            this.ID = id;
        }
        //  实现IComparable接口的CompareTo方法
        //  实现了CompareTo方法后，Array.Sort()方法可以用于Student类进行排序
        public int CompareTo(object obj)
        {
            Student studentOne = (Student)obj;
            if (this.Age > studentOne.Age)
                return 1;
            if (this.Age < studentOne.Age)
                return -1;
            return 0;
        }
    }
}
