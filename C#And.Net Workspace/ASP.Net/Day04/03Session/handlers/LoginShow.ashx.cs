using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace _03Session.handlers
{
    /// <summary>
    /// LoginShow 的摘要说明
    /// </summary>
    public class LoginShow : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            if (context.Session == null)
            {
                context.Response.Redirect("Login.ashx");
            }
            else
            {
                string sessionStr = context.Session["userName"].ToString();
                context.Response.Write("用户" + sessionStr + "登录成功！");
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