using LibraryManagmentSystem.Application.Services;
using LibraryManagmentSystem.Domain.Entities;
using LibraryManagmentSystem.Domain.Interfaces;
using LibraryManagmentSystem.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Web.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IBookRepository _bookRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly IAuthService _authService;

        public HomeController(
            IUserService userService,
            IBookRepository bookRepository,
            IMemberRepository memberRepository,
            IAuthService authService) // Inject IAuthService
        {
            _userService = userService;
            _bookRepository = bookRepository;
            _memberRepository = memberRepository;
            _authService = authService; // Initialize the auth service
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
                // Call AuthenticateAsync to get the JWT token
                var token = await _authService.AuthenticateAsync(model.UserName, model.Password);

                if (token == null)
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                    return View(model);
                }

                // Set the token in the response if needed
                // For example, storing the token in a cookie or a response header
                Response.Cookies.Append("AuthToken", token, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true, // Set to true if using HTTPS
                    Expires = DateTimeOffset.UtcNow.AddMinutes(60)
                });

                // Assuming user object contains role information
                var user = await _userService.GetUserByUsernameAsync(model.UserName); // Retrieve user info

                if (user.Role == "Admin")
                {
                    return RedirectToAction("AdminDashboard", "Home");
                }
                else if (user.Role == "Member")
                {
                    return RedirectToAction("MemberDashboard", "Home");
                }

                // Default redirection if role is not recognized
                return RedirectToAction("Index");
            }
            catch (UnauthorizedAccessException)
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View(model);
            }
            catch (Exception ex)
            {
                // Log the exception and return a generic error message
                // You might want to log the error here
                ModelState.AddModelError("", "An unexpected error occurred.");
                return View(model);
            }
        }



        public async Task<IActionResult> AdminDashboard()
        {
            var totalBooks = await _bookRepository.GetTotalBooksAsync();
            var totalMembers = await _memberRepository.GetTotalMembersAsync();
            

            var viewModel = new AdminDashboardView
            {
                TotalBooks = totalBooks,
                TotalMembers = totalMembers,
               
            };

            return View(viewModel);
        }

        public IActionResult MemberDashboard()
        {
            return View();
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
