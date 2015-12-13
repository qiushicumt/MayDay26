using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Abstract_Class_Practise
{
    public class Circle:Sharp
    {
        int _radius;
        public int Radius 
        {
            get { return _radius; }
            set { _radius = value; }
        }
        //  子类自身的构造函数
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public override double area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
        public override double zhouchang()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
