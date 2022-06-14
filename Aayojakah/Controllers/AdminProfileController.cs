using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aayojakah.Interface;
using Microsoft.AspNetCore.Http;
using Aayojakah.Filters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aayojakah.Controllers
{
    [ValidateAdminSession]
    public class AdminProfileController : Controller
    {
        IRegistration _IRepository;
        public AdminProfileController(IRegistration IRepository)
        {
            _IRepository = IRepository;
        }

        [HttpGet]
        public IActionResult Profile()
        {
            try
            {
                var profile = _IRepository.Admininformation(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                return View(profile);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
