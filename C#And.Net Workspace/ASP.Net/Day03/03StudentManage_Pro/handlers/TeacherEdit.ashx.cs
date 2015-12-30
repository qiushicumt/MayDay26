using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _03StudentManage_Pro.handlers
{
    /// <summary>
    /// TeacherEdit 的摘要说明
    /// </summary>
    public class TeacherEdit : IHttpHandler
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
                    var data = new { Action = "AddNew" };
                    html = NVelocity.ReturnHtml("TeacherEdit.html", data);
                    context.Response.Write(html);
                }
                else
                {
                    string teaName = context.Request["Name"];
                    DateTime teaBirthday = Convert.ToDateTime(context.Request["Birthday"]);
                    string teaPhone = context.Request["PhoneNum"];
                    string teaEmail = context.Request["Email"];
                    SQLHelper.ExecuteNonQuery("insert into T_Teacher(Name, Birthday, PhoneNum, Email) values(@Name, @Birthday, @PhoneNum, @Email)",
                        new SqlParameter("@Name", teaName),
                        new SqlParameter("@Birthday", teaBirthday),
                        new SqlParameter("@PhoneNum", teaPhone),
                        new SqlParameter("@Email", teaEmail));
                    context.Response.Redirect("TeacherList.ashx");
                }
            }
            else if (action == "Edit")
            {
                string save = context.Request["save"];
                //  判断save参数是否有值
                if (String.IsNullOrEmpty(save))
                {
                    int id = Convert.ToInt32(context.Request["Id"]);
                    DataTable dtTeacher = SQLHelper.ExecuteDataTable("select * from T_Teacher where Id=@Id", new SqlParameter("@Id", id));
                    if (dtTeacher.Rows.Count <= 0)
                    {
                        context.Response.Write("Id为"+id+"的数据不存在");
                    }
                    else if (dtTeacher.Rows.Count > 1)
                    {
                        context.Response.Write("Id为" + id + "的数据存在多条");
                    }
                    else
                    {
                        var data = new { Action = "Edit", Teacher = dtTeacher.Rows[0] };
                        html = NVelocity.ReturnHtml("TeacherEdit.html", data);
                        context.Response.Write(html);
                    }
                }
                else
                {
                    int id = Convert.ToInt32(context.Request["Id"]);
                    string teaName = context.Request["Name"];
                    DateTime teaBirthday = Convert.ToDateTime(context.Request["Birthday"]);
                    string teaPhone = context.Request["PhoneNum"];
                    string teaEmail = context.Request["Email"];
                    SQLHelper.ExecuteNonQuery("update T_Teacher set Name=@Name, Birthday=@Birthday, PhoneNum=@PhoneNum, Email=@Email where Id=@Id",
                        new SqlParameter("@Name", teaName),
                        new SqlParameter("@Birthday", teaBirthday),
                        new SqlParameter("@PhoneNum", teaPhone),
                        new SqlParameter("@Email", teaEmail),
                        new SqlParameter("@Id", id));
                    context.Response.Redirect("TeacherList.ashx");
                }
            }
            else if (action == "Delete")
            {
                int id = Convert.ToInt32(context.Request["Id"]);
                SQLHelper.ExecuteNonQuery("delete from T_Teacher where Id=@Id", new SqlParameter("@Id", id));
                context.Response.Redirect("TeacherList.ashx");
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