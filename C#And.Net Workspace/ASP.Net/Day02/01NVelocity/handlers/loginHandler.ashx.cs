using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01NVelocity.handlers
{
    /// <summary>
    /// loginHandler 的摘要说明
    /// </summary>
    public class loginHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            string userName = context.Request["username"];
            string passWord = context.Request["password"];
            if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord))
            {

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