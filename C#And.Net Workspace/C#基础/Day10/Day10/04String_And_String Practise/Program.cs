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
    
    //  练习3、两个学员输入各自最喜欢的课程名称，判断是否一致,如果相等,则输出你们俩喜欢相同的课程.如果不相同,则输出你们俩喜欢不相同的课程.
    //  上题中两位同学输入 c#和 C#代表同一门课,怎么办?
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("第一位同学，请输入喜欢的课程:");
            string courseOne = Console.ReadLine();
            Console.Write("第二位同学，请输入喜欢的课程:");
            string courseTwo = Console.ReadLine();
            //  ToLower()方法用于将字符串全部转换为小写，ToUper()方法用于将字符串全部转换为大写
            courseOne = courseOne.ToLower();
            courseTwo = courseTwo.ToLower();
            if (courseOne == courseTwo)
            {
                Console.WriteLine("你们喜欢相同的课程！");
            }
            else
            {
                Console.WriteLine("你们喜欢不相同的课程！");
            }

            Console.ReadKey();
        }
    }
    */

    //  练习4、字符串的各种方法   
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个字符串:");
            string str1 = Console.ReadLine();
            Console.WriteLine("字符串的长度为：{0}", str1.Length);     //  str.Length：返回字符串的长度

            Console.Write("请输入英文字符串:");
            string str2 = Console.ReadLine();
            Console.WriteLine("输入的是：{0}，全部转换为大写为：{1}", str2, str2.ToUpper());       //  strB.ToUper()方法用于将所有字母转换为大写字母
            Console.WriteLine("全部转换为小写为：{0}", str2.ToLower());      //  strA.ToLower()方法用于将所有字母转换为小写字母

            bool b = Equals(str1, str2);        //  Equals(A, B)方法可以用于比较两个字符串是否相等，相等返回true，不等返回false
            if (b)
            {
                Console.WriteLine("两次输入的字符串相同。");
            }
            else
            {
                Console.WriteLine("两次输入的字符串不相同。");
            }

            Console.Write("请输入带空格的字符串:");
            string str3 = Console.ReadLine();
            char[] myChar = { ' ' };
            //  strA.Split(char[] myChar)方法用于对字符串进行分割，需要传入一个char[]数组，char[]数组为一组分隔符，方法返回分割后的子字符串组成的数组
            string[] myStrs = str3.Split(myChar);           
            Console.WriteLine("分割后的子字符串分别为：");
            for (int i = 0; i < myStrs.Length; i++)
            {
                Console.WriteLine(myStrs[i]);
            }

            Console.Write("输入一个字符串：");
            string str4 = Console.ReadLine();
            string str5 = str4.Substring(2);        //  strA.Substring(int)方法用于从字符串中截取出子字符串，传入的参数为想要截取的起始位置，返回从起始位置开始到末尾的子字符串
            Console.WriteLine("截取后的子字符串为：{0}", str5);

            Console.Write("输入一个字符串：");
            string str6 = Console.ReadLine();
            char myChar1 = 'a';
            string str7 = "abc";
            int numA = str6.IndexOf(myChar1);          //  strA.IndexOf(char1)方法用于返回字符在当前字符串中出现的起始位置，若没有，则返回-1
            int numB = str6.IndexOf(str7);             //  strA.IndexOf(strB)方法返回字符串在当前字符串中出现的起始位置，若没有，则返回-1
            int numC = str6.LastIndexOf(myChar1);      //  strA.LastIndexOf(char1)方法返回字符在当前字符串中出现的最后的位置，没有出现，则返回-1
            int numD = str6.LastIndexOf(str7);         //  strA.LastIndexOf(strB)方法返回字符串在当前字符串中出现的最后的位置，若无，则返回-1

            if (numA != -1)
            {
                Console.WriteLine("字符a在字符串{0}中出现的起始位置为：{1}", str6, numA);
            }
            else
            {
                Console.WriteLine("字符a没有出现在字符串{0}中", str6);
            }
            if (numB != -1)
            {
                Console.WriteLine("字符串abc在字符串{0}中出现的起始位置为：{1}", str6, numB);
            }
            else
            {
                Console.WriteLine("字符abc没有出现在字符串{0}中", str6);
            }
            if (numC != -1)
            {
                Console.WriteLine("字符a在字符串{0}中最后出现的位置为：{1}", str6, numC);
            }
            else
            {
                Console.WriteLine("字符a没有出现在字符串{0}中", str6);
            }
            if (numD != -1)
            {
                Console.WriteLine("字符串abc在字符串{0}中最后出现的位置为：{1}", str6, numD);
            }
            else
            {
                Console.WriteLine("字符a没有出现在字符串{0}中", str6);
            }

            if (str6.StartsWith(str7))      //  strA.StartsWith(strB)方法用于判断当前字符串是否以指定的字符串开头的，是，则返回true，否，则返回false
            {
                Console.WriteLine("字符串{0}是以字符串{1}开头的。", str6, str7);
            }
            else
            {
                Console.WriteLine("字符串{0}不是以字符串{1}开头的。", str6, str7);
            }
            if (str6.EndsWith(str7))        //  strA.EndsWith(strB)方法用于判断当前字符串是否以指定的字符串结尾的，是，则返回true，否，则返回false
            {
                Console.WriteLine("字符串{0}是以字符串{1}结尾的。", str6, str7);
            }
            else
            {
                Console.WriteLine("字符串{0}不是以字符串{1}结尾的。", str6, str7);
            }

            Console.Write("请输入字符串：");
            string str8 = Console.ReadLine();
            string str9 = str8.Substring(2, 3);         //  从原字符串中截取一个长度为3的子字符串
            str8.Replace(str9, "abc");                  //  strA.Replace(strB, strC)方法用于将字符串中的子字符串替换为指定的字符串 
            Console.WriteLine("替换后的字符串为：{0}", str8);

            Console.WriteLine("请输入字符串：");
            string str10 = Console.ReadLine();
            if (str10.Contains("abc"))                  //  strA.Contains(strB)方法用于判断字符串是否包含指定的字符串，是，则返回true，否，则返回false
            {
                Console.WriteLine("字符串{0}中包含字符串\"abc\"");
            }
            else
            {
                Console.WriteLine("字符串{0}中不包含字符串\"abc\"");
            }

            Console.ReadKey();
        }
    }
}
