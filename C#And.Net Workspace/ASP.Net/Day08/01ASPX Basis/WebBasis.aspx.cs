using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01ASPX_Basis
{
    public partial class WebBasis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SayHello()
        {
            Response.Write("This is my first aspx!");
        }

        protected string SayHello2()
        {
            return "This is my first aspx!";
        }
    }
}