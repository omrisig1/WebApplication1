using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OtoSpaMVC.Data;
using OtoSpaMVC.Models;
using OtoSpaMVC.Services;

namespace OtoSpaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  // can be used expicitly,
                                    // or across all mutate-mathods in all controllers (startup.cs)
        public async Task<IActionResult> Login(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction(nameof(About));
            }

            var identity = new ClaimsIdentity(
                new[] {
                    new Claim(ClaimTypes.Name, name),
                    new Claim(ClaimTypes.Role, "user"),     // with this, auth-ok, without "Forbidden".
                    new Claim(ClaimTypes.Role, "admin")     // with this, auth-ok, without "Forbidden".
                }, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction(nameof(About));
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(About));
            //throw new NotImplementedException();
        }

        public IActionResult ErrorNotLoggedIn() => View();
        public IActionResult ErrorForbidden() => View();

        [Authorize(Policy = "MustBeAdmin")]
        public IActionResult Manage() => View();


        public IActionResult About()
        {
            ViewData["Message"] = "Know us better.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public JsonResult GetWeather()
        {
            Weather weath = new Weather();

            return Json(weath.getWeatherForcast());
        }
        public ActionResult GoogleMap()
        {
            return View();
        }
        public ActionResult WeatherJS()
        {
            return View();
        }
        public ActionResult WeatherOrNot()
        {
            return View();
        }
    }
}
