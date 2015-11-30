using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Lei_ZiDuan_ShuXing
{
    //  类是一种抽象的集合，具有继承、封装、多态的特性
    //  类包含类的字段(又叫成员变量)、属性、方法
    //  在类中，字段一般用于存储数据，所以多设置为private访问属性
    //  想要修改字段值，就要通过类的属性对字段进行修改
    //  而属性本身不存储数据
    //  类的方法是用于设置描述类所拥有的行为
    class Program
    {
        static void Main(string[] args)
        {
            //  声明一个People类的对象
            People onePerson = new People();    
            //  通过对象的属性，对私有变量进行赋值
            onePerson.Name = "张三";
            onePerson.Gender = '男';
            onePerson.Age = 23;

            People twoPerson = new People();
            twoPerson.Name = "韩梅梅";
            twoPerson.Gender = '女';
            twoPerson.Age = 28;

            People threePerson = new People();
            threePerson.Name = "李宇春";
            threePerson.Gender = '春';
            threePerson.Age = -30;

            onePerson.Show();
            twoPerson.Show();
            threePerson.Show();
            Console.ReadKey();
        }
    }
}
