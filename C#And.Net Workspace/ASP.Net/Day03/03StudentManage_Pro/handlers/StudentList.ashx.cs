using System;
using System.Collections.Generic;
using System.Data;
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

            DataTable dtStudent = SQLHelper.ExecuteDataTable("select * from T_Student");
            DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Class");
            var data = new { Student = dtStudent.Rows, Class = dtClass.Rows };
            html = NVelocity.ReturnHtml("StudentList.html", data);

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