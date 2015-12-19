using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02Redirect
{
    /// <summary>
    /// dengluInfo 的摘要说明
    /// </summary>
    public class dengluInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write("用户名或密码不正确，请"+"<a href='onload.html'>返回登录页</a>"+"，重新登录");
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