using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03StudentManage_Pro
{
    public static class NVelocity
    {
        /// <summary>
        /// NVelocity渲染引擎的封装
        /// </summary>
        /// <param name="templateFile">模板文件名</param>
        /// <param name="obj">替换的数据字段名称</param>
        /// <returns>返回html页面渲染代码</returns>
        public static string ReturnHtml(string templateFile, object obj)
        {
            string html = null;
            VelocityEngine vltEngine = new VelocityEngine();
            vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
            vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模板文件所在的文件夹
            vltEngine.Init();

            VelocityContext vltContext = new VelocityContext();
            vltContext.Put("Data", obj);//设置参数，在模板中可以通过$data来引用

            Template vltTemplate = vltEngine.GetTemplate(templateFile);
            System.IO.StringWriter vltWriter = new System.IO.StringWriter();
            vltTemplate.Merge(vltContext, vltWriter);

            html = vltWriter.GetStringBuilder().ToString();
            return html;
        }
    }
}