using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _03StudentManage_Pro.handlers
{
    /// <summary>
    /// ClassList 的摘要说明
    /// </summary>
    public class ClassList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Class");
            DataTable dtTeacher = SQLHelper.ExecuteDataTable("select * from T_Teacher");

            var data = new { Class = dtClass.Rows, Teacher = dtTeacher.Rows };
            html = NVelocity.ReturnHtml("ClassList.html", data);
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