using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06JiCheng
{
    //  继承，是几个类当中具有相同一些相同的功能的代码时，将这些相同功能的代码集中封装在一个类中，作为父类，可以由子类继承这些属性和方法
    //  子类声明时，在子类名后加上 :父类名  可以继承父类
    //  子类继承的是父类的public的字段、属性、方法， 但是子类不能继承父类的私有成员变量
    //  继承的特性：  1、单根性   子类只能继承一个父类
    //              2、传递性   子类能继承父类，也能继承父类的父类  
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student();
            //  Name、Age属性都是从父类继承来的
            studentOne.Name = "张三";
            studentOne.Age = 19;
        }
    }
}
