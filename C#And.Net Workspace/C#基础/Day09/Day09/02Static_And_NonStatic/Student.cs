using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Static_And_NonStatic
{
    //  声明一个静态类，静态类中只能包含静态成员变量，不能包含非静态成员变量
    public static class Student
    {
        static string _name;
        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //  int _score;     不能在静态类中声明实例成员

        static int _score;
        public static int Score
        {
            get { return _score; }
            set { _score = value; }
        }
        /// <summary>
        /// 静态类的静态方法
        /// </summary>
        public static void Show()
        {
            Console.WriteLine("我叫{0}，我的成绩是{1}", Student.Name, Student.Score);
        }
    }
}
