using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05String_Practise
{
    /*
    //  练习1:接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个字符串:");
            string myStr1 = Console.ReadLine();
            string myStr2 = SortOrder(myStr1);
            Console.WriteLine("字符串{0}反序后的字符串为：{1}", myStr1, myStr2);
            Console.ReadKey();
        }
        /// <summary>
        /// 将传入的字符串反序输出
        /// </summary>
        /// <param name="str1">传入的字符串</param>
        /// <returns>返回反序后的字符串</returns>
        public static string SortOrder(string str1)
        {
            //  声明一个StringBuilder对象，按照反向顺序接收string对象的字符
            StringBuilder str2 = new StringBuilder();
            for (int i = (str1.Length - 1); i >= 0; i--)
            {
                str2.Append(str1[i]);
            }
            return str2.ToString();
        }
    }
    
    //  练习2：接收用户输入的一句英文，将其中的单词以反序输出。"hello c sharp"→"sharp c hello"
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一句英文：");
            string englishStr1 = Console.ReadLine();
            string englishStr2 = SortString(englishStr1);
            Console.WriteLine("反序后的英文语句为：{0}", englishStr2);
            Console.ReadKey();
        }
        public static string SortString(string str1)
        {
            StringBuilder str2 = new StringBuilder();
            char[] splitChar = {' '};
            string[] myStr = str1.Split(splitChar);
            for (int i = (myStr.Length - 1); i >= 0; i--)
            {
                str2.Append(myStr[i]);
                str2.Append(' ');
            }
            string temp = str2.ToString();
            temp.TrimEnd(splitChar);
            return temp;
        }
    }
    
    //  练习3：从Email中提取出用户名和域名：abc@163.com
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入你的Email:");
            string myEmail = Console.ReadLine();
            string userName = "";
            string domain = "";
            emailTiQu(myEmail, out userName, out domain);
            Console.WriteLine("用户名为：{0}", userName);
            Console.WriteLine("域名为：{0}", domain);
            Console.ReadKey();
        }
        public static void emailTiQu(string str1, out string userName, out string domain)
        {
            char[] myChar = { '@' };
            string[] myString = str1.Split(myChar);
            userName = myString[0];
            domain = myString[1];
        }
    }
    
    //  练习4：文本文件中存储了多个文章标题、作者，标题和作者之间用若干空格（数量不定）隔开，每行一个，标题有的长有的短
    //  输出到控制台的时候最多标题长度10，如果超过10，则截取长度8的子串并且最后添加“...”，加一个竖线后输出作者的名字。
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../1.txt";      //  在字符串前加上@符号，表示忽略字符串中的转移符
            string[] myTxt = File.ReadAllLines(path);              //  File.ReadAllLines()方法用于打开指定路径下的文本文档，返回读取的内容的字符串数组，然后关闭
            
            for (int i = 0; i < myTxt.Length; i++)
            {
                char[] splitChar = { ' ' };
                //  string[] newString = myTxt[i].Split(splitChar, System.StringSplitOptions);
                //  strA.Split(char[], StringSplitOptions.RemoveEmptyEntries)方法用于分割字符串，参数StringSplitOptions.RemoveEmptyEntries表示忽略返回的空数组
                string[] newString = myTxt[i].Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
                if(newString[0].Length > 10)
                {
                    newString[0] = newString[0].Substring(0, 8)+"...";
                }
                Console.WriteLine(newString[0] + '|' + newString[1]);
            }

            Console.ReadKey();
        }
    }
     
    //  练习6：让用户输入一句话,判断这句话中有没有邪恶,如果有邪恶就替换成这种形式然后输出,如:老牛很邪恶,输出后变成老牛很**;
    class Program
    {
        static void Main()
        {            
            //Console.WriteLine("请输入一句话：");
            //string myStr1 = Console.ReadLine();
            //bool flag = myStr1.Contains("邪恶");
            //if (flag)
            //{
            // * 错误：，没有返回给myStr1
            //    myStr1.Replace("邪恶", "**");
            //}
            //Console.WriteLine(myStr1);
            Console.Write("请输入一句话：");
            string myStr1 = Console.ReadLine();
            if (myStr1.Contains("邪恶"))
            {
                myStr1 = myStr1.Replace("邪恶", "**");
            }
            Console.WriteLine(myStr1);
            Console.ReadKey();
        }
    }
    
    //  练习7：把{“诸葛亮”,”鸟叔”,”卡卡西”,”卡哇伊”}变成诸葛亮|鸟叔|卡卡西|卡哇伊,然后再把|切割掉
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStr1 = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            string myStr2 = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < (myStr1.Length-1); i++)
            {
                sb.Append(myStr1[i]);
                sb.Append('|');
            }
            sb.Append(myStr1[myStr1.Length - 1]);
            myStr2 = sb.ToString();
            Console.WriteLine(myStr2);
            char[] myChar = { '|' };
            myStr1 = myStr2.Split(myChar, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < myStr1.Length; i++)
            {
                Console.WriteLine(myStr1[i]);
            }
            Console.ReadKey();
        }
    }
    */

    //  练习5：让用户输入一句话,找出所有e的位置
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一句话：");
            string myStr = Console.ReadLine();
            //  int[] indexArray;
            List<int> indexArray = new List<int>();
            //  List<string> strArray1 =  new List<string>();
            myStr = myStr.ToLower();        //  将字符串先全部转换为小写字母
            while(true)
            {
                if (myStr.Contains('e'))    //  判断是否包含字母e
                {
                    if (indexArray.Count > 0)       // 判断位置集合中是否已经含有元素
                    {
                        indexArray.Add(myStr.IndexOf('e') + 1 + indexArray[indexArray.Count - 1]);      //  将新找到的e的index+1+上一次找到的e的index
                    }                        
                    else
                    {
                        indexArray.Add(myStr.IndexOf('e'));     //  将第一次找到的e的index添加到集合中
                    }
                    myStr = myStr.Substring(myStr.IndexOf('e')+1);      //  从e后截取子字符串
                }
                else
                {                   
                    break;
                }
            }
            if(indexArray.Count > 0)
            {
                for(int i = 0; i < indexArray.Count; i++)
                {
                    Console.WriteLine("第{0}个字母e的位置为:{1}", i + 1, indexArray[i]);
                }
            }
            else
            {
                Console.WriteLine("语句中不包含字母e");
            }
            Console.ReadKey();
        }
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一句英文:");
            string myStr1 = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < myStr1.Length; i++)
            {
                if(myStr1[i] == 'e')
                {
                    count++;
                    Console.WriteLine("第{0}个e出现的位置为{1}",count, i);
                }
            }

            Console.ReadKey();
        }
    }
}
