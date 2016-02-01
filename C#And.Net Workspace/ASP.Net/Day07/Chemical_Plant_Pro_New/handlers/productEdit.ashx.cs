using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro_New.handlers
{
    /// <summary>
    /// productEdit 的摘要说明
    /// </summary>
    public class productEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string html = null;
            string action = context.Request["action"];
            if (String.IsNullOrEmpty(action))
            {
                context.Response.Write("<h2>没有传入必要的参数！</h2>");
            }
            else
            {
                if (action == "addNew")
                {
                    string save = context.Request["save"];
                    if (String.IsNullOrEmpty(save))             //  sava为空，则页面为新增展示页面
                    {
                        DataTable dtCategory = SQLHelper.ExecuteDataTable("select * from T_ProductCategory");
                        var data = new { Action = "addNew", productCategories = dtCategory.Rows };
                        html = NVelocity.ReturnHtml("Admin/productEdit.html", data);
                        context.Response.Write(html);
                    }
                    else
                    {
                        //  获取页面传递的表单中的值
                        string productName = context.Request["productName"];                
                        int proCategoryId = Convert.ToInt32(context.Request["proCategory"]);
                        string proDescription = context.Request["proDescription"];

                        //  获取上传的图片
                        HttpPostedFile imgFile = context.Request.Files["proImage"];
                        Guid newGuid = Guid.NewGuid();
                        string fileName = newGuid.ToString() + Path.GetExtension(imgFile.FileName);
                        string filePath = context.Server.MapPath("~/images/productImg/");
                        imgFile.SaveAs(filePath + fileName);
                        string imgPath = "../images/productImg/" + fileName;

                        SQLHelper.ExecuteNonQuery("insert into T_Products (Name, ImagePath, ProductDescription, CategoryId) values(@Name, @ImagePath, @ProductDescription, @CategoryId)",
                            new SqlParameter("@Name", productName),
                            new SqlParameter("@ImagePath", imgPath),
                            new SqlParameter("@ProductDescription", proDescription),
                            new SqlParameter("@CategoryId", proCategoryId));

                        context.Response.Redirect("productList.ashx");
                    }
                }
                else if (action == "edit")
                {
                    string save = context.Request["save"];
                    if (String.IsNullOrEmpty(save))             //  编辑显示
                    {
                        int id = Convert.ToInt32(context.Request["Id"]);
                        DataTable dtProducts = SQLHelper.ExecuteDataTable("select * from T_Products where Id=@Id", new SqlParameter("@Id", id));
                        if (dtProducts.Rows.Count <= 0)
                        {
                            context.Response.Write("产品ID为" + id + "的数据不存在！");
                        }
                        else if (dtProducts.Rows.Count > 1)
                        {
                            context.Response.Write("产品ID为" + id + "的数据存在多条！");
                        }
                        else
                        {
                            DataRow theProduct = dtProducts.Rows[0];
                            DataTable dtProCategories = SQLHelper.ExecuteDataTable("select * from T_ProductCategory");
                            var data = new { Action = "edit", Product = theProduct, ProCategories = dtProCategories.Rows };
                            html = NVelocity.ReturnHtml("Admin/productEdit.html", data);
                            context.Response.Write(html);
                        }
                    }
                    else
                    {
                                
                    }
                    
                }
                else if (action == "delete")
                {
                    int Id = Convert.ToInt32(context.Request["Id"]);
                    SQLHelper.ExecuteNonQuery("delete from T_Products where Id=@Id", new SqlParameter("@Id", Id));
                    context.Response.Redirect("productList.ashx");
                }
                else
                {
                    context.Response.Write("<h2>参数错误！</h2>");
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