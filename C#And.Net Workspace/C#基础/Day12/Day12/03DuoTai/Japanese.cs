using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DuoTai
{
    class Japanese:Person
    {
        public Japanese(string name) : base(name) 
        { 
            
        }
        public override void SayHello()
        {
            Console.WriteLine("我叫{0}，我是日本人。", this.Name);
        }
    }
}
