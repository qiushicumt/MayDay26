using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Abstract_Class_Practise
{
    public class Rectangle:Sharp
    {
        int _chang;
        int _kuan;
        public int Chang
        {
            get { return _chang; }
            set { _chang = value; }
        }
        public int Kuan
        {
            get { return _kuan; }
            set { _kuan = value; }
        }
        public Rectangle(int chang, int kuan)
        {
            this.Chang = chang;
            this.Kuan = kuan;
        }

        public Rectangle()
        {
            // TODO: Complete member initialization
        }
        public override double area()
        {
            return this.Chang * this.Kuan;
        }
        public override double zhouchang()
        {
            return 2 * (this.Chang + this.Kuan);           
        }
    }
}
