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
    /// loginHandler 的摘要说明
    /// </summary>
    public class loginHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //  获取传递给服务器的值
            string userName = context.Request["username"];
            string passWord = context.Request["password"];     
                   
            //  对传递给服务器的值进行判断，若用户输入为空，则页面渲染为登录页
            if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord))
            {
                VelocityEngine vltEngine = new VelocityEngine();
                vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
                vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模板文件所在的文件夹
                vltEngine.Init();

                VelocityContext vltContext = new VelocityContext();

                vltContext.Put("username", "");    //设置参数，在模板中可以通过$data来引用，给模板中的$data数据赋值
                vltContext.Put("password", "");
                vltContext.Put("message", "请输入用户名、密码");
                Template vltTemplate = vltEngine.GetTemplate("login.html");
                System.IO.StringWriter vltWriter = new System.IO.StringWriter();
                vltTemplate.Merge(vltContext, vltWriter);

                string html = vltWriter.GetStringBuilder().ToString();
                context.Response.Write(html);
            }
            else
            {
                if (userName == "admin" && passWord == "123")
                {
                    context.Response.Write("<h1>登录成功</h1>");
                }
                else
                {
                    VelocityEngine vltEngine = new VelocityEngine();
                    vltEngine.SetProperty(RuntimeConstants.RESOURCE_LOADER, "file");
                    vltEngine.SetProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, System.Web.Hosting.HostingEnvironment.MapPath("~/templates"));//模板文件所在的文件夹
                    vltEngine.Init();

                    VelocityContext vltContext = new VelocityContext();

                    vltContext.Put("username", userName);    //设置参数，在模板中可以通过$data来引用，给模板中的$data数据赋值
                    vltContext.Put("password", passWord);
                    vltContext.Put("message", "用户名或者密码不正确，请重新输入！");
                    Template vltTemplate = vltEngine.GetTemplate("login.html");
                    System.IO.StringWriter vltWriter = new System.IO.StringWriter();
                    vltTemplate.Merge(vltContext, vltWriter);

                    string html = vltWriter.GetStringBuilder().ToString();
                    context.Response.Write(html);
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