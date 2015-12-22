using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01NVelocity
{
    public class CommenHelper
    {
        /// <summary>
        /// NVelocity方法
        /// </summary>
        /// <param name="template">模板文件</param>
        /// <param name="obj">赋值对象</param>
        /// <returns>返回一个HTML</returns>
        public static string RenderHtml(string template, object obj)
        {
            VelocityEngine vltEngine = new VelocityEngine();
            vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
            vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模板文件所在的文件夹
            vltEngine.Init();

            VelocityContext vltContext = new VelocityContext();

            vltContext.Put("Obj", obj);    //设置参数，在模板中可以通过$Obj来引用，给模板中的$Obj数据赋值

            Template vltTemplate = vltEngine.GetTemplate(template);
            System.IO.StringWriter vltWriter = new System.IO.StringWriter();
            vltTemplate.Merge(vltContext, vltWriter);

            return vltWriter.GetStringBuilder().ToString();
        }
    }
}