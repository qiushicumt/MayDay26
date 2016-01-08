using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _04UserRegister_Pro.handlers
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string userName = context.Request["username"];
            string password = context.Request["password"];
            SQLHelper.ExecuteNonQuery("insert into T_User(UserName, Password) values(@UserName, @Password)",
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password));
            context.Response.Write("注册成功！");
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