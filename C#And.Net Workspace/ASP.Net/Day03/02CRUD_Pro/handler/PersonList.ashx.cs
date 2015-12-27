using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _02CRUD_Pro.handler
{
    /// <summary>
    /// PersonList 的摘要说明
    /// </summary>
    public class PersonList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            /*
            string html = null;

            DataTable dtPerson = SQLHelper.ExecuteDataTable("select * from T_Person");
            DataTable dtClass = SQLHelper.ExecuteDataTable("select * from T_Classes");

            context.Response.Write(html);
            */
            string html = null;
            //  调用SQLHelper的ExecuteDataTable方法，传入的参数为查询数据表的命令语句，返回查询得到的DataTable
            DataTable dt = SQLHelper.ExecuteDataTable("select * from T_Person");            

            //  DataTable.Rows属性是一个集合，可以被遍历，所以传递给NVelocity的方法
            html = NVelocity.ReturnHtml("PersonList.html", dt.Rows);

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