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
                    if (String.IsNullOrEmpty(save))
                    {
                        DataTable dtProCategory = SQLHelper.ExecuteDataTable("select * from T_ProductCategory");
                        var data = new { Action = "addNew", ProCategories = dtProCategory.Rows };
                        html = NVelocity.ReturnHtml("Admin/productEdit.html", data);
                        context.Response.Write(html);
                    }
                    else
                    {
                        string proName = context.Request["productName"];
                        string proCategory = context.Request["proCategory"];
                        //  获取表单上传的图片
                        HttpPostedFile postImage = context.Request.Files["proImage"];
                        Guid myGuid = new Guid();                        
                        string imgName = myGuid.ToString() + Path.GetExtension(postImage.FileName);
                        string imgFilePath = context.Server.MapPath("~/images/");
                        postImage.SaveAs(imgFilePath + imgName);

                        string proImgPath = "../images/productImg/" + imgName;
                        string proDescription = context.Request["proDescription"];

                        DataTable dtProCategory = SQLHelper.ExecuteDataTable("select * from T_ProductCategory");

                        SQLHelper.ExecuteNonQuery("insert into T_Products(Name, ImagePath, ProductDescription, )");
                    }                                       
                }
                else if (action == "edit")
                {
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