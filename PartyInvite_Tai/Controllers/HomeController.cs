using Microsoft.AspNetCore.Mvc;
using PartyInvite_Tai.Models;
using System.Diagnostics;
using System.Linq;


namespace PartyInvite_Tai.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
		public IActionResult RsvpForm(GuestResponse guestResponse)
		{
            if(ModelState.IsValid)
            {
                Responsitory.AddResponse(guestResponse);
			    return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
		} 
        public IActionResult ListResponses()
        {
            return View(Responsitory.Responses.Where(r => r.WillAttend == true));
        }
	}
}