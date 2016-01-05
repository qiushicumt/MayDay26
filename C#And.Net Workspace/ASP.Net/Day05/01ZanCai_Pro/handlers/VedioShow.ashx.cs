using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _01ZanCai_Pro.handlers
{
    /// <summary>
    /// VedioShow 的摘要说明
    /// </summary>
    public class VedioShow : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;

            string isSubmit = context.Request["submit"];
            if (String.IsNullOrEmpty(isSubmit))
            {
                int zanCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 ZanCount from T_ZanCai"));
                int caiCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 CaiCount from T_ZanCai"));
                var data = new { ZanCount = zanCount, CaiCount = caiCount };
                html = NVelocity.ReturnHtml("VedioShow.html", data);
                context.Response.Write(html);
            }
            else
            {
                string zanSub = context.Request["zan"];
                if (zanSub != null && zanSub != "")
                {
                    int zanCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 ZanCount from T_ZanCai"));
                    int caiCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 CaiCount from T_ZanCai"));
                    zanCount++;
                    SQLHelper.ExecuteNonQuery("update T_ZanCai set ZanCount=@ZanCount where Id=1", new SqlParameter("@ZanCount", zanCount));
                    var data = new { ZanCount = zanCount, CaiCount = caiCount };
                    html = NVelocity.ReturnHtml("VedioShow.html", data);
                    context.Response.Write(html);
                }
                else
                {
                    int zanCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 ZanCount from T_ZanCai"));
                    int caiCount = Convert.ToInt32(SQLHelper.ExecuteScalar("select top 1 CaiCount from T_ZanCai"));
                    caiCount++;
                    SQLHelper.ExecuteNonQuery("update T_ZanCai set CaiCount=@CaiCount where Id=1", new SqlParameter("@CaiCount", caiCount));
                    var data = new { ZanCount = zanCount, CaiCount = caiCount };
                    html = NVelocity.ReturnHtml("VedioShow.html", data);
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