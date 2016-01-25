using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.handlers
{
    /// <summary>
    /// ImageUpload 的摘要说明
    /// </summary>
    public class ImageUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string save = context.Request["save"];
            if (String.IsNullOrEmpty(save))
            {
                context.Response.Write("没有提交任何数据");
            }
            else
            {
                HttpFileCollection files = context.Request.Files;
                if (files.Count > 0)
                {
                    HttpPostedFile postedFile = files[0];
                    string fileName = System.IO.Path.GetFileName(postedFile.FileName);
                    string directory = context.Server.MapPath("/image/");
                    string path = directory + fileName;
                    postedFile.SaveAs(path);
                }
                context.Response.Write("上传成功");
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