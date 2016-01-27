using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ChouJiang.handlers
{
    /// <summary>
    /// ChouJiang 的摘要说明
    /// </summary>
    public class ChouJiang : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            int lotteryType = Convert.ToInt32(context.Request["lotteryType"]);
            DataTable dtLotteryList = SQLHelper.ExecuteDataTable("select * from ChouJiang");
            if (lotteryType == 1)
            {
                var data = new { LotteryString = "抽取一等奖" };
                html = NVelocity.ReturnHtml("ChouJiang.html", data);
                context.Response.Write(html);
            }
            else if (lotteryType == 2)
            {
                var data = new { LotteryString = "抽取二等奖" };
                html = NVelocity.ReturnHtml("ChouJiang.html", data);
                context.Response.Write(html);
            }
            else if (lotteryType == 3)
            {
                var data = new { LotteryString = "抽取三等奖" };
                html = NVelocity.ReturnHtml("ChouJiang.html", data);
                context.Response.Write(html);
            }
            else
            {
                context.Response.Write("参数错误！");
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