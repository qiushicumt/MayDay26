using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro_New.handlers
{
    /// <summary>
    /// frontProductList 的摘要说明
    /// </summary>
    public class frontProductList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            int pageNum;
            if(string.IsNullOrEmpty(context.Request["PageNum"]))
            {
                pageNum=1;
            }
            else 
            {
                pageNum = Convert.ToInt32(context.Request["PageNum"]);
            }
            int startNum = 9*(pageNum-1)+1; 
            int endNum = 9*pageNum;
            DataTable dtProducts = SQLHelper.ExecuteDataTable("select * from (select *, row_number() over (order by p.Id asc) as Num from T_Products p) as s where s.Num between @Start and @End",
                new SqlParameter("@Start",startNum),
                new SqlParameter("@End", endNum));
            var data = new { Products = dtProducts.Rows };
            html = NVelocity.ReturnHtml("/Front/productList.html", data);
            context.Response.Write(html);
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