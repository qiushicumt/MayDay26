using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Object_Review;         //  添加完另一个项目的引用后，添加另一个项目的命名空间来使用类

//  类一般被包含在命名空间内
//  在调用另外的项目中的类时，需要在项目中添加对另外一个项目的引用，然后再添加另一个项目的namespace
//  注：当本项目和引用项目具有相同的类名时，在调用引用项目的类时需要加上引用的项目的命名空间作为类的前缀。如"_01Object_Review.Student"。
namespace _02Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //_01Object_Review.Student lsStudent = new Student("李四");
            _01Object_Review.Student lsStudent = new _01Object_Review.Student("李四");
            Console.WriteLine("我的名字是{0}", lsStudent.Name);

            Student zsStudent = new Student(28);
            Console.WriteLine("我的名字是{0}，年龄是{1}", zsStudent.Name, zsStudent.Age);
            Console.ReadKey();
        }
    }
}
