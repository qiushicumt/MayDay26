﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro_New.handlers
{
    /// <summary>
    /// ProductList 的摘要说明
    /// </summary>
    public class ProductList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = NVelocity.ReturnHtml("Admin/productList.html", null);
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