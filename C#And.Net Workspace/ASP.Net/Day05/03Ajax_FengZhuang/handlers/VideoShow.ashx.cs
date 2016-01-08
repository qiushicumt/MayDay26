using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _03Ajax_FengZhuang.handlers
{
    /// <summary>
    /// VideoShow 的摘要说明
    /// </summary>
    public class VideoShow : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string action = context.Request["action"];
            if (action != null && action != "")
            {
                if (action == "zan")
                {
                    int zanCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 ZanCount from T_ZanCai"));
                    zanCount++;
                    SQLHelper.ExecuteNonQuery("update T_ZanCai set ZanCount=@ZanCount where Id=1", new SqlParameter("@ZanCount", zanCount));
                    context.Response.Write(zanCount);
                }
                else
                {
                    int caiCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 CaiCount from T_ZanCai"));
                    caiCount++;
                    SQLHelper.ExecuteNonQuery("update T_ZanCai set CaiCount=@CaiCount where Id=1", new SqlParameter("@CaiCount", caiCount));
                    context.Response.Write(caiCount);
                }
            }
            else
            {
                int zanCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 ZanCount from T_ZanCai"));
                int caiCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 CaiCount from T_ZanCai"));
                var data = new { ZanCount = zanCount, CaiCount = caiCount };
                html = NVelocity.ReturnHtml("VideoShow.html", data);
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