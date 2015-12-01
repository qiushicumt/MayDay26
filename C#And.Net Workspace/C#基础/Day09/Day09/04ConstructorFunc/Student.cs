using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ConstructorFunc
{
    public class Student
    {
        string _name;
        int _age;
        char _gender;
        int _chinese, _math, _english;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get
            {
                if (_age < 0)
                    return _age = 0;
                if (_age > 100)
                    return _age = 100;
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value != '男' && value != '女')
                    value = '男';
                _gender = value;
            }
        }
        public int Chinese
        {
            get { return _chinese; }
            set
            {
                if (value < 0)
                    value = 0;
                if (value > 100)
                    value = 100;
                _chinese = value;
            }
        }
        public int Math
        {
            get { return _math; }
            set
            {
                if (value < 0)
                    value = 0;
                if (value > 100)
                    value = 100;
                _math = value;
            }
        }
        public int English
        {
            get { return _english; }
            set
            {
                if (value < 0)
                    value = 0;
                if (value > 100)
                    value = 100;
                _english = value;
            }
        }

        //  声明构造函数
        //  1、带参数的构造函数，传入的参数被直接赋值给对象的属性
        public Student(string name, char gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        //  2、重载一个带参数的构造函数
        public Student(string name, char gender, int age, int chinese, int math, int english)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我是{1}生，今年{2}岁", this.Name, this.Gender, this.Age);
        }
        public void ShowScore()
        {
            Console.WriteLine("我的总成绩是：{0}，平均成绩是：{1}.", this.Chinese + this.Math + this.English, (this.Chinese + this.Math + this.English) / 3);
        }
    }
}
