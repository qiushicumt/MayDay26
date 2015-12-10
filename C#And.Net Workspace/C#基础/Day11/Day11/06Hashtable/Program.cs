using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Hashtable
{
    //  Hashtable，是一种数据集合，以键值对的形式存储数据。集合中的每一个键对应一个值，值可以为null
    //  注：在键值对中，键必须是唯一的，值可以相同
    //  Add(item, value)方法用于给Hashtable添加数据，键、值都为object类型，即任一类型。使用此方法，当item已经存在时，程序会报错
    //  collection[item] = value方式也可以为键值对进行添加数据的操作。使用次方法，当item已存在时，原本的值会被新的值覆盖掉
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 12);
            ht.Add(2, "张三");
            ht.Add(3, '男');
            ht.Add(false, "错误");
            ht[4] = 5000m;
            ht[2] = "赵四";               //  原值张三被覆盖掉
            //  foreach循环多用于遍历集合
            //  for(var item in collection)
            //  遍历键值对中的键
            //foreach (var j in ht.Keys)
            //{
            //    Console.WriteLine(j);
            //}
            //  遍历键值对中的值
            foreach (var i in ht.Values)
            {
                Console.WriteLine(i);
            }
            //  foreach()循环中设置循环条件为循环集合中的键，值则由collection[item]的下标方式给出
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是{0}--------值是{1}", item, ht[item]);
            }
            Console.ReadKey();
        }
    }
}
