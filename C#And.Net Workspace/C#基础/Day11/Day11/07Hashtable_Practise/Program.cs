using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _07Hashtable_Practise
{
    //  练习：将用户输入的简体字转换为繁体字
    class Program
    {
        static void Main(string[] args)
        {
            const string JIANTI = "你说那边鲜花还在开所以我要去看和大海风从面吹过来的心也被暖阳光洒满金色爱空中飘散鸟呼唤裙角摇摆北方等着到背上行囊就离";
            const string FANTI = "你說那邊鮮花還在開所以我要去看和大海風從面吹過來的心也被暖陽光灑滿金色愛空中飄散鳥呼喚裙角搖擺北方等著到背上行囊就離";

            Hashtable myHashtable = new Hashtable();    //  声明一个hashtable对象实例
            for (int i = 0; i < JIANTI.Length; i++)     //  for循环将键值对添加到hashtable对象中
            {
                myHashtable.Add(JIANTI[i], FANTI[i]);
            }

            Console.WriteLine("请输入一句话：");
            string txt = Console.ReadLine();
            foreach (var item in txt)
            {
                if (myHashtable.ContainsKey(item))
                {
                    Console.Write(myHashtable[item]);
                }
                else
                {
                    Console.Write(item);
                }
            }
            Console.ReadKey();
        }
    }
}
