using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LiShiZhuanHuan_Practise
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] pers = new Person[10];         //  声明一个Person类的数组，数组可以放Person类型数据，也可以放Person的子类的类型的数据
            //  将随机生成的各实例对象填充到数组中
            for (int i = 0; i < pers.Length; i++)
            {
                //  通过生成随机数，来随机生成6种对象的实例
                Random rNum = new Random();
                int num = rNum.Next(1, 7);          //  生成1~6随机数
                switch (num)
                {
                    case 1:
                        pers[i] = new Person();
                        break;
                    case 2:
                        pers[i] = new Student();
                        break;
                    case 3:
                        pers[i] = new Teacher();
                        break;
                    case 4:
                        pers[i] = new Meinv();
                        break;
                    case 5:
                        pers[i] = new Shuaige();
                        break;
                    case 6:
                        pers[i] = new Yeshou();
                        break;
                }
            }
            //  根据数组中每个元素的对象类型，对类型进行判断，调用不同的方法
            //  此处，因为数组中的元素都是Person类，所以不能把是否转换为Person类作为判断条件
            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] is Yeshou)
                {
                    ((Yeshou)pers[i]).YeshouSayHi();
                }
                else if (pers[i] is Student)
                {
                    ((Student)pers[i]).StudentSayHi();       //  (Student)pers[i]将类型强转为Student
                }
                else if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayHi();      //  (Teacher)pers[i]将类型强转为Teacher
                }
                else if (pers[i] is Meinv)
                {
                    ((Meinv)pers[i]).MeinvSayHi();
                }
                else if (pers[i] is Shuaige)
                {
                    ((Shuaige)pers[i]).ShuaigeSayHi();
                }
                else
                {
                    pers[i].PersonSayHi();
                }
            }

            Console.ReadKey();
        }
    }
}
