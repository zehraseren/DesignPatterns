using DP.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using DP.EntityLayer.Concrete;
using DP.UOW.BusinessLayer.Abstract;

namespace DP.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerViewModel cvm)
        {
            var senderValue = _customerService.TGetByID(cvm.SenderID);
            var receiverValue = _customerService.TGetByID(cvm.ReceiverID);

            senderValue.CustomerBalance -= cvm.Amount;
            receiverValue.CustomerBalance += cvm.Amount;

            List<Customer> modifiedCustomers = new List<Customer>()
            {
                senderValue, receiverValue
            };

            _customerService.TMultiUpdate(modifiedCustomers);
            return View();
        }
    }
}
