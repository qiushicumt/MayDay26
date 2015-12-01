using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Object_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student oneStudent = new Student();
            oneStudent.Name = "李雷";
            oneStudent.Gender = '男';
            oneStudent.Age = 28;
            oneStudent.Chinese = 87;
            oneStudent.Math = 95;
            oneStudent.English = 80;

            Student twoStudent = new Student();
            twoStudent.Name = "韩梅梅";
            twoStudent.Gender = '女';
            twoStudent.Age = 24;
            twoStudent.Chinese = 90;
            twoStudent.Math = 85;
            twoStudent.English = 84;

            oneStudent.SayHello();
            oneStudent.ShowScore();

            twoStudent.SayHello();
            twoStudent.ShowScore();

            Console.ReadKey();
        }
    }
}
