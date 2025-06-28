using DP.Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DP.Facade.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}
