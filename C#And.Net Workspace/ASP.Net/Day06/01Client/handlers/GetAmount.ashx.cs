using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01Client.handlers
{
    /// <summary>
    /// GetAmount 的摘要说明
    /// </summary>
    public class GetAmount : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string isPost = context.Request["isPostBack"];
            if (String.IsNullOrEmpty(isPost))
            {
                string html = NVelocity.ReturnHtml("GetAmount.html", null);
                context.Response.Write(html);
            }
            else
            {
                string myAmount = context.Request["amount"];
                if (String.IsNullOrEmpty(myAmount))
                {
                    context.Response.Write("没有输入取款金额");
                }
                else
                {
                    int amount = Convert.ToInt32(myAmount);
                    context.Response.Write("取款成功！取款金额为："+amount);
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