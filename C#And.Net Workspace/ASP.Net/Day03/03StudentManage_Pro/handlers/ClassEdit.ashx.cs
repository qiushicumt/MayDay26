using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _03StudentManage_Pro.handlers
{
    /// <summary>
    /// ClassEdit 的摘要说明
    /// </summary>
    public class ClassEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string action = context.Request["action"];
            if (action == "AddNew")
            {
                string save = context.Request["save"];
                if (String.IsNullOrEmpty(save))
                {
                    DataTable dtTeacher = SQLHelper.ExecuteDataTable("select * from T_Teacher");
                    var data = new { Action = "AddNew", Teacher = dtTeacher.Rows };
                    html = NVelocity.ReturnHtml("ClassEdit.html", data);
                    context.Response.Write(html);
                }
                else
                {
                    string className = context.Request["ClassName"];
                    int classroomNum = Convert.ToInt32(context.Request["ClassroomNum"]);
                    int teacherId = Convert.ToInt32(context.Request["TeacherId"]);
                    SQLHelper.ExecuteNonQuery("insert into T_Class(ClassName, ClassroomNum, TeacherId) values(@ClassName, @ClassroomNum, @TeacherId)",
                        new SqlParameter("@ClassName", className),
                        new SqlParameter("@ClassroomNum", classroomNum),
                        new SqlParameter("@TeacherId", teacherId));
                    context.Response.Redirect("ClassList.ashx");
                }
            }
            else if (action == "Edit")
            {
                string save = context.Request["save"];
                if (String.IsNullOrEmpty(save))
                {
                    int id = Convert.ToInt32(context.Request["Id"]);
                    DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Class where Id=@Id", new SqlParameter("@Id", id));
                    if (dtClass.Rows.Count <= 0)
                    {
                        context.Response.Write("Id为" + id + "的数据不存在");
                    }
                    else if (dtClass.Rows.Count > 1)
                    {
                        context.Response.Write("Id为" + id + "的数据存在多条");
                    }
                    else
                    {
                        DataRow rowClass = dtClass.Rows[0];
                        DataTable dtTeacher = SQLHelper.ExecuteDataTable("select * from T_Teacher");
                        var data = new { Action = "Edit", Class = rowClass, Teacher = dtTeacher.Rows };
                        html = NVelocity.ReturnHtml("ClassEdit.html", data);
                        context.Response.Write(html);
                    }
                }
                else
                {
                    int id = Convert.ToInt32(context.Request["Id"]);
                    string className = context.Request["ClassName"];
                    int classroomNum = Convert.ToInt32(context.Request["ClassroomNum"]);
                    int teacherId = Convert.ToInt32(context.Request["TeacherId"]);
                    SQLHelper.ExecuteNonQuery("update T_Class set ClassName=@ClassName, ClassroomNum=@ClassroomNum, TeacherId=@TeacherId",
                        new SqlParameter("@ClassName", className),
                        new SqlParameter("@ClassroomName", classroomNum),
                        new SqlParameter("@TeacherId", teacherId));
                    context.Response.Redirect("ClassList.ashx");
                }
            }
            else if (action == "Delete")
            {
                int id = Convert.ToInt32(context.Request["Id"]);
                SQLHelper.ExecuteNonQuery("delete from T_Class where Id=@Id", new SqlParameter("@Id", id));
                context.Response.Redirect("ClassList.ashx");
            }
            else
            {
                context.Response.Write("Action参数错误");
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