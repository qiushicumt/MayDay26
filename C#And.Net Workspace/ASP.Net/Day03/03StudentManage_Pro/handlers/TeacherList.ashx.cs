using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _03StudentManage_Pro.handlers
{
    /// <summary>
    /// TeacherList 的摘要说明
    /// </summary>
    public class TeacherList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;

            DataTable dtTeacher = SQLHelper.ExecuteDataTable("select * from T_Teacher");
            html = NVelocity.ReturnHtml("TeacherList.html", dtTeacher.Rows);

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