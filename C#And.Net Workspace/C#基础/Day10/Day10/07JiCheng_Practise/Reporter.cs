using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07JiCheng_Practise
{
    class Reporter:Person
    {
        string _hobby;

        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }

        public Reporter(string name, int age, char gender, string hobby)
            : base(name, age, gender)
        {
            this.Hobby = hobby;
        }

        public void SayHello()
        {
            Console.WriteLine("我是{0}，我是一名{1}狗仔，今年{2}岁，我的爱好是{3}", this.Name, this.Gender, this.Age, this.Hobby);
        }
    }
}
