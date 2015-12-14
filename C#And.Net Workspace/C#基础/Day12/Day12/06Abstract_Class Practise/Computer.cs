using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Abstract_Class_Practise
{
    class Computer
    {
        //  添加字段来存储用户传入的MobileStorages对象
        MobileStorages _ms;
        public MobileStorages MS
        {
            get { return _ms; }
            set { _ms = value; }
        }

        public void cpuRead()
        {
            this.MS.Read();
        }
        public void cpuWrite()
        {
            this.MS.Write();
        }
        /*
        //  在调用两个方法时， 通过传入一个MobileStorages对象来调用对应的方法
        public void cpuRead(MobileStorages ms)
        {
            ms.Read();
        }
        public void cpuWrite(MobileStorages ms)
        {
            ms.Write();
        }
        */
    }
}
