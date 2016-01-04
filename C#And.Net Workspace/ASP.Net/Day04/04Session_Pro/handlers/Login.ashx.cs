using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04Session_Pro.handlers
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string login = context.Request["login"];
            if (String.IsNullOrEmpty(login))
            {
                html = NVelocity.ReturnHtml("Login.html", null);
                context.Response.Write(html);
            }
            else
            {
                string userName = context.Request["username"];
                string passWord = context.Request["password"];
                if(passWord == "123456")
                {
                    Guid userId = new Guid();
                    SessionMgr.JiZhang(userId, userName);

                    HttpCookie myCookie = new HttpCookie("ZhangBenId");
                    myCookie.Value = userId.ToString();

                    context.Response.Redirect("Test.ashx");
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