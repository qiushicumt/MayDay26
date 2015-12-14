using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Simple_Plant
{
    //  简单工厂设计模式，屏蔽子类的差异化，对外返回一个父类。
    //  通过里氏转换，将具体的一个子类对象赋值给父类，通过多态，实现父类调用具体的子类
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入你想要的笔记本电脑的牌子：");
            string brand = Console.ReadLine();
            GetNoteBook(brand).SayHello();
            Console.ReadKey();
        }

        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch(brand)
            {
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "IBM":
                    nb = new IBM();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
            }

            return nb;
        }
    }
}
