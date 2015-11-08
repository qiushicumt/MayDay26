using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Enum
{

    public enum QState {
        Online=1,
        Offline,
        Busy,
        Leave,
        QMe
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            //  1、enum类型数组用于表示一组固定的标准值
            //  enum语法为：public enum 名称 {枚举值}
            //  enum类型和int类型是兼容的，可以通过隐式类型转换进行相互转换
            //  enum起始的index为0
            //  示例代码

            QState myQQState = QState.Leave;
            Console.WriteLine("My qq state is:{0}", myQQState);

            int n = (int)myQQState;
            Console.WriteLine("转换后的值为：{0}", n);

            //  12超出了enum枚举里面的值的范围，所以不会进行转换，直接输出12
            int m = 12;
            QState myQQState2 = (QState)m;
            Console.WriteLine("myQQState2 is:{0}", myQQState2);

            Console.ReadKey();
             * */
            #endregion
            /*
            //  2、enum类型和string类型的相互转换
            //  ToString方法可以将enum类型转换为string类型

            QState myState = QState.Online;
            string str = myState.ToString();
            Console.WriteLine("My state is: {0}", str);
            Console.ReadKey();
            
            //  Enum.parse方法可以将string类型转换为enum类型
            //  (枚举类型)Enum.Parse(typeof(枚举类型), string)
            string str = "5";
            QState myState = (QState)Enum.Parse(typeof(QState), str, true);
            Console.WriteLine("My state is: {0}", myState);
            Console.ReadKey();
             */
            //  3、练习    提示用户选择qq在线状态，根据用户的输入，输出用户选择的qq状态
            Console.WriteLine("请选择你的qq在线状态： 1--Online, 2--Offline, 3--Busy, 4--Leave, 5--QMe");
            string str = Console.ReadLine();
            switch (str) { 
                case "1":
                    QState state1 = (QState)Enum.Parse(typeof(QState), str);
                    Console.WriteLine("你选择的QQ状态为：{0}", state1);
                    break;
                case "2":
                    QState state2 = (QState)Enum.Parse(typeof(QState), str);
                    Console.WriteLine("你选择的QQ状态为：{0}", state2);
                    break;
                case "3":
                    QState state3 = (QState)Enum.Parse(typeof(QState), str);
                    Console.WriteLine("你选择的QQ状态为：{0}", state3);
                    break;
                case "4":
                    QState state4 = (QState)Enum.Parse(typeof(QState), str);
                    Console.WriteLine("你选择的QQ状态为：{0}", state4);
                    break;
                case "5":
                    QState state5 = (QState)Enum.Parse(typeof(QState), str);
                    Console.WriteLine("你选择的QQ状态为：{0}", state5);
                    break;
                default:
                    Console.WriteLine("没有这样的qq状态！");
                    break;
            }
            Console.ReadKey();
        }
    }
}
