using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01NVelocity.handlers
{
    /// <summary>
    /// loginHandler4 的摘要说明
    /// </summary>
    public class loginHandler4 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            
            Person[] pers = new Person[3];
            pers[0] = new Person { Name = "张三" };
            pers[1] = new Person { Name = "李四" };
            pers[2] = new Person { Name = "王五" };

            //  调用NVelocity的方法，传入模板文件test4.html，传入对象pers
            string html = CommenHelper.RenderHtml("test4.html", pers);
            
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