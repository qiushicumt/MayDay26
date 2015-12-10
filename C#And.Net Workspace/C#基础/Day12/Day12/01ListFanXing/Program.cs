using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ListFanXing
{
    //  List泛型 List<T>，指定一个具体类型的list集合，根据声明时指定的数据类型，向集合内添加此类型数据。可以根据下标去对集合中的元素进行查询
    //  List泛型的各种方法
    //  Count属性，返回List中实际元素个数
    //  List.Add(item)向List中添加单个元素，List.AddRange(collection)向List中添加集合数据
    //  List.Clear()方法清空List的所有的元素
    //  List.Remove(item)、List.RemoveAt(index)、List.RemoveRange(index1, index2)方法分别为从List中删除单个、多个元素
    //  List.Contains(item)方法用于判断集合中是否包含某一元素
    //  List.Insert(index, item)方法用于在集合的指定位置插入单个元素，List.Insert(index, collection)方法用于在集合的指定位置处插入一个集合
    //  List.Reverse()方法用于将集合中的所有元素反序排列，List.Sort()方法用于将集合中的元素按照升序排列

    //  List可以通过ToArray方法转换为数组，List是什么类型，返回的就是什么类型的数组
    //  同样的，数组可以通过ToList()方法转换为List集合，数组的类型是什么，转换的就是什么类型数组
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();         //  声明一个List<int>类型的泛型集合
            int[] myNums1 = { 10, 21, 32, 43, 54, 65, 76, 87, 98 };
            //for(int i = 0; i < myList.Count; i++)
            //{
            //    myList.Add(myNums1[i]);
            //}
            myList.AddRange(myNums1);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            int[] myNums2 = myList.ToArray();           //  将List类型转换为数组，List类型为int，返回的数组也为int
            foreach (var item in myNums2)
            {
                Console.WriteLine(item);
            }
            List<int> list2 = myNums2.ToList();         //  数组可以通过ToList()方法转换为List<T>集合，数组是什么类型，返回的集合就是什么类型

            list2.Reverse();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            //for(int i = 0; i < list2.Count; i++)
            //{
            //    Console.WriteLine(list2[i]);
            //}
            
            Console.ReadKey();
        }
    }
}
