using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace _02CRUD_Pro.handler
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

            //  新增数据
            if (action == "AddNew")
            {
                var data = new { Action = "AddNew" };
                string save = context.Request["save"];
                if (save == "True")
                {
                    string classname = context.Request["className"];
                    SQLHelper.ExecuteNonQuery("insert into T_Classes(Name) values(@Name)", new SqlParameter("@Name", classname));
                    context.Response.Redirect("ClassList.ashx");
                }
                else
                {
                    html = NVelocity.ReturnHtml("ClassEdit.html", data);
                    context.Response.Write(html);
                }
            }
            //  编辑数据
            else if (action == "Edit")
            {                
                string save = context.Request["save"];
                if (save == "True")
                {
                    int id = Convert.ToInt32(context.Request["Id"]);
                    string classname = context.Request["className"];
                    SQLHelper.ExecuteNonQuery("update T_Classes set Name=@Name where Id=@Id",
                        new SqlParameter("@Name", classname),
                        new SqlParameter("@Id", id));
                    context.Response.Redirect("ClassList.ashx");
                }
                else
                {
                    int id = Convert.ToInt32(context.Request["Id"]);
                    DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Classes where Id=@Id", new SqlParameter("@Id", id));
                    if (dtClass.Rows.Count <= 0)
                    {
                        context.Response.Write("查询不到Id为" + id + "的数据。");
                    }
                    else if (dtClass.Rows.Count > 1)
                    {
                        context.Response.Write("查询到多条Id为" + id + "的数据。");
                    }
                    else
                    {
                        DataRow row = dtClass.Rows[0];
                        var data = new { Action = "Edit", myClass = row };
                        html = NVelocity.ReturnHtml("ClassEdit.html", data);
                        context.Response.Write(html);
                    }
                }
            }
            //  删除数据
            else if (action == "Delete")
            {
                int id = Convert.ToInt32(context.Request["Id"]);
                SQLHelper.ExecuteNonQuery("delete from T_Classes where Id=@Id", new SqlParameter("@Id", id));
                context.Response.Redirect("ClassList.ashx");
            }
            else
            {
                context.Response.Write("Action参数无效！");
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