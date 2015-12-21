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
    /// loginHandler2 的摘要说明
    /// </summary>
    public class loginHandler2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict["杜兰特"] = "俄克拉荷马雷霆队";
            //dict["莱昂纳德"] = "圣安东尼奥马刺队";
            //dict["保罗乔治"] = "印第安纳步行者队";
            //dict["詹姆斯"] = "克利夫兰骑士队";
            dict.Add("杜兰特", "俄克拉荷马雷霆队");
            dict.Add("莱昂纳德", "圣安东尼奥马刺队");
            dict.Add("保罗乔治", "印第安纳步行者队");
            dict.Add("詹姆斯", "克利夫兰骑士队");

            VelocityEngine vltEngine = new VelocityEngine();
            vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
            vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模板文件所在的文件夹
            vltEngine.Init();

            VelocityContext vltContext = new VelocityContext();

            vltContext.Put("playerDict", dict);    //设置参数，在模板中可以通过$data来引用，给模板中的$data数据赋值

            Template vltTemplate = vltEngine.GetTemplate("testDict.html");
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