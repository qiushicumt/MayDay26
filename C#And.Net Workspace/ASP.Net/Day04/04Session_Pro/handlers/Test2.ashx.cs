using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace _04Session_Pro.handlers
{
    /// <summary>
    /// Test2 的摘要说明
    /// </summary>
    public class Test2 : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            if (context.Session["UserName"] != null && context.Session["UserName"].ToString() != "")
            {
                string userName = context.Session["UserName"].ToString();
                context.Response.Write("用户" + userName + "登录成功！");
            }
            else
            {
                context.Response.Redirect("Login.ashx");
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