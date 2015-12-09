using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ArrayList_Length
{
    //  ArrayList的Count属性，表示集合中实际包含的元素个数
    //  ArrayList的Capcity属性，表示集合中可以包含的元素个数
    //  当ArrayList中实际元素个数大于可用元素个数时，capacity会变为上一次个数的2倍
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList list1 = new ArrayList();
            //  当前list1中的元素为0，count和capacity都为0
            Console.WriteLine(list1.Count);
            Console.WriteLine(list1.Capacity);
            
            //  集合中添加了2个元素，count属性值为2，capacity属性值为4
            ArrayList list1 = new ArrayList();
            list1.Add(12);
            list1.Add(1);
            
            Console.WriteLine(list1.Count);
            Console.WriteLine(list1.Capacity);
            */
            //  此处向集合中添加了9个元素，count属性值为9，capacity属性值为16
            ArrayList list1 = new ArrayList();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);
            list1.Add(8);
            list1.Add(9);
            Console.WriteLine(list1.Count);
            Console.WriteLine(list1.Capacity);
            Console.ReadKey();
            
        }
    }
}
