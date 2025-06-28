using MediatR;
using DP.Mediator.DAL;
using DP.Mediator.Mediator.Queries;
using DP.Mediator.Mediator.Results;
using Microsoft.EntityFrameworkCore;

namespace DP.Mediator.Mediator.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GettAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        async Task<List<GetAllProductQueryResult>> IRequestHandler<GettAllProductQuery, List<GetAllProductQueryResult>>.Handle(GettAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductCategory = x.ProductCategory,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType,
            }).AsNoTracking().ToListAsync();
        }
    }
}
