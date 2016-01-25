using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro.handlers
{
    /// <summary>
    /// adminProductList 的摘要说明
    /// </summary>
    public class adminProductList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            DataTable dtProduct = SQLHelper.ExecuteDataTable("select T_Products.Id as Id, T_Products.Name as ProductName, T_ProductCategory.Name as CategoryName from T_Products left join T_ProductCategory on T_Products.CategoryId=T_ProductCategory.Id");
            var data = new { Products = dtProduct.Rows };
            html = NVelocity.ReturnHtml("/Admin/ProductList.html", data);
            context.Response.Write(html);

            /*  显示产品列表
             * 
            context.Response.ContentType = "text/html";
            string html = null;
            DataTable dtProduct = SQLHelper.ExecuteDataTable("select * from T_Products");
            var data = new { Products = dtProduct.Rows };
            html = NVelocity.ReturnHtml("/Admin/ProductList.html", data);
            context.Response.Write(html);
             * */
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