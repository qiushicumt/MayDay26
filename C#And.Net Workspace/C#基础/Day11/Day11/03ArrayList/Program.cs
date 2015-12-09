using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ArrayList
{
    //  集合ArrayList比Array数组的优点
    //  1、ArrayList的数据类型不是唯一的
    //  2、ArrayList的长度不用确定
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList list1 = new ArrayList();

            //  Add()方法用于ArrayList添加单个元素
            list1.Add(123);
            list1.Add("string");
            list1.Add('男');
            list1.Add(new Person(12, "张三"));

            //  AddRange()方法用于ArrayList添加集合，如，添加数组、添加集合
            list1.AddRange(new int[] { 2, 5, 6, 7, 8 });

            //  Clear()方法用于清空ArrayList中所有的元素
            //  list1.Clear();  

            //  Remove()方法用于删除ArrayList中的某一个元素
            //  RemoveAt(2)方法用于根据下标删除ArrayList中的单个元素
            //  RemoveRange(0,4)方法用于删除ArrayList中下标范围包含的元素
            list1.Remove('男');

            //  Sort()方法用于将ArrayList中可以进行排序的元素进行排序
            //  Reverse()方法用于将ArrayList中的元素进行反序

            //  Insert(1, )方法用于在ListArray的指定位置插入一个元素，原本的元素后退一个位置
            //  InsertRange(2, {})方法用于在ListArray的指定位置插入一个集合
            list1.Insert(2, "charuyuansu");
            for(int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }

            bool b = list1.Contains('1');
            if(b)
            {
                Console.WriteLine("包含这个元素");
            }
            else
            {
                Console.WriteLine("不包含这个元素");
            }

            Console.ReadKey();
        }
    }
}
