using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Simple_Plant
{
    public class Lenovo:NoteBook
    {
        //  子类重写父类的抽象方法
        public override void SayHello()     
        {
            Console.WriteLine("我是联想笔记本");
        }
    }
}
