using Divers_Hotel.Data;
using Divers_Hotel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Divers_Hotel.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Info()
        {
            ViewData["Rooms"] = _context.RoomTypes.Count();
            ViewData["Meals"] = _context.MealTypes.Count();
            ViewData["Seasons"] = _context.Seasons.Count();
            ViewData["Reservations"] = _context.Reservations.Count();
            return View();
        }
        public IActionResult Index()
        {
            ViewData["Rooms"]= _context.RoomTypes.Count();
            ViewData["Meals"] = _context.MealTypes.Count();
            ViewData["Seasons"] = _context.Seasons.Count();
            ViewData["Reservations"] = _context.Reservations.Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // For selecting the language
        [HttpPost]
        public IActionResult SelectLang(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            return LocalRedirect(returnUrl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
