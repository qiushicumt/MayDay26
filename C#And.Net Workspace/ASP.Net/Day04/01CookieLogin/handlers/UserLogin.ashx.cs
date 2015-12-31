using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01CookieLogin.handlers
{
    /// <summary>
    /// UserLogin 的摘要说明
    /// </summary>
    public class UserLogin : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string login = context.Request["login"];
            if (String.IsNullOrEmpty(login))
            {
                HttpCookie userCookie = context.Request.Cookies["UserName"];
                if (userCookie != null)
                {
                    if (String.IsNullOrEmpty(userCookie.Value))
                    {
                        var data = new { Info = "", UserName = "" };
                        html = NVelocity.ReturnHtml("UserLogin.html", data);
                    }
                    else
                    {
                        var data = new { Info = "", UserName = userCookie.Value };
                        html = NVelocity.ReturnHtml("UserLogin.html", data);
                    }
                    context.Response.Write(html);
                }
                else
                {
                    var data = new { Info = "", UserName = "" };
                    html = NVelocity.ReturnHtml("UserLogin.html", data);
                    context.Response.Write(html);
                }
            }
            else
            {
                string remUser = context.Request["remember"];
                if(String.IsNullOrEmpty(remUser))
                {
                    var data = new { Info = "登录成功！", UserName = "" };
                    html = NVelocity.ReturnHtml("UserLogin.html", data);
                    context.Response.Write(html);
                }
                else
                {
                    string userName = context.Request["username"];
                    //  直接写入Cookie-->　context.Response.SetCookie(new HttpCookie("UserName", userName));
                    HttpCookie userCookie = new HttpCookie("UserName", userName);   //  声明一个Cookie对象，保存UserName的值
                    userCookie.Expires = DateTime.Now.AddDays(3);                   //  设置cookie的Expires属性，就可以给Cookie设置时限
                    var data = new { Info = "登录成功！", UserName = "" };
                    html = NVelocity.ReturnHtml("UserLogin.html", data);      
                    context.Response.Write(html);
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