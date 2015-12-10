using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Review_Practise
{
    /*
    //  1、ArrayList，ArrayList对象中元素个数不受限制，元素类型不受限制
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();          //  创建一个ArrayList实例对象

            list1.Add('w');                             //  Add()方法添加一个元素，元素类型任意
            list1.Add(12);
            list1.Add("stringList");
            list1.Add(true);
            list1.Add(3600m);

            list1.AddRange(new int[] { 10, 21, 32, 43, 54 });    //  AddRange()方法添加一组数据集合，可以添加数组、list

            //  list1.Clear();                          //  Clear()方法用于将list中所有元素清空

            bool flag = list1.Contains(2);              //  Contains()方法用于判断list中是否包含目标元素，返回bool值
            if (flag)
                Console.WriteLine("list1中包含元素2");
            else
                Console.WriteLine("list1不包含元素2");

            int num1 = list1.Count;                     //  Count属性表示list1中实际元素个数
            int num2 = list1.Capacity;                  //  Capacity属性表示list1中可以有的元素个数

            Console.WriteLine("list1中可以有的元素个数为：{0}，实际有的元素个数为：{1}", num2, num1);

            for(int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
            Console.ReadKey();
        }
    }
    */

    //  2、Hashtable集合是一组键值对组成的集合，
    //  由键对应着相应的值，键对应的值可以为空。
    //  在集合中，键具有唯一性，即键不能相同，值不具有唯一性，可以相同

    //  向Hashtable集合中添加元素可以有两种方法
    //  1、Hashtable.Add(key, value)方法可以向Hashtable集合对象中添加键值对。此方法下，当集合中已经存在同名的键时，程序会报错
    //  2、hashtable[key] = value    直接给集合的某一个键进行赋值操作，若集合本身不存在这个键，则添加一个新的键值对，若集合中已存在这个键，则给原来的键重新赋值  
    //  foreach(var item in collection) foreach循环直接在集合里面进行遍历

    //  Hashtable.ContainsKey(key)和Hashtable.Contains(key)方法都用于判断集合中是否包含某一个键
    //  Hashtable.ContainsValue(value)方法用于判断集合中是否包含某一个值
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashtable = new Hashtable();
            string[] name = { "张三", "李四", "王五", "韩梅梅" };
            for(int i = 0; i < name.Length; i++)
            {
                myHashtable.Add(i, name[i]);            //  hashtable.Add(key, value)方法添加键值对
            }

            if(!myHashtable.ContainsKey(4))             //  添加键值对之前先对集合中的键进行判断
                myHashtable[4] = "刘能";                 //  hashtable[key] = value赋值方法添加键值对
            if(!myHashtable.ContainsKey(2))
                myHashtable[2] = "赵四";

            foreach (var item in myHashtable.Keys)      //  foreach()循环遍历hashtable的key
            {
                Console.WriteLine(myHashtable[item]);   //  hashtable[item]返回每一个key对应的value
            }
            
            Console.ReadKey();
        }
    }
}
