﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06JiCheng
{
    class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        //  父类自定义一个带参数的构造函数
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
    }
}
