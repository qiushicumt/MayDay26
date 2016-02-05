using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro_New.handlers
{
    /// <summary>
    /// index 的摘要说明
    /// </summary>
    public class index : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = NVelocity.ReturnHtml("/Front/index.html", null);
            context.Response.Write(html);
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