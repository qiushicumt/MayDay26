using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FlightGame
{   
    class Program
    {
        // 声明一个静态字段的数组，来代表地图上的一百个点位
        public static int[] Maps = new int[100];
        //  声明一个静态字段的数组，用来存储A和B的位置
        public static int[] PlayerPos = new int[2];
        static void Main(string[] args)
        {
            PaintGameHead();
            InitMap();
            DrawMap();
            Console.ReadKey();
        }
        /// <summary>
        /// 在控制台画游戏头
        /// </summary>
        public static void PaintGameHead()
        {
            //  Console.ForegroundColor设置控制台中输出的前景色
            //  值为enum类型，ConsoleColor
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********MayDay26飞行棋********");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitMap()
        {
            int[] luckyTurn = { 6, 27, 42, 58, 73, 89 };                    //  设置幸运轮盘的位置，输出为◎
            int[] landMine = { 5, 11, 17, 33, 38, 50, 64, 80, 94 };         //  设置地雷的位置，输出为☆
            int[] pause = { 9, 26, 60, 93 };                                //  设置暂停的位置，输出为▲
            int[] timeTravel = { 20, 25, 45, 63, 72, 88, 90 };              //  设置时空隧道的位置，输出为卐

            //  将Maps数组中幸运轮盘所在位置设置为数值1
            for (int i = 0; i < luckyTurn.Length; i++)
            {
                int n = luckyTurn[i];
                Maps[n] = 1;
            }
            //  将Maps数组中地雷所在位置设置为数值2
            for (int i = 0; i < landMine.Length; i++)
            {                
                Maps[landMine[i]] = 2;
            }
            //  将Maps数组中暂停所在位置设置为数值3
            for (int i = 0; i < pause.Length; i++)
            {
                int n = pause[i];
                Maps[n] = 3;
            }
            //  将Maps数组中时空隧道所在位置设置为数值4
            for (int i = 0; i < timeTravel.Length; i++)
            {
                Maps[timeTravel[i]] = 4;
            }
        }
        /// <summary>
        /// 画地图
        /// </summary>
        public static void DrawMap()
        {
            //  画地图时，首先去判断A和B的位置，根据A和B的位置，画出A、B
            //  然后再画其他关卡
            //  第一步先画第一横行
            for(int i = 0; i <　30; i++)
            {
                //  PlayerPos[0]存储A的位置，PlayerPos[1]存储B的位置，相等则A和B在同一位置上
                //  判断PlayerPos[0]与i是否相等，则用于保证A和B一定在第一行上
                if (PlayerPos[0]==PlayerPos[1] && PlayerPos[0]==i)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("<>");
                }
                else if (PlayerPos[0] == i)
                {
                    Console.Write("Ａ");
                }
                else if (PlayerPos[1] == i)
                {
                    Console.Write("Ｂ");
                }
                else
                {
                    switch(Maps[i])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("□");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("◎");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("☆");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("▲");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("卐");
                            break;                        
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static void GameShow()
        {
            
        }
    }
}
