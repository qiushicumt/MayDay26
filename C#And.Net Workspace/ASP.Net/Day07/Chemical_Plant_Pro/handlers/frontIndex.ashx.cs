using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro.handlers
{
    /// <summary>
    /// frontIndex 的摘要说明
    /// </summary>
    public class frontIndex : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            html = NVelocity.ReturnHtml("/Front/index.html", null);
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