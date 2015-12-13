using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DuoTai
{
    class Korea:Person
    {
        public Korea(string name)
            : base(name)
        { 
            
        }

        public override void SayHello()
        {
            Console.WriteLine("我叫{0}，我是韩国人", this.Name);
        }
    }
}
