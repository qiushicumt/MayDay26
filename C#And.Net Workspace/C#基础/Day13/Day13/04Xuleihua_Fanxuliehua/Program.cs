using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _04Xuleihua_Fanxuliehua
{
    //  序列化：将对象转换为二进制
    //  反序列化：将二进制转换为对象
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();

            //  创建写文件流  using(FileStream fsWrite = new FileStream(targetPath, FileMode mode, FileAccess access))
            //  targetPath为创建的目标文件的路径，FileMode为文件打开的模式，FileAccess为文件的连接方式--读或者写
            using (FileStream fsWrite = new FileStream(@"../../../1.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                //  开始序列化一个对象
                //  创建一个BinaryFormatter的对象，对象调用Serialize方法将对象转换为二进制流并写入文件
                //  BinaryFormatter.Serialize(Stream , object)  stream为文件流，object为转换的对象
                  
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, myPerson);
            }
            Console.WriteLine("序列化成功");
            Console.ReadKey();
        }
    }
}
