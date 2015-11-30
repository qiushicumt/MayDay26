using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Lei_ZiDuan_ShuXing
{
    class People
    {
        //  声明People类的字段(成员变量),类的成员变量在默认情况下是private访问属性
        string _name;
        int _age;
        char _gender;

        //  声明类的属性
        //  类的属性中，get方法是当获取对象的变量值时被调用，set方法则是在设置对象的变量值时被调用
        //  可以在get方法或者set方法中对字段进行设置相关的限制条件
        public string Name
        {
            get { return _name; }
            set { _name = value; }      //  value为对字段设置值时所设置的值
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
        public int Age
        {
            get     //  在get方法中对_age进行限制
            {
                if (_age < 0)
                    _age = 0;
                if (_age > 100)
                    _age = 100;
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        //  声明People类的方法
        public void Show()
        {
            Console.WriteLine("我是{0}，我是{1}生，我今年{2}岁。", this.Name, this.Gender, this.Age);
        }

    }
}
