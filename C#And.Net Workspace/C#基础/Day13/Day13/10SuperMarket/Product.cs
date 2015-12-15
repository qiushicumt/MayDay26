using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    //  产品的类
    public class Product
    {
        string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        double _count;
        public double Count
        {
            get { return _count; }
            set { _count = value; }
        }
        string _name;
        public string Name
        {
            get;
            set;
        }

        public Product(string id, double price, double count, string name)
        {
            this.Id = id;
            this.Price = price;
            this.Count = count;
            this.Name = name;
        }
    }
}
