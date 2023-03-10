using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;
namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private GuestResponseDBContext db = new GuestResponseDBContext();


        // GET: Home
        //Default Method
        public ViewResult Index()
        {
            ViewBag.Greeting = DateTime.Now.Hour < 12 ? "Morning" : "Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    db.guestResponses.Add(guestResponse);
                    db.SaveChanges();
                    
                    return View("Thanks", guestResponse);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("Name", e.Message.ToString());
                    return View(guestResponse);
                }
            }
            else
            {
                return View();
            }
        }

        public string TestParam(string name , int num = 1)
        {
            return HttpUtility.HtmlEncode("Hello, " + name + " [num : " + num + "]");
            //return HttpUtility.HtmlEncode("Hello");
        }

        public ViewResult ShowDBPage()
        {
            return View("DBPage", db.guestResponses);
        }
    }
}