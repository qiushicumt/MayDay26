using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Zhileixing_Yinyongleixing
{
    //  值类型：int double char decimal struct bool enum    值类型的值存储于栈中
    //  引用类型：string 数组 自定义类 object 集合 接口        引用类型的值存储于堆中

    //  值传递：把一个值类型的值给另外一个值类型时，把值复制一份传递给另外一个值类型

    //  引用传递：把一个引用类型的值传递给另外一个引用类型时，是把引用复制了一份传递给另外一个引用类型
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "张三";
            Test(p);
            Console.WriteLine(p.Name);      //  p.Name为"李四"。

            //  虽然字符串为引用类型，由于字符串具有不可变性，当改变name2时，系统在内存的堆中重新为name2开了一块空间，而name1指向的还是原来的空间
            string name1 = "刘能";
            string name2 = name1;
            name2 = "赵四";
            Console.WriteLine(name1);
            Console.WriteLine(name2);

            int n1 = 10;
            ChangeNum(ref n1);      //  当没有ref修饰时，n1传递给方法的是一个复制的副本，在方法中改变值内容时，不影响n1，加了ref后，方法改变的值会带回到n1
            Console.WriteLine(n1);

            Console.ReadKey();
        }

        public static void ChangeNum(ref int num)
        {
            num += 10;
        }

        //  调用Test方法时，p传递给pp对象的是堆中"张三"的引用，pp又把对"张三"的引用传递给Test方法中声明的对象p
        public static void Test(Person pp)
        {
            Person p = pp;
            p.Name = "李四";
        }
    }
}
