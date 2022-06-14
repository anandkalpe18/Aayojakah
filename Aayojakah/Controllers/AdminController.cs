using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aayojakah.Filters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aayojakah.Controllers
{
    [ValidateAdminSession]
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
