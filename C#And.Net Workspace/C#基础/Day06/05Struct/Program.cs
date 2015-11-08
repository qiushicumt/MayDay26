using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Struct
{
    //public struct Person {
    //    public int _age;
    //    public string _name;
    //    public char _gender;
    //}

    public struct MyColor {
        public int _red;
        public int _green;
        public int _blue;
    }

    public enum Gender {
        男,
        女
    }

    public struct Person {
        public string _name;
        public Gender _mygender;
        public int _age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  结构体，用于一次性声明多个不同类型的变量
            //  语法：public struct "结构体名" {字段}    //  在标准语法中，字段名以_开头
            //  结构体内部的变量设置为public时，才可以在结构体外部进行访问，不设置public，则变量只能在结构体内部进行操作

            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 30;
            zsPerson._gender = '男';

            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 28;
            lsPerson._gender = '男';

            Console.WriteLine("张三的年龄是：{0}", zsPerson._age);
            Console.WriteLine("李四的性别是：{0}", lsPerson._gender);
            Console.ReadKey();
             * */
            //  练习1、定义一个结构叫MyColor,有三个成员,分别定义为int类型的red,green,blue            //        声明一个 MyColor类型的变量,并对其成员赋值.使MyColor可以表示成一个红色.
            MyColor myColor;
            myColor._blue = 0;
            myColor._green = 0;
            myColor._red = 255;

            Console.WriteLine("MyColor is: blue {0}, green {1}, red {2}", myColor._blue, myColor._green, myColor._red);
            Console.ReadKey();

            //  练习2、定义一个结构类型Person,有三个成员,分别为姓名,性别,年龄 性别用枚举类型            //  声明两个Person类型的变量,分别表示 张三 男  18岁/ 小兰 女 16岁
            Person zsPerson;
            Person xlPerson;
            zsPerson._name = "张三";
            zsPerson._mygender = Gender.男;
            zsPerson._age = 18;

            xlPerson._name = "小兰";
            xlPerson._mygender = Gender.女;
            xlPerson._age = 16;

            Console.WriteLine("{0}的性别是：{1}，年龄是：{2}", zsPerson._name, zsPerson._mygender, zsPerson._age);
            Console.WriteLine("{0}的性别是：{1}，年龄是：{2}", xlPerson._name, xlPerson._mygender, xlPerson._age);
            Console.ReadKey();
        }
    }
}
