﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    public class Acer : Product
    {
        /*
        public Acer(string id, double price, double count, string name)
            : base(id, price, count, name)
        {
        }
        */
        //  构造函数
        public Acer(string id, double price, string productName) : base(id, price, productName)
        {
        }
    }
}
