﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro_New.handlers
{
    /// <summary>
    /// adminIndex 的摘要说明
    /// </summary>
    public class adminIndex : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = NVelocity.ReturnHtml("Admin/adminIndex.html", null);
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