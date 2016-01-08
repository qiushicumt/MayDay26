using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _04UserRegister_Pro.handlers
{
    /// <summary>
    /// Register 的摘要说明
    /// </summary>
    public class Register : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string userName = context.Request["username"];            
            if (String.IsNullOrEmpty(userName))
            {
                context.Response.Write("Empty");
            }
            else
            {
                int userCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select count(*) from T_User where UserName=@UserName", new SqlParameter("@UserName", userName)));
                if (userCount <= 0)
                {
                    context.Response.Write("Yes");
                }
                else if (userCount > 0)
                {
                    context.Response.Write("No");
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