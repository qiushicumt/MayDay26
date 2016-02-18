using _02MVCDemoUser.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02MVCDemoUser.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/

        #region UserList
		 	
        public ActionResult UserList()
        {

            DataTable dtUsers = SQLHelper.ExecuteDataTable("select * from T_UserInfo");
            ViewData["User"] = dtUsers;

            return View();
        }
        #endregion
        #region UserEdit新增用户的显示页面

        public ActionResult UserEdit()
        {
            ViewData["City"] = new List<SelectListItem>(){
                new SelectListItem(){Text="北京", Value="1"},
                new SelectListItem(){Text="上海", Value="2"},
                new SelectListItem(){Text="广州", Value="3"}
            };
            return View();
        }
        #endregion
        #region 处理注册用户
        public ActionResult AddUser()
        {
            string userName = Request["UserName"] ?? "Null";
            int age = 0;
            if (string.IsNullOrEmpty(Request["Age"]))
            {
                age = 1;
            }
            else
            {
                age = Convert.ToInt32(Request["Age"]);
            }
            SQLHelper.ExecuteNonQuery("insert into T_UserInfo(UserName, Age) values(@UserName, @Age)",
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Age", age));

            return RedirectToAction("UserList");
        }
        #endregion

        #region 弱类型视图传递数据
        public ActionResult UserShow()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Id = 10;
            userInfo.Age = 28;
            userInfo.UserName = "Paul";
            ViewData["UserInfo"] = userInfo;

            return View();
        }
        #endregion

        public ActionResult ModelUserShow()
        {
            UserInfo myUserInfo = new UserInfo();
            myUserInfo.Id = 12;
            myUserInfo.UserName = "东北F4之赵四";
            myUserInfo.Age = 46;

            //ViewData的Model属性赋值一个UserInfo实例对象
            ViewData.Model = myUserInfo;

            return View("UserShow");
        }
        
    }
}
