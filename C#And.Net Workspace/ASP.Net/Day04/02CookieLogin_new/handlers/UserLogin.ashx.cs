using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02CookieLogin_new.handlers
{
    /// <summary>
    /// UserLogin 的摘要说明
    /// </summary>
    public class UserLogin : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string login = context.Request["login"];
            string html = null;
            if (String.IsNullOrEmpty(login))    //  展示登录页面
            {
                //  HttpCookie userCookie = new HttpCookie("UserName");
                HttpCookie userCookie = context.Request.Cookies["UserName"];    //  捕获是否有名为UserName的Cookie
                if (userCookie == null)
                {
                    var data = new { UserName = "", Info = "" };
                    html = NVelocity.ReturnHtml("UserLogin.html", data);
                }
                else
                {
                    string userName = userCookie.Value;
                    var data = new { UserName = userName, Info = "" };
                    html = NVelocity.ReturnHtml("UserLogin.html", data);
                }
                context.Response.Write(html);
            }
            else
            {
                //  保存按钮被点击
                string remember = context.Request["remember"];
                if (String.IsNullOrEmpty(remember))
                {
                    var data = new { UserName = "", Info = "登录成功" };
                    html = NVelocity.ReturnHtml("UserLogin.html", data);
                }
                else
                {
                    string userName = context.Request["username"];
                    HttpCookie userCookie = new HttpCookie("UserName", userName);
                    userCookie.Expires = DateTime.Now.AddDays(5);           //  设置cookie的Expires属性，即设置cookie的时限为当前时间的5天后
                    context.Response.SetCookie(userCookie);                 //  将写好的Cookie返回给浏览器
                    var data = new { UserName = "", Info = "登录成功" };
                    html = NVelocity.ReturnHtml("UserLogin.html", data);                    
                }
                context.Response.Write(html);
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