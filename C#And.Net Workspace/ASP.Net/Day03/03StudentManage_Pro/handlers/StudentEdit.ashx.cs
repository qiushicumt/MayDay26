using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

namespace _03StudentManage_Pro.handlers
{
    /// <summary>
    /// StudentEdit 的摘要说明
    /// </summary>
    public class StudentEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string action = context.Request["action"];

            //  根据传入的参数做出相应的编辑操作
            if (action == "AddNew")
            {
                string save = context.Request["save"];
                //  save为True，表示点击保存按钮，页面为保存，否则为展示页面
                if (save == "True")
                {
                    string stuName = context.Request["Name"];
                    string stuGender = context.Request["Gender"];
                    DateTime dt = Convert.ToDateTime(context.Request["Birthday"]);      //  设置DateTime格式
                    float stuHeight = float.Parse(context.Request["Height"]);
                    int stuClassId = Convert.ToInt32(context.Request["ClassId"]);
                    bool stuTeChang;
                    if (context.Request["IsTeChang"] == "True")
                    {
                        stuTeChang = true;
                    }
                    else
                    {
                        stuTeChang = false;
                    }
                    SQLHelper.ExecuteNonQuery("insert into T_Student(Name, Gender, Birthday, Height, ClassId, IsTeChang) values(@Name, @Gender, @Birthday, @Height, @ClassId, @IsTeChang)",
                        new SqlParameter("@Name", stuName),
                        new SqlParameter("@Gender", stuGender),
                        new SqlParameter("@Birthday", dt),
                        new SqlParameter("@Height", stuHeight),
                        new SqlParameter("@ClassId", stuClassId),
                        new SqlParameter("@IsTeChang", stuTeChang));
                    context.Response.Redirect("StudentList.ashx");
                }
                else 
                {
                    DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Class");
                    var data = new { Action = "AddNew", Class = dtClass.Rows };
                    html = NVelocity.ReturnHtml("StudentEdit.html", data);
                    context.Response.Write(html);
                }
            }
            else if (action == "Edit")
            {
                string save = context.Request["save"];
                //  save为True，表示点击保存按钮，页面为编辑保存，否则为展示编辑页面
                if (save == "True")
                {

                }
                else
                {
                    int id = Convert.ToInt32(context.Request["Id"]);
                    DataTable dtStu = SQLHelper.ExecuteDataTable("select * from T_Student where Id=@Id",
                        new SqlParameter("@Id", id));
                    if (dtStu.Rows.Count <= 0)
                    {
                        context.Response.Write("查询到ID为" + id + "的数据为0");
                    }
                    else if (dtStu.Rows.Count > 1)
                    {
                        context.Response.Write("查询到ID为" + id + "的数据有多条");
                    }
                    else
                    {                       
                        DataRow rowStu = dtStu.Rows[0];
                        int classId = Convert.ToInt32(context.Request["ClassId"]);
                        DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Class where Id=@Id", new SqlParameter("@Id", classId));
                        DataRow rowClass = dtClass.Rows[0];
                        var data = new { Action = "Edit", Student = rowStu, Class = rowClass };
                        html = NVelocity.ReturnHtml("StudentEdit.html", data);
                        context.Response.Write(html);
                    }
                }
            }
            else if (action == "Delete")
            {
                int id = Convert.ToInt32(context.Request["Id"]);
                SQLHelper.ExecuteNonQuery("delete from T_Student where Id=@Id", new SqlParameter("@Id", id));
                context.Response.Redirect("StudentList.ashx");
            }
            else
            {
                context.Response.Write("Action参数错误！");
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