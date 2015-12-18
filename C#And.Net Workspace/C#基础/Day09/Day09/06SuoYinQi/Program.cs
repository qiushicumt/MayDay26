using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SuoYinQi
{
    //  索引器，是一组get和set访问器，可以用于访问和设置一组类中的成员变量，所以和属性一样，索引器不会被系统分配内存来存储数据
    //  定义：  数据类型 this[Type param1, ...]
    //         { 
    //              set { }
    //              get { }
    //         }

    //  注：1、索引器不包含名称，在名称位置使用this
    //      2、索引器不能被static修饰
    //      3、索引器可以有get和set，也可以只有其中一个，并且get和set中不一定要进行赋值取值操作
    //      4、索引器的参数列表中必须有一个参数
    //      5、索引器进行赋值操作时，set方法被自动调用，set方法隐式包含一个value值。索引器在进行取值操作时，get方法被自动调用。
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Age = 36;

            //  通过索引，对对象中的三个字段进行访问
            personOne[0] = "Frank";
            personOne[1] = "Zhong";
            personOne[2] = "Lampard";

            //  通过索引，获得对象中的3个字段的值
            Console.WriteLine("我是{0}，我的全名是{1}.{2}.{3}，我今年{4}岁。", personOne[2], personOne[0], personOne[1], personOne[2], personOne.Age);
            Console.ReadKey();
        }
    }
}
