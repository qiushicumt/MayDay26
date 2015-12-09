using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _05ArrayList_Practise
{
    /*
    //  练习1、创建一个集合，添加一些数字，求数字的和与平均值，最大值，最小值
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int average = 0;            
            ArrayList list1 = new ArrayList();
            list1.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            int maxNum = (int)list1[0];
            int minNum = (int)list1[0];
            for (int i = 0; i < list1.Count; i++)
            {
                sum += (int)list1[i];
                if(maxNum<(int)list1[i])
                {
                    maxNum = (int)list1[i];
                }
                if(minNum > (int)list1[i])
                {
                    minNum = (int)list1[i];
                }
            }
            average = sum / list1.Count;
            Console.WriteLine("集合中数字的和为：{0}，平均值为：{1}，最大值为：{2}，最小值为：{3}", sum, average, maxNum, minNum);
            Console.ReadKey();
        }
    }
    */
    //  练习2、写一个长度为10的集合，要求在里面随机存放10个数字（0~9），要求所有数字不重复
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList(10);
            //  随机生成一个0~9数字，只要集合中不包含，就添加到集合中
            //  直到集合填满10个元素，跳出循环
            while(list1.Count<10)
            {
                int rNum = new Random().Next(0, 10);
                if (!list1.Contains(rNum))
                    list1.Add(rNum);
            }
            for(int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
            Console.ReadKey();
        }
    }
}
