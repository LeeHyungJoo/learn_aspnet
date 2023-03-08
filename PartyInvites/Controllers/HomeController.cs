using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.Greeting = DateTime.Now.Hour < 12 ? "Morning" : "Afternoon";
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}