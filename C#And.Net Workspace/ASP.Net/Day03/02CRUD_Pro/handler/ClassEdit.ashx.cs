using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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
            if (action == "AddNew")
            {
                string save = context.Request["save"];
                if (save == "True")
                {
                    string classname = context.Request["className"];
                    SQLHelper.ExecuteNonQuery("insert into T_Classes(ClassName) values(@ClassName)", new SqlParameter("@ClassName", classname));
                    
                    context.Response.Redirect("ClassList.ashx");
                }
                else
                {
                    var data = new { Action = "AddNew" };
                    html = NVelocity.ReturnHtml("ClassEdit.html", data);
                    context.Response.Write(html);
                }
            }
            else if (action == "Edit")
            {
                string save = context.Request["save"];
                //  编辑保存状态
                if (save == "True")
                {
                    string classname = context.Request["className"];
                    int id = Convert.ToInt32(context.Request["Id"]);
                    SQLHelper.ExecuteNonQuery("update T_Classes set ClassName=@ClassName where Id=@Id",
                        new SqlParameter("@ClassName", classname),
                        new SqlParameter("@Id", id));
                    context.Response.Redirect("ClassList.ashx");
                }
                //  编辑显示状态
                else
                {
                    int id = Convert.ToInt32(context.Request["Id"]);
                    DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Classes where Id=@Id", new SqlParameter("@Id", id));
                    if (dtClass.Rows.Count <= 0)
                    {
                        context.Response.Write("查询到Id为" + id + "的数据不存在。");
                    }
                    else if (dtClass.Rows.Count > 1)
                    {
                        context.Response.Write("查询到Id为" + id + "的数据有多条。");
                    }
                    else 
                    {
                        DataRow row = dtClass.Rows[0];
                        var data = new { Action = "Edit", Classes = row };
                        html = NVelocity.ReturnHtml("ClassEdit.html", data);
                        context.Response.Write(html);
                    }
                }
            }
            else if (action == "Delete")
            {
                //int id = Convert.ToInt32(context.Request["Id"]);
                int id = Convert.ToInt32(context.Request["Id"]);
                SQLHelper.ExecuteNonQuery("delete from T_Classes where Id=@Id", new SqlParameter("@Id", id));
                context.Response.Redirect("ClassList.ashx");
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