using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06JiCheng
{
    class Driver:Person
    {     
        int _driveTime;
        public int DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }
        
        public void Drive()
        {
            Console.WriteLine("司机会开车");
        }
    }
}
