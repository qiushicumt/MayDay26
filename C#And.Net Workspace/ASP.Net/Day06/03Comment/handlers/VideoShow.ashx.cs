using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _03Comment.handlers
{
    /// <summary>
    /// VideoShow 的摘要说明
    /// </summary>
    public class VideoShow : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string html = null;
            DataTable dtComment = SQLHelper.ExecuteDataTable("select * from T_Comment");

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