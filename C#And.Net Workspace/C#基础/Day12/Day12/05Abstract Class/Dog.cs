using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Abstract_Class
{
    public class Dog:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗是旺旺叫");
        }
    }
}
