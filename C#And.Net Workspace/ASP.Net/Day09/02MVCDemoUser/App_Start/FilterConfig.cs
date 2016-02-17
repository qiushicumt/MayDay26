using System.Web;
using System.Web.Mvc;

namespace _02MVCDemoUser
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}