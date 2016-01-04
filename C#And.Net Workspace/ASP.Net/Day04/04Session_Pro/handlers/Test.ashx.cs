using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04Session_Pro.handlers
{
    /// <summary>
    /// Test 的摘要说明
    /// </summary>
    public class Test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            if (context.Request.Cookies != null)
            {
                HttpCookie myCookie = context.Request.Cookies["ZhangBenId"];
                string userId = myCookie.Value;
                Guid id = new Guid(userId);     //  根据得到的userId生成GUID变量id
                if (SessionMgr.IsJiZhang(id))
                {
                    string userName = SessionMgr.HuoQu(id);
                    context.Response.Write("用户" + userName + "登录成功！");
                }
                else
                {
                    context.Response.Redirect("Login.ashx");
                }
            }
            else
            {
                context.Response.Redirect("Login.ashx");
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