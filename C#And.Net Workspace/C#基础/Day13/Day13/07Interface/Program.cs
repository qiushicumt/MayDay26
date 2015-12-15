using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Interface
{
    //  接口，是指定或者定义一组通用的函数，但不去实现这组函数的引用类型
    //  声明语法：修饰符 interface 接口名
    //  接口内只是一组函数定义
    //  特点：1、接口内的成员不允许添加访问修饰符，默认就是public
    //  2、接口中不能包含字段
    //  3、接口中只能包含自动属性，自动属性为：    public string Name {get;set;}   自动属性只有get和set，但是get和set没有方法体
    //  4、被继承的接口中定义的函数，都必须被在子类中实现
    //  5、接口不能被实例化
    //  6、可以把子类的实例对象赋值给声明的接口变量，接口变量就可以调用子类实现的方法，传哪个对象，就调用哪个对象实现的方法
    //  7、子类可以继承多个接口，接口可以继承其他的多个接口
    class Program
    {
        static void Main(string[] args)
        {
            Student oneStudent = new Student("张三", 29, '男');
            Console.WriteLine("{0}的年龄是：{1}", oneStudent.GetName(), oneStudent.GetAge());
            Student twoStudent = new Student("韩梅梅", 28, '女');
            Console.WriteLine("{0}的年龄是：{1}", twoStudent.GetName(), twoStudent.GetAge());

            Console.ReadKey();
        }
    }
}
