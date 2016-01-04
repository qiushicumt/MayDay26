using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace _04Session_Pro.handlers
{
    /// <summary>
    /// Login2 的摘要说明
    /// </summary>
    public class Login2 : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string login = context.Request["login"];
            if (String.IsNullOrEmpty(login))
            {
                html = NVelocity.ReturnHtml("Login2.html", null);
                context.Response.Write(html);
            }
            else
            {
                string userName = context.Request["username"];
                string passWord = context.Request["password"];
                if (userName == "" || passWord == "")
                {
                    context.Response.Write("请输入用户名或密码进行登录！");
                }
                else if (passWord == "123456")
                {
                    context.Session["UserName"] = userName;
                    context.Response.Redirect("Test2.ashx");
                }
                else
                {
                    context.Response.Write("请输入正确的密码");
                }
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