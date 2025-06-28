using DP.Facade.DAL;
using DP.Facade.Facade;
using Microsoft.AspNetCore.Mvc;

namespace DP.Facade.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StartOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StartOrder(int customerId)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult StartOrderDetail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StartOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            OrderFacade orderFacade = new OrderFacade();

            orderFacade.CompleteOrderDetail(customerId, productId, orderId, productCount, productPrice);
            return RedirectToAction("Index");
        }
    }
}
