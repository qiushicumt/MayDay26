using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Out_Practise
{
    /*
    //  out参数练习
    //  练习1、提示用户输入用户名和密码，调用方法判断登录是否成功，返回登录结果和登录信息
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入用户名：");
            string userName = Console.ReadLine();
            Console.Write("请输入密码：");
            string userPwd = Console.ReadLine();
            bool result;
            string msg;
            LoginFunc(userName, userPwd, out result, out msg);
            Console.WriteLine("登录结果是：{0}", result);
            Console.WriteLine("登录信息是：{0}", msg);
            Console.ReadKey();
        }

        /// <summary>
        /// 判断用户登录信息，返回登录结果
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="userpwd">密码</param>
        /// <param name="result">登录结果</param>
        /// <param name="msg">登录信息</param>
        public static void LoginFunc(string username, string userpwd, out bool result, out string msg)
        {
            if (username == "admin" && userpwd == "888888") 
            {
                result = true;
                msg = "登录成功！";
            }
            else if (username == "admin") 
            {
                result = false;
                msg = "密码不正确！";
            }
            else if (userpwd == "888888")
            {
                result = false;
                msg = "用户名不正确！";
            }
            else 
            {
                result = false;
                msg = "用户名和密码都不正确！";
            }
        }
    }
    */
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.Write("请输入一个数字：");
            string str1 = Console.ReadLine();
            int num;
            bool flag = MyTryParse(str1, out num);
            if (flag)
            {
                Console.WriteLine("你输入的数字是：{0}，它的平方是：{1}.", num, num * num);
            }
            else {
                Console.WriteLine("输入的格式不是数字!!");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// string型数据转换为int型
        /// </summary>
        /// <param name="str">要被转换的string型数据</param>
        /// <param name="num">转换后的int型数据</param>
        /// <returns>转换成功函数返回true，转换失败函数返回false</returns>
        public static bool MyTryParse(string str, out int num)
        {
            try
            {
                num = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                num = 0;
                return false;
            }
        }
    }
}
