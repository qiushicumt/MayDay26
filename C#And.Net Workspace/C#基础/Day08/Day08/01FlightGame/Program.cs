using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FlightGame
{   
    class Program
    {
        // 声明一个静态字段的int数组，来代表地图上的一百个点位
        public static int[] Maps = new int[100];
        //  声明一个静态字段的int数组，用来存储A和B的位置
        public static int[] PlayerPos = new int[2];
        //  声明一个静态字段的string数组，用来存储玩家的姓名
        public static string[] PlayerName = new string[2];
        //  声明一个静态字段的bool数组，用来存储玩家的暂停状态
        public static bool[] PlayerStatus = new bool[2];
        static void Main(string[] args)
        {
            GameShow();
            PlayerInput();
            Console.Clear();        //  Console.Clear()方法用于将控制台的显示清屏
            GameShow();
            Console.WriteLine("玩家{0}的代表是A", PlayerName[0]);
            Console.WriteLine("玩家{0}的代表是B", PlayerName[1]);
            InitMap();
            DrawMap();
            while(PlayerPos[0]<99 && PlayerPos[1]<99)
            {
                if (!PlayerStatus[0])
                {
                    PlayGame(0);
                }
                else
                {
                    PlayerStatus[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("Congratulations!玩家{0}获得胜利！！", PlayerName[0]);
                }
                if (!PlayerStatus[1])
                {
                    PlayGame(1);
                }
                else
                {
                    PlayerStatus[1] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("Congratulations!玩家{0}获得胜利！！", PlayerName[1]);
                }
            }
            Console.ReadKey();
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
            //  在每次画地图之前，先输出一句游戏的示例声明
            Console.WriteLine("图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
            #region
            /*         
            //  第一步先画第一横行
            for (int i = 0; i <　30; i++)
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

            //  画第一竖行
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("　");
                }
                if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == (30 + i))
                {

                    Console.Write("<>");
                }
                else if (PlayerPos[0] == (30 + i))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Ａ");
                }
                else if (PlayerPos[1] == (30 + i))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Ｂ");
                }
                else
                {
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    //Console.Write("□");
                    switch (Maps[30 + i])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("□");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("◎");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("☆");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("▲");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("卐");
                            break;
                    }
                }
            }
            */
            #endregion
            //  画第一横行
            for(int i = 0; i < 30; i++)
            {
                string mapStr = DrawStringMap(i);
                Console.Write(mapStr);
            }

            //  画第一竖行
            for(int i = 30; i < 35; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                string mapStr = DrawStringMap(i);
                Console.Write(mapStr);
            }

            //  画第二横行
            //  画第二横行前应当先另起一行
            Console.WriteLine();
            for(int i = 64; i > 34; i--)
            {
                string mapStr = DrawStringMap(i);
                Console.Write(mapStr);
            }

            //  画第二竖行
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine();                
                string mapStr = DrawStringMap(i);
                Console.Write(mapStr);
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
            }

            //  画第三横行
            //  画第三横行前先进行换行
            Console.WriteLine();
            for (int i = 70; i < 100; i++)
            {
                string mapStr = DrawStringMap(i);
                Console.Write(mapStr);
            }

            Console.WriteLine();    //  画完地图后，光标进行换行
        }
        
        /// <summary>
        /// 判断地图上相应的位置应该画什么样的关卡
        /// </summary>
        /// <param name="i">地图上的位置索引</param>
        /// <returns>返回所应画的字符</returns>
        public static string DrawStringMap(int i)
        {
            //  画地图时，首先去判断A和B的位置，根据A和B的位置，画出A、B
            //  然后再画其他关卡
            string str = "";
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                str = "Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        str = "卐";
                        break;
                }
            }
            return str;
        }
        
        /// <summary>
        /// 画游戏头
        /// </summary>
        public static void GameShow()
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
        }

        /// <summary>
        /// 输入玩家姓名
        /// </summary>
        public static void PlayerInput()
        {
            //  输入玩家姓名
            Console.Write("请输入玩家A的姓名：");
            PlayerName[0] = Console.ReadLine();
            while (PlayerName[0] == "")
            {
                Console.WriteLine("玩家A的姓名不能为空，请重新输入!");
                PlayerName[0] = Console.ReadLine();
            }

            Console.Write("请输入玩家B的姓名：");
            PlayerName[1] = Console.ReadLine();
            while (PlayerName[1] == "" || PlayerName[1] == PlayerName[0])
            {
                if (PlayerName[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空，请重新输入!");
                    PlayerName[1] = Console.ReadLine();
                }
                if (PlayerName[1] == PlayerName[0])
                {
                    Console.WriteLine("玩家B的名字不能与玩家A的名字相同，请重新输入!");
                    PlayerName[1] = Console.ReadLine();
                }
            }
        }

        public static void PosJudge()
        {
            if (PlayerPos[0] < 0)
                PlayerPos[0] = 0;
            if (PlayerPos[0] >= 99)
                PlayerPos[0] = 99;
            if (PlayerPos[1] < 0)
                PlayerPos[1] = 0;
            if (PlayerPos[1] >= 99)
                PlayerPos[1] = 99;
        }

        public static void PlayGame(int playerNum)
        {
            Console.WriteLine("玩家{0}按任意键开始掷骰子", PlayerName[playerNum]);
            Console.ReadKey(true);      //  Console.ReadKey()方法传入参数true，则可以不显示按下的按键
            int rNum = new Random().Next(1, 7);     //  Random类的Next方法用于产生两个数之间的随机数，取下限值不去上限值           
            Console.WriteLine("玩家{0}掷出了{1}", PlayerName[playerNum], rNum);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}按任意键开始行动", PlayerName[playerNum]);
            PlayerPos[playerNum] += rNum;       //  玩家行动，位置增加rNum
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}行动完了", PlayerName[playerNum]);
            Console.ReadKey(true);            
            //  对玩家的行为进行判断
            if (PlayerPos[playerNum] == PlayerPos[1 - playerNum])
            {
                Console.WriteLine("玩家{0}踩到玩家{1}，玩家{2}向后退6格。", PlayerName[playerNum], PlayerName[1 - playerNum], PlayerName[1 - playerNum]);
                Console.ReadKey(true);
                Console.WriteLine("玩家{0}完成向后退6格", PlayerName[1-playerNum]);
                PlayerPos[1-playerNum] -= 6;
                Console.ReadKey(true);
            }
            else
            {
                switch (Maps[PlayerPos[playerNum]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到方块，什么都不会发生。", PlayerName[playerNum]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到幸运轮盘，请选择：1--交换位置  2--轰炸对方", PlayerName[playerNum]);
                        string str = Console.ReadLine();
                        while (true)
                        {
                            if (str == "1")
                            {
                                Console.WriteLine("玩家{0}选择与玩家{1}交换位置", PlayerName[playerNum], PlayerName[1 - playerNum]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playerNum];
                                PlayerPos[playerNum] = PlayerPos[1 - playerNum];
                                PlayerPos[1 - playerNum] = temp;
                                Console.WriteLine("玩家{0}完成与玩家{1}的位置交换。", PlayerName[playerNum], PlayerName[1 - playerNum]);
                                Console.ReadKey(true);
                                break;
                            }
                            else if (str == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}向后退6格", PlayerName[playerNum], PlayerName[1 - playerNum], PlayerName[1 - playerNum]);
                                Console.ReadKey(true);
                                PlayerPos[1 - playerNum] -= 6;
                                Console.WriteLine("玩家{0}完成后退6格。", PlayerName[1 - playerNum]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("你的选择不正确，请重新选择：1--交换位置  2--轰炸对方");
                                str = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到地雷，向后退6格", PlayerName[playerNum]);
                        Console.ReadKey(true);
                        PlayerPos[playerNum] -= 6;
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerName[playerNum]);
                        Console.ReadKey(true);
                        PlayerStatus[playerNum] = true;
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进6格", PlayerName[playerNum]);
                        PlayerPos[playerNum] += 6;
                        Console.ReadKey(true);
                        break;
                }
            }
            PosJudge();
            Console.Clear();            
            DrawMap();
        }
    }
}
