using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            People xiaoming = new People();
            xiaoming._name = "小明";
            xiaoming._gender = "男";
            xiaoming.Age = 122;

            xiaoming.Show();
            Console.ReadKey();
        }
    }
}
