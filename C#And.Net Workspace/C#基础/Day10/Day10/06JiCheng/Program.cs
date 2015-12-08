using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06JiCheng
{
    //  继承，是几个类当中具有相同一些相同的功能的代码时，将这些相同功能的代码集中封装在一个类中，作为父类，可以由子类继承这些属性和方法
    //  子类声明时，在子类名后加上 :父类名  可以继承父类
    //  子类继承的是父类的public的属性、方法， 但是子类不能继承父类的私有成员变量
    //  继承的特性：  1、单根性   子类只能继承一个父类
    //              2、传递性   子类能继承父类，也能继承父类的父类  
    //  注：1、子类不能继承父类的构造函数
    //      2、子类在创建实例对象的时候，会现在内部生成一个父类的对象，然后才能够实现对父类的属性、方法的调用
    //      3、当父类存在自定义构造函数时，原本的无参数构造函数会被覆盖。此时，子类需要调用父类的带参数的构造函数，通过在子类的构造函数后加上:base()
    //      4、当子类与父类存在同名的成员变量时，子类的同名成员会把父类的同名成员隐藏掉。或者，使用new关键字修饰子类的同名成员，同样可以隐藏父类的同名成员
    class Program
    {
        static void Main(string[] args)
        {
            //Student studentOne = new Student();
            //  Name、Age属性都是从父类继承来的
            //studentOne.Name = "张三";
            //studentOne.Age = 19;

            Student oneStudent = new Student("张三", 19, '男', 0203843);

        }
    }
}
