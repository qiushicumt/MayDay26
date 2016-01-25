using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chemical_Plant_Pro_New
{
    public class NVelocity
    {
        /// <summary>
        /// 封装NVelocity的渲染方法
        /// </summary>
        /// <param name="templateFile">模板文件</param>
        /// <param name="obj">传递的模板对象值</param>
        /// <returns>返回HTML页面</returns>
        public static string ReturnHtml(string templateFile, object obj)
        {
            string html = null;

            VelocityEngine vltEngine = new VelocityEngine();
            vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
            vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模板文件所在的文件夹
            vltEngine.Init();

            VelocityContext vltContext = new VelocityContext();

            //  可以将一个实例对象赋值给模板页中的变量
            vltContext.Put("Data", obj);    //设置参数，在模板中可以通过$data来引用，给模板中的$data数据赋值

            Template vltTemplate = vltEngine.GetTemplate(templateFile);
            System.IO.StringWriter vltWriter = new System.IO.StringWriter();
            vltTemplate.Merge(vltContext, vltWriter);

            html = vltWriter.GetStringBuilder().ToString();

            return html;
        }
    }
}