using DP.Observer.DAL;
using DP.Observer.Models;
using DP.Observer.Observer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace DP.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
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
                UserName = rvm.Username,
                Email = rvm.Mail,
                City = rvm.City,
                District = rvm.District,
            };
            var result = await _userManager.CreateAsync(appUser, rvm.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
                return View();
            }
            return View();
        }
    }
}
