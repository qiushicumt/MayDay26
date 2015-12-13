using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DuoTai
{
    class Chinese:Person
    {
        public Chinese(string name)
            : base(name)
        {

        }
        //  子类与父类具有同名方法，子类使用override重写同名方法
        public override void SayHello()
        {
            Console.WriteLine("我叫{0}，我是中国人", this.Name);
        }
    }
}
