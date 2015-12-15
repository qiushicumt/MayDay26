using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface_Practise
{
    public class WoodDuck:Duck
    {
        public WoodDuck(string name):base(name)
        {

        }

        public new void Swim()
        {
            Console.WriteLine("{0}不会游泳", this.DuckName);
        }
    }
}
