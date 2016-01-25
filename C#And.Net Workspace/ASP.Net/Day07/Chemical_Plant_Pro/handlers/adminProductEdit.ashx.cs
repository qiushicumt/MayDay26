using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro.handlers
{
    /// <summary>
    /// adminProductEdit 的摘要说明
    /// </summary>
    public class adminProductEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string action = context.Request["action"];
            if (String.IsNullOrEmpty(action))
            {
                context.Response.Write("请传入action参数");
            }
            else
            {
                if (action == "addProduct")
                {
                }
                else if (action == "editProduct")
                {
                }
                else if (action == "deleteProduct")
                {
                    int productId = Convert.ToInt32(context.Request["Id"]);
                    SQLHelper.ExecuteNonQuery("delete from T_Products where Id=@Id", new SqlParameter("@Id", productId));
                    context.Response.Redirect("adminProductList.ashx");
                }
                else
                {
                    context.Response.Write("传入的action参数错误");
                }
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