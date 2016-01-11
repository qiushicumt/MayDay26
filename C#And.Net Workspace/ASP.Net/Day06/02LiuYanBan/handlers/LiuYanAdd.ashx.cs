using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _02LiuYanBan.handlers
{
    /// <summary>
    /// LiuYanAdd 的摘要说明
    /// </summary>
    public class LiuYanAdd : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string save = context.Request["publish"];
            if (String.IsNullOrEmpty(save))
            {
                html = NVelocity.ReturnHtml("LiuYanAdd.html", null);
                context.Response.Write(html);
            }
            else
            {
                string nickName = context.Request["nickname"];
                string textTitle = context.Request["texttitle"];                
                string checkName = context.Request["noname"];
                Boolean isNoName = false;
                if (checkName == "on")
                {
                    isNoName = true;
                }
                else
                {
                    isNoName = false;
                }
                string publishText = context.Request["publishtext"];
                DateTime publishTime = DateTime.Now;                    //  DateTime.Now属性可以获得当前时间
                string clientIP = context.Request.UserHostAddress;      //  context.Request.UserHostAddress属性可以从socket中获取客户端的IP

                SQLHelper.ExecuteNonQuery("insert into T_LiuYanBan(NickName, PublishTime, ClientIP, PublishText, IsNoName, TextTitle) values(@NickTime, @PublishTime, @ClientIP, @PublishText, @IsNoName, @TextTitle)",
                    new SqlParameter("@NickTime", nickName),
                    new SqlParameter("@PublishTime", publishTime),
                    new SqlParameter("@ClientIP", clientIP),
                    new SqlParameter("@PublishText", publishText),
                    new SqlParameter("@IsNoName", isNoName),
                    new SqlParameter("@TextTitle", textTitle));
                context.Response.Redirect("LiuYanShow.ashx");                  
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