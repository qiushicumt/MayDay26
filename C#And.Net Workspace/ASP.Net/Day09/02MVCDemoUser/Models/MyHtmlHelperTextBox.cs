using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class MyHtmlHelperTextBox
    {
        public static HtmlString MyHtmlTextBox(this HtmlHelper myHelper, string text)
        {
            //  return new HtmlString(string.Format("<input type='textbox' value='{0}'>", text));
            return new HtmlString(string.Format("<input type='text' value='{0}'>", text));
        }
    }
}