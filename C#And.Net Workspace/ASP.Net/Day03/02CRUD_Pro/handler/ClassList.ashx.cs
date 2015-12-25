using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _02CRUD_Pro.handler
{
    /// <summary>
    /// ClassList 的摘要说明
    /// </summary>
    public class ClassList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            //  查询数据库中T_Classes表，显示列表页面
            DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Classes");
            string html = NVelocity.ReturnHtml("ClassList.html", dtClass.Rows);
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