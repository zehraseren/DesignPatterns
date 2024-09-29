using MediatR;
using Microsoft.AspNetCore.Mvc;
using DP.Mediator.Mediator.Queries;
using DP.Mediator.Mediator.Commands;

namespace DP.Mediator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GettAllProductQuery());
            return View(values);
        }

        public async Task<IActionResult> GetProduct(int id)
        {
            var values = await _mediator.Send(new GetProductByIDQuery(
                id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductCommand cpc)
        {
            await _mediator.Send(cpc);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var values = await _mediator.Send(new GetProductUpdateByIDQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand upc)
        {
            await _mediator.Send(upc);
            return RedirectToAction("Index");
        }
    }
}
