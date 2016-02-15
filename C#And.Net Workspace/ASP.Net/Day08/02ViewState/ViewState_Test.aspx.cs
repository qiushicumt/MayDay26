using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02ViewState
{
    public partial class ViewState_Test : System.Web.UI.Page
    {
        private int num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OldButtonClick(object sender, EventArgs e)
        {
            num++;
            TextLabel.Text = num.ToString();
        }

        /// <summary>
        /// 自写ViewState点击按钮进行数据的自增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Click(object sender, EventArgs e)
        {
            object data = this.ViewState["DataIndex"];
            if (data == null)
            {
                this.ViewState["DataIndex"] = 1;
            }
            else
            {
                int _data = (int)data;
                _data++;
                data = _data;
                this.ViewState["DataIndex"] = data;
            }
            TextLabel.Text = this.ViewState["DataIndex"].ToString();
        }

        protected void DefaultButtonClick(object sender, EventArgs e)
        {
            int labelNum = Convert.ToInt32(TextLabel.Text);
            labelNum++;
            TextLabel.Text = labelNum.ToString();
        }
    }
}