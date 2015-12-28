using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03StudentManage_Pro.handlers
{
    /// <summary>
    /// StudentList 的摘要说明
    /// </summary>
    public class StudentList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            
            
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