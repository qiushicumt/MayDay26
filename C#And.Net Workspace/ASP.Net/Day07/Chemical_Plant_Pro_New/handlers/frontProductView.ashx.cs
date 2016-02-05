using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro_New.handlers
{
    /// <summary>
    /// frontProductView 的摘要说明
    /// </summary>
    public class frontProductView : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = NVelocity.ReturnHtml("/Front/productView.html", null);
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