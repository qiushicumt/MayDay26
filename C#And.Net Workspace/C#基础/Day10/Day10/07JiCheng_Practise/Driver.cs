using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07JiCheng_Practise
{
    class Driver:Person
    {
        int _driveTime;

        public int DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }

        public Driver(string name, int age, char gender, int drivetime)
            : base(name, age, gender)
        {
            this.DriveTime = drivetime;
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我是一名{1}司机，我今年{2}岁了，我的驾龄是{3}年。", this.Name, this.Gender, this.Age, this.DriveTime);
        }

    }
}
