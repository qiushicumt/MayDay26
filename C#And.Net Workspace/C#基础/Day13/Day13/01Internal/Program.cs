using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  using Test;

namespace _01Internal
{
    //  internal访问修饰符用来修饰类，使用internal修饰的类，只能在当前项目中被访问，不能被项目之外的其他项目访问，即便是添加了对其他项目的引用，也无法访问internal修饰的类
    //  类只能被public、internal修饰，默认一个新的类是被internal修饰的
    //  子类的访问权限不能高于父类的访问权限
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Student oneStudent = new Student();
            oneStudent.SayHello();
            Console.ReadKey();
            */
        }
    }
}
