using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro_New.handlers
{
    /// <summary>
    /// ProductList 的摘要说明
    /// </summary>
    public class ProductList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            DataTable dtProducts = SQLHelper.ExecuteDataTable("select * from T_Products");
            DataTable dtProCategory = SQLHelper.ExecuteDataTable("select * from T_ProductCategory");
            var data = new { Products = dtProducts.Rows, ProCategories = dtProCategory.Rows };
            string html = NVelocity.ReturnHtml("Admin/productList.html", data);
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