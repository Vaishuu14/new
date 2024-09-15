using LibraryManagmentSystem.Application.Services;
using LibraryManagmentSystem.Domain.Entities;
using LibraryManagmentSystem.Domain.Interfaces;
using LibraryManagmentSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            try
            {
                var user = await _userService.AuthenticateUserAsync(model);
                // Set authentication cookies or session here
                // Example: HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, ...)
                return RedirectToAction("Index"); // Redirect to a logged-in user's homepage or dashboard
            }
            catch (UnauthorizedAccessException)
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(Registration model)
        {
            try
            {
                var user = await _userService.RegisterUserAsync(model);
                // Optionally, sign in the user after registration
                return RedirectToAction("Login"); // Redirect to login page
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
