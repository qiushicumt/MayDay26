using _02PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            string greetingStr = hour < 12 ? "Good morning" : "Good afternoon";
            ViewBag.Greeting = greetingStr;

            return View();
        }

        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestresponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestresponse);
            }
            else
            {
                return View();
            }
        }
    }
}
