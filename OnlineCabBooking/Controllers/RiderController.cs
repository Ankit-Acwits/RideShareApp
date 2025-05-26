
using Microsoft.AspNetCore.Mvc;

namespace OnlineCabBooking.Controllers
{
    public class RiderController : Controller
    {
        public IActionResult Register() => View();
        public IActionResult Login() => View();
        public IActionResult Dashboard() => View();
    }
}
