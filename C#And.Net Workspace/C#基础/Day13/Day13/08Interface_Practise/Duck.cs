using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface_Practise
{
    public class Duck : ISwimable
    {
        string _duckName;
        public string DuckName
        {
            get { return _duckName; }
            set { _duckName = value; }
        }
        public Duck(string duckname)
        {
            this.DuckName = duckname;
        }
        public void Swim()
        {
            Console.WriteLine("{0}会游泳", this.DuckName);
        }
    }
}
