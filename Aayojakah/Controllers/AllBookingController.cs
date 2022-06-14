using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aayojakah.Controllers
{
    public class AllBookingController : Controller
    {

        public IActionResult Bookings()
        {
            return View();
        }
    }
}
