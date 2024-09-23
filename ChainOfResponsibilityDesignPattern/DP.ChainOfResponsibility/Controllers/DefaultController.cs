using Microsoft.AspNetCore.Mvc;
using DP.ChainOfResponsibility.Models;
using DP.ChainOfResponsibility.ChainOfResponsibility;

namespace DP.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel cpvm)
        {
            Employee treasurer = new Treasurer();
            Employee assistantManager = new AssistantManager();
            Employee manager = new Manager();
            Employee regionalManager = new RegionalManager();

            treasurer.SetNextApprover(assistantManager);
            assistantManager.SetNextApprover(manager);
            manager.SetNextApprover(regionalManager);

            treasurer.ProcessRequest(cpvm);
            return View();
        }
    }
}
