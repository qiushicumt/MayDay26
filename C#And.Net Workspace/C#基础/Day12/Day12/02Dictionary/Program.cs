using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Dictionary
{
    //  Dictionary与Hashtable功能基本相同，不同的是，dictionary必须指定键值对的类型
    //  在声明Dictionary对象的时候，必须指定键值对的类型，键同样是具有唯一性，值不具有唯一性
    //  dictionary.Add(key, value)方法添加键值对到dictionary中
    //  dictionary[key] = value赋值操作同样可以添加键值对到dictionary中
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dicOne = new Dictionary<int,string>();
            dicOne.Add(2, "张三");
            dicOne.Add(1, "李四");
            dicOne[5] = "刘能";
            if (!dicOne.ContainsKey(3))
                dicOne[3] = "李光洙";
            if (!dicOne.ContainsKey(4))
                dicOne[4] = "王鼻子";

            foreach (var item in dicOne.Keys)       //  foreach(var item in dictionary.Keys)循环在字典的键中遍历，然后可取出对应值
            {
                Console.WriteLine(dicOne[item]);
            }

            Console.ReadKey();
        }
    }
}
