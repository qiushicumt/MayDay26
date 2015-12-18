using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01Handler
{
    /// <summary>
    /// TestHandler 的摘要说明
    /// </summary>
    public class TestHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            context.Response.ContentType = "text/html";

            //  context.Request得到用户通过浏览器向服务器发出的请求
            //  string name = context.Request["name"];
            //  int age = Convert.ToInt32(context.Request["age"]);
            string username = context.Request["username"];
            string password = context.Request["password"];

            context.Response.Write("用户名是："+username+", 密码是："+password);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}