using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace _06MVCFilterDemo.Models
{
    public class MyFilterAttribute:ActionFilterAttribute        //Filter类继承ActionFilterAttribute
    {
        public string Name { get; set; }

        //分别重写ActionFilterAttribute中的方法
        public override void OnActionExecuting(ActionExecutingContext filterContext)    
        {
            base.OnActionExecuting(filterContext);
            HttpContext.Current.Response.Write("<br />Action执行前调用 OnActionExecuting:"+Name);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            HttpContext.Current.Response.Write("<br />Action执行后调用 OnActionExecuted:" + Name);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            HttpContext.Current.Response.Write("<br />Result执行前调用 OnResultExecuting:" + Name);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            HttpContext.Current.Response.Write("<br />Result执行后调用 OnResultExecuted:" + Name);
        }
    }
}