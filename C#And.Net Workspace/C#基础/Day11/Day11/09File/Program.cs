using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09File
{
    //  File类对文件进行各种操作。File类也是一个静态类，调用方法使用File.
    //  方法1     File.Create(string path)方法创建一个文件或者重新覆盖原文件
    //  方法2     File.Delete(string path)方法删除一个文件
    //  方法3     File.Copy(string path1, string path2)方法将path1的文件拷贝到path2
    class Program
    {
        static void Main(string[] args)
        {
            File.Create("../../../1.txt");
            Console.WriteLine("OK1");
            File.Delete("../../../testJSON.html");
            Console.WriteLine("OK2");
            File.Copy("../../../1.txt", @"C:\Users\MayDay26\Desktop");
            Console.WriteLine("OK3");
            Console.ReadKey();
        }
    }
}
