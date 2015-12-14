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
    //  在声明的类上一行写上[Serializable]，就可以表示类被序列化
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person myPerson = new Person();
            myPerson.Name = "赵四";
            myPerson.Age = 36;
            myPerson.Gender = '男';
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
            */
            
            //  反序列化    读取文件流，将二进制文件流转换为对象
            //  先通过FileStream对象，读取文件流，生成文件流对象时，传入的参数为：filePath, FileMode.OpenOrCreate, FileAccess.Read
            //  然后创建BinaryFormatter对象，调用Deserialize()方法，方法返回一个object对象，可以强转为目标实例对象
            Person myPerson;
            using(FileStream fsRead = new FileStream(@"../../../1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                myPerson = (Person)bf.Deserialize(fsRead);         //  返回一个object
            }
            Console.WriteLine(myPerson.Name);
            Console.WriteLine(myPerson.Age);
            Console.WriteLine(myPerson.Gender);
            Console.ReadKey();
            
        }
    }
}
