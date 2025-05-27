
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineCabBooking.Models;

namespace OnlineCabBooking.Controllers
{
    public class RiderController : Controller
    {
        public static List<Ride> Rides = new List<Ride>();

        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(Ride ride)
        {
            ride.Status = "Requested";
            Rides.Add(ride);
            ViewBag.Message = "Ride booked successfully!";
            return View("Book", ride);
        }

        public IActionResult RiderHistory()
        {
            return View(Rides);
        }

        public IActionResult Assigned()
        {
            return View(Rides.FindAll(r => r.Status == "Requested"));
        }

        public IActionResult Accept(int id)
        {
            var ride = Rides.Find(r => r.Id == id);
            if (ride != null) ride.Status = "Accepted";
            return RedirectToAction("Assigned");
        }

        public IActionResult Complete(int id)
        {
            var ride = Rides.Find(r => r.Id == id);
            if (ride != null) ride.Status = "Completed";
            return RedirectToAction("Assigned");
        }
        public IActionResult Register() => View();
        public IActionResult Login() => View();
        public IActionResult Dashboard() => View();

    }
}
