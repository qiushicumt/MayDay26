using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02LiuYanBan.handlers
{
    /// <summary>
    /// LiuYanShow 的摘要说明
    /// </summary>
    public class LiuYanShow : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            
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