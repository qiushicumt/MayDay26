using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace _03Session.handlers
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string loginStr = context.Request["hidlgclick"];
            if (loginStr == "lgClick")
            {
                string userName = context.Request["username"];
                string passWord = context.Request["password"];
                if (userName == "" || passWord == "")
                {
                    context.Response.Write("用户名或密码不能为空！");
                }
                else
                {
                    if (passWord == "123456")
                    {
                        context.Session["userName"] = userName;
                        context.Response.Redirect("LoginShow.ashx");
                    }
                    else
                    {
                        context.Response.Write("密码不正确！");
                    }
                }
            }
            else if (loginStr == "getSessionClick")
            {
                if (context.Session != null)
                {
                    string myUserName = context.Session["userName"].ToString();
                    context.Response.Write("Session userName的值为：" + myUserName);
                }
            }
            else if (loginStr == "backlgClick")
            {
                context.Session.Abandon();
            }
            else
            {
                html = NVelocity.ReturnHtml("Login.html", null);
                context.Response.Write(html);
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