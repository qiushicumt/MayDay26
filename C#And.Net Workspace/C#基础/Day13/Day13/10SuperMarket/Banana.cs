using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    public class Banana:Product
    {
        /*
        public Banana(string id, double price, double count, string name)
            : base(id, price, count, name)
        {
        }
        */
        public Banana(string id, double price, string productName):base(id, price, productName)
        {

        }
    }
}
