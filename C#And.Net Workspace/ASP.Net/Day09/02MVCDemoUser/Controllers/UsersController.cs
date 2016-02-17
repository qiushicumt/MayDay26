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

        public ActionResult UserList()
        {

            DataTable dtUsers = SQLHelper.ExecuteDataTable("select * from T_UserInfo");
            ViewData["User"] = dtUsers;

            return View();
        }

        public ActionResult UserEdit()
        {
            ViewData["City"] = new List<SelectListItem>(){
                new SelectListItem(){Text="北京", Value="1"},
                new SelectListItem(){Text="上海", Value="2"},
                new SelectListItem(){Text="广州", Value="3"}
            };
            return View();
        }

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
    }
}
