using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Partial
{
    //  partial修饰Person类，Person类变为部分类
    public class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
