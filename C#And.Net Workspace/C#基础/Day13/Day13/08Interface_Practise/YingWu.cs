using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface_Practise
{
    public class YingWu:Bird, IFlyable, ISpeakable
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞");
        }
        public void Speak()
        {
            Console.WriteLine("鹦鹉会说话");
        }
    }
}
