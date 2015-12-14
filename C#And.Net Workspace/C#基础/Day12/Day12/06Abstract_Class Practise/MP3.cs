using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Abstract_Class_Practise
{
    public class MP3:MobileStorages
    {
        public void PlayMusic()
        {
            Console.WriteLine("MP3可以播放音乐");
        }
        public override void Read()
        {
            Console.WriteLine("MP3正在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("MP3正在写入数据");
        }
    }
}
