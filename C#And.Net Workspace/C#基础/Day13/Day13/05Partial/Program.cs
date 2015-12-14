using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Partial
{
    //  部分类，又叫局部类，用关键字partial修饰，partial在和class连在一起的时候才有作用
    //  partial修饰的类，在同一个命名空间中，两个类的名称可以相同，部分类必须都用partial修饰
    //  partial修饰的各个部分类中，可以互相调用对方类中的成员变量
    //  部分类中不能有相同的方法名
    //  部分类要处在同一命名空间中
    class Program
    {
        static void Main(string[] args)
        {
            Student oneStu = new Student();
            oneStu.Name = "小虎";
            oneStu.Age = 29;
            oneStu.SayHello();
            Console.ReadKey();
        }
    }

    public partial class Student:Person
    {
        
    }

    public partial class Student
    {
        int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁", this.Name, this.Age);
        }
        
    }
}
