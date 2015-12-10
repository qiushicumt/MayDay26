using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Path
{

    //  Path类，静态类，直接使用类名调用方法
    //  方法1、Path.GetFileName(string)方法从路径字符串中直接获取文件名，返回该文件名
    //        Path.GetFileNameWithoutExtension(string)方法从路径中获取文件名，不包含文件的扩展名
    //        Path.GetExtension(string)方法从路径中获取文件的扩展名
    //  方法2、Path.GetDirectory(string)方法从路径中获取文件夹名
    //  方法3、Path.Combine(string1, string2)方法将两个字符串路径合并为一个  
    class Program
    {
        static void Main(string[] args)
        {
            string myPath = @"../../../testJSON.html";
            string fileName1 = Path.GetFileName(myPath);                    //  获取文件名
            string fileName2 = Path.GetFileNameWithoutExtension(myPath);    //  获取文件名，不包含文件的扩展名
            string extension = Path.GetExtension(myPath);                   //  获取文件的扩展名
            string fileDirectory = Path.GetDirectoryName(myPath);           //  获取文件夹名
            string newPath = Path.Combine("../", myPath);                   //  将两个路径字符串合并为一个path字符串
            Console.WriteLine(fileName1);
            Console.WriteLine(fileName2);
            Console.WriteLine(extension);
            Console.WriteLine(fileDirectory);
            Console.WriteLine(newPath);

            Console.ReadKey();
            /*
            //  通过string的相关方法，得到想要的有效路径
            string myPath = @"../../../testJSON.html";
            int index = myPath.LastIndexOf('/');                //  string.LastIndexOf()方法返回某个字符或字符串在字符串中最后一次出现的索引位置
            Console.WriteLine(myPath.Substring(index + 1));
            Console.ReadLine();
            */
        }
    }
}
