using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04String_And_String_Practise
{
    //  1、string具有不可变性，即在内存的堆中，两个相同string值的变量，指向的是堆中同一块空间。
    //  当string类型变量的值发生改变时，系统会在堆内存中开辟另一块空间存储新的string类型的值，变量指向新的空间
    //  2、string类型可以被看作是只读类型的char类型数组，可以通过访问数组下标的方式访问string中的字符，不能改变string值中的指定位置的char的值

    /*
    //  练习1、通过将string转换为char数组，来对string中的具体位置的char进行改变
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "mayday26";
            Console.WriteLine(myStr[2]);
            char[] myChar = myStr.ToCharArray();    //  ToCharString()方法将string转换为char[]数组
            myChar[2] = 'Y';
            myStr = new string(myChar);             //  new string生成一个新的string对象
            Console.WriteLine(myStr[2]);
            Console.WriteLine(myStr);
            Console.ReadKey();
        }
    }
    * 
    //  练习2、随机输入你心中想到的一个名字，然后输出它的字符串长度
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个你想到的名字：");
            string nameStr = Console.ReadLine();
            Console.WriteLine("{0}的长度为：{1}", nameStr, nameStr.Length);      //  字符串的Length属性可以返回一个字符串的长度
            Console.ReadKey();
        }
    }
    */
    //  练习3、两个学员输入各自最喜欢的课程名称，判断是否一致,如果相等,则输出你们俩喜欢相同的课程.如果不相同,则输出你们俩喜欢不相同的课程.    //  上题中两位同学输入 c#和 C#代表同一门课,怎么办?
}
