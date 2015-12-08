using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07JiCheng_Practise
{
    class Programmer:Person
    {
        int _workTime;

        public int WorkTime
        {
            get { return _workTime; }
            set { _workTime = value; }
        }
        public Programmer(string name, int age, char gender, int worktime):base(name, age, gender)
        {
            this.WorkTime = worktime;
        }
        public void SayHello()
        {
            Console.WriteLine("大家好，我叫{0}，我是{1}生，我今年{2}岁了，我已经工作{3}年了。", this.Name, this.Gender, this.Age, this.WorkTime);
        }
    }
}
