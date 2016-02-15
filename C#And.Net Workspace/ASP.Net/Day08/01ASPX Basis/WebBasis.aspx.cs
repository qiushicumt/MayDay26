using System;
using System.Collections.Generic;
using System.Data;
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
            if (IsPostBack)
            {
                
            }
            else
            {
                DataTable dtProduct = SQLHelper.ExecuteDataTable("select * from T_Products");
                ProductDDL.DataSource = dtProduct;
                ProductDDL.DataBind();
                Label1.Text = "1";
            }
        }

        public void SayHello()
        {
            Response.Write("This is my first aspx!");
        }

        protected string SayHello2()
        {
            return "This is my first aspx!";
        }

        protected void ClickBtn_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }
        //  当DropDownList改变值的时候，触发下面的方法
        protected void ProDropDownChanged(object sender, EventArgs e)   
        {
            Label1.Text = ProductDDL.SelectedValue;
        }

        
    }
}