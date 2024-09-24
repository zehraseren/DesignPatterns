using DP.CQRS.DAL;
using DP.CQRS.CQRS.Queries;
using DP.CQRS.CQRS.Results;

namespace DP.CQRS.CQRS.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIdQueryResult
            {
                ProductID = values.ProductID,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock
            };
        }
    }
}
