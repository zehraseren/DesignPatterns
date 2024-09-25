using DP.Observer.DAL;
using DP.Observer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace DP.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel rvm)
        {
            var appUser = new AppUser()
            {
                Name = rvm.Name,
                Surname = rvm.Surname,
                Email = rvm.Email,
                UserName = rvm.Username,
                City = rvm.City,
                District = rvm.District,
            };
            await _userManager.CreateAsync(appUser, rvm.Password);
            return View();
        }
    }
}
