using System;
using System.Collections.Generic;
using System.Data;
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
            string html = null;
            DataTable dtMsg = SQLHelper.ExecuteDataTable("select * from T_LiuYanBan");
            if (dtMsg.Rows.Count <= 0)
            {
                html = NVelocity.ReturnHtml("LiuYanShow.html", null);
                context.Response.Write(html);
            }
            else
            {               
                html = NVelocity.ReturnHtml("LiuYanShow.html", dtMsg.Rows);
                context.Response.Write(html);
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