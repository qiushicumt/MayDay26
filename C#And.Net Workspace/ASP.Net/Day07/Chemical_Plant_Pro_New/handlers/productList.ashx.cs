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
            #region 两个查询语句查询两个表的写法
            /*  
            context.Response.ContentType = "text/html";
            DataTable dtProducts = SQLHelper.ExecuteDataTable("select * from T_Products");
            DataTable dtProCategory = SQLHelper.ExecuteDataTable("select * from T_ProductCategory");
            
            var data = new { Products = dtProducts.Rows, ProCategories = dtProCategory.Rows };
            string html = NVelocity.ReturnHtml("Admin/productList.html", data);
            context.Response.Write(html);
             * */
            #endregion

            #region 一句SQL联查两个表 left join
            /*
            context.Response.ContentType = "text/html";
            string html = null;

            DataTable dtProducts = SQLHelper.ExecuteDataTable("select p.Id as ProductId, p.Name as ProductName, c.Name as CategoryName from T_Products p left join T_ProductCategory c on p.CategoryId = c.Id");
            var data = new { Products = dtProducts.Rows };
            html = NVelocity.ReturnHtml("Admin/productList.html", data);
            context.Response.Write(html);
            */
            #endregion

            #region 通过浏览器的？PageNum，进行分页查询数据
            /*
            context.Response.ContentType = "text/html";
            string html = null;
            int pageNum = 1;
            if (String.IsNullOrEmpty(context.Request["PageNum"]))
            {
                context.Response.Write("没有输入显示的页数！不显示！");
            }
            else
            {
                pageNum = Convert.ToInt32(context.Request["PageNum"]);
                int startNum = 8 * (pageNum - 1) + 1;
                int endNum = 8 * pageNum;
                
                DataTable dtProducts = SQLHelper.ExecuteDataTable("select * from (select p.Id as ProductId, p.Name as ProductName, c.Name as CategoryName ,row_number() over (order by p.Id asc) as Num from T_Products p left join T_ProductCategory c on p.CategoryId=c.Id ) as s where s.Num between @Start and @End", 
                    new SqlParameter("@Start", startNum),
                    new SqlParameter("@End", endNum));
                
                var data = new { Products = dtProducts.Rows };
                html = NVelocity.ReturnHtml("Admin/productList.html", data);
                context.Response.Write(html);
            }
            */           
            #endregion

            #region 创建分页按钮进行分页查询

            context.Response.ContentType = "text/html";
            string html = null;
            int pageNum;            //  从前台接收到的页面数，即第几页 
            if (String.IsNullOrEmpty(context.Request["PageNum"]))
            {
                pageNum = 1;
            }
            else
            {
                pageNum = Convert.ToInt32(context.Request["PageNum"]);                      
            }
            int dataCount = (SQLHelper.ExecuteDataTable("select * from T_Products")).Rows.Count;        //  总的数据条数
            int pageCount = (int)Math.Ceiling(dataCount / 8.0);         //  分页的数目   
            int startNum = 8*(pageNum-1)+1;
            int endNum = 8*(pageNum);
            DataTable dtProducts = SQLHelper.ExecuteDataTable("select * from (select p.Id as ProductId, p.Name as ProductName, c.Name as CategoryName,row_number() over (order by p.Id asc) as Num from T_Products p left join T_ProductCategory c on p.CategoryId=c.Id ) as s where s.Num between @Start and @End",
                new SqlParameter("@Start", startNum),
                new SqlParameter("@End", endNum));
            object[] pageData = new object[pageCount];
            for (int i = 0; i < pageCount; i++)
            {
                pageData[i] = new { Href = "productList.ashx?PageNum=" + (i + 1), ThePage = i + 1 };
            }
            var data = new { Products = dtProducts.Rows, PageDatas = pageData, CurrentPage = pageNum };
            html = NVelocity.ReturnHtml("Admin/productList.html", data);
            context.Response.Write(html);
            
            #endregion
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