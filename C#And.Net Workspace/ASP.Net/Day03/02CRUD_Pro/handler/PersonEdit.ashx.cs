using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _02CRUD_Pro.handler
{
    /// <summary>
    /// PersonEdit 的摘要说明
    /// </summary>
    public class PersonEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string action = context.Request["action"];  //  接收用户提交的请求，请求新增，action=AddNew，请求编辑，action=Edit
            if (action == "AddNew")
            {
                string save = context.Request["save"];
                //  save==True，表示新增保存，则读取页面中的对应字段，保存到数据表中
                if (save == "True")
                {
                    //  读取表单中的用户填写的各字段
                    string name = context.Request["Name"];
                    int age = Convert.ToInt32(context.Request["Age"]);
                    string email = context.Request["Email"];
                    SQLHelper.ExecuteNonQuery("Insert into T_Person(Name, Age, Email) values(@Name, @Age, @Email)", 
                        new SqlParameter("@Name",name),
                        new SqlParameter("@Age", age),
                        new SqlParameter("@Email", email)
                        );
                    context.Response.Redirect("PersonList.ashx");   //  保存成功后页面转向PersonList显示页面
                }
                //  save!=True，表示的展示新增页面，则渲染一个空白的新增成员的页面，返回给浏览器
                else
                {
                    var data = new { Action = "AddNew" };       //  向模板传递action值
                    html = NVelocity.ReturnHtml("PersonEdit.html", data);
                }               
            }
            else if (action == "Edit")
            {
                string save = context.Request["save"];
                
                //  save==True，表示编辑保存
                if (save == "True")
                {
                    int id = Convert.ToInt32(context.Request["Id"]);        //  当用户点击保存按钮时，接收传递的Id的值
                    string name = context.Request["Name"];
                    int age = Convert.ToInt32(context.Request["Age"]);
                    string email = context.Request["Email"];
                    SQLHelper.ExecuteNonQuery("update T_Person set Name=@Name, Age=@Age, Email=@Email where Id=@Id",
                        new SqlParameter("@Name", name),
                        new SqlParameter("@Age", age),
                        new SqlParameter("@Email", email),
                        new SqlParameter("@Id", id)
                        );
                    context.Response.Redirect("PersonList.ashx");
                }
                //  只是显示编辑页面
                else
                {
                    int id = Convert.ToInt32(context.Request["Id"]);    //  获得编辑的数据的id
                    DataTable dt = SQLHelper.ExecuteDataTable("select * from T_Person where Id=@Id", new SqlParameter("@Id", id));
                    if (dt.Rows.Count <= 0)
                    {
                        context.Response.Write("查询的ID数据不存在");
                    }
                    else if (dt.Rows.Count > 1)
                    {
                        context.Response.Write("查询到多条数据");
                    }
                    else 
                    {
                        DataRow row = dt.Rows[0];
                        var data = new { Action = "Edit", Person = row };
                        html = NVelocity.ReturnHtml("PersonEdit.html", data);
                    }   
                }
            }
            else
            {
                context.Response.Write("Action参数错误!");
            }

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