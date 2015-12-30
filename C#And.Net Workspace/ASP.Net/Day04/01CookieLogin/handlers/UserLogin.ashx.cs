using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01CookieLogin.handlers
{
    /// <summary>
    /// UserLogin 的摘要说明
    /// </summary>
    public class UserLogin : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string login = context.Request["login"];
            if (String.IsNullOrEmpty(login))
            {
            }
            else
            {
            }

            context.Response.Write("Hello World");
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