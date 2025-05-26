
using Microsoft.AspNetCore.Mvc;

namespace OnlineCabBooking.Controllers
{
    public class RiderController : Controller
    {
        public IActionResult Track()
        {
            return View();
        }
    }
}
