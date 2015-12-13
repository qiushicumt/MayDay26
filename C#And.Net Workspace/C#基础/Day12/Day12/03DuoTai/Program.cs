using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DuoTai
{
    //  多态，同一操作作用于不同的对象，可以产生不同的行为效果
    //  多态的实现方法：1、虚函数   2、抽象类   3、接口

    //  1、虚函数   父类和子类中具有同名的方法，当父类对象想要调用子类同名方法时，可以使用虚函数。
    //  将父类中同名的方法设置为虚函数后，子类对象就可以重写同名方法，然后，父类对象就可以直接调用子类中的同名方法
    class Program
    {
        static void Main(string[] args)
        {            
            Chinese chOne = new Chinese("李雷");
            Chinese chTwo = new Chinese("韩梅梅");
            Japanese jpOne = new Japanese("松下觉得");
            Japanese jpTwo = new Japanese("松岛井夫");
            Korea krOne = new Korea("车太贤");
            Korea krTwo = new Korea("全智贤");
            American amOne = new American("肯尼迪");
            American amTwo = new American("克林顿");
            Person[] pers = {chOne, chTwo, jpOne, jpTwo, krOne, krTwo, amOne, amTwo};

            for (int i = 0; i < pers.Length; i++)
            {
                pers[i].SayHello();         //  将同名方法设置为虚方法后，父类变量中是哪个子类对象，就调用哪个子对对象的方法
            }

            Console.ReadKey();
        }
    }
}
