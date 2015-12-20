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
            context.Response.ContentType = "text/html";     //  ContentType表示返回的响应数据类型，"text/html"表示以html的类型返回，"text/plain"表示以文本的形式返回

            //  context.Request得到用户通过浏览器向服务器发出的请求
            //  context.Request[表单元素的name属性值] 来得到表单中想要被处理的元素的值
            //  string name = context.Request["name"];
            //  int age = Convert.ToInt32(context.Request["age"]);
            string username = context.Request["username"];
            string password = context.Request["password"];
            string rememberPwd = context.Request["rememberPWD"];
            if (rememberPwd != null)
            {
                context.Response.Write("你选择记住密码<br/>");
            }

            //  context.Response服务器响应
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