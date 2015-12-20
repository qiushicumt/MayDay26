using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02Redirect
{
    /// <summary>
    /// redirectHandler 的摘要说明
    /// </summary>
    public class redirectHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string userName = context.Request["username"];
            string passWord = context.Request["password"];

            if (userName == "admin" && passWord == "123456")
            {
                context.Response.Write("登录成功！欢迎您，" + userName + "!");
            }
            else 
            {
                context.Response.Redirect("dengluInfo.ashx");       //  Redirect(url)用于将网页重定向访问到url页面
            }
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