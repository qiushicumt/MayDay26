using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface_Practise
{
    //  练习3、真的鸭子会游泳，木头鸭子不会游泳，橡皮鸭子会游泳
    class Program
    {
        static void Main(string[] args)
        {
            Duck trueDuck = new Duck("真的鸭子");
            trueDuck.Swim();
            WoodDuck woodDuck = new WoodDuck("木头鸭子");
            woodDuck.Swim();
            XiangpiDuck xiangpiDuck = new XiangpiDuck("橡皮鸭子");
            xiangpiDuck.Swim();

            Console.ReadKey();
        }
    }
    /*
    //  练习2、重写IComparable的接口，用于给Student类进行排序
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("李雷", 18, 0502113);
            Student studentTwo = new Student("吉姆", 16, 0502112);
            Student studentThree = new Student("韩梅梅", 17, 0502114);

            Person[] students = { studentThree, studentOne, studentTwo };
            Print("初始顺序为： ", students);
            Array.Sort(students);
            Print("按照年龄排序后的顺序为： ", students);

            Console.ReadKey();
        }
        public static void Print(string s, Person[] pers)
        {
            Console.Write(s);
            foreach (var item in pers)
            {
                Console.Write("{0} ", item.Name);
            }
            Console.WriteLine("");
        }
    }

    //  练习1、麻雀会飞，鹦鹉会飞，鸵鸟不会飞，企鹅不会飞，直升机会飞
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable myFly1 = new MaQue();
            myFly1.Fly();
            ISpeakable ywSpeak = new YingWu();
            ywSpeak.Speak();
            IFlyable copterFly = new Copter();
            copterFly.Fly();
            Console.ReadKey();            
        }
    }
    */
}
