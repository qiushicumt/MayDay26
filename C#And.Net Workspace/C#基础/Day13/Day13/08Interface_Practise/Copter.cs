using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface_Practise
{
    public class Copter : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("直升机会飞");
        }
    }
}
