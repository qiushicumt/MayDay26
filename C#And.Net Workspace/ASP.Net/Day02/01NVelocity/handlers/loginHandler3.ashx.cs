using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01NVelocity.handlers
{
    /// <summary>
    /// loginHandler3 的摘要说明
    /// </summary>
    public class loginHandler3 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            List<Singer> singers = new List<Singer>();

            singers.Add(new Singer("刘德华", 52, "忘情水"));
            singers.Add(new Singer("张学友", 54, "吻别"));
            singers.Add(new Singer("阿信", 40, "志明与春娇"));

            VelocityEngine vltEngine = new VelocityEngine();
            vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
            vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模板文件所在的文件夹
            vltEngine.Init();

            VelocityContext vltContext = new VelocityContext();

            vltContext.Put("Singers", singers);    //设置参数，在模板中可以通过$data来引用，给模板中的$data数据赋值

            Template vltTemplate = vltEngine.GetTemplate("test3.html");
            System.IO.StringWriter vltWriter = new System.IO.StringWriter();
            vltTemplate.Merge(vltContext, vltWriter);

            string html = vltWriter.GetStringBuilder().ToString();

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