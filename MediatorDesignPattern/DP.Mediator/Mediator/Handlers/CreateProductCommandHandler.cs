using MediatR;
using DP.Mediator.DAL;
using DP.Mediator.Mediator.Commands;

namespace DP.Mediator.Mediator.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock,
                ProductStockType = request.ProductStockType,
                ProductCategory = request.ProductCategory,
            });
            await _context.SaveChangesAsync();
        }
    }
}
