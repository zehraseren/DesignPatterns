using DP.CQRS.DAL;
using DP.CQRS.CQRS.Results;
using DP.CQRS.CQRS.Queries;

namespace DP.CQRS.CQRS.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                ProductID = values.ProductID,
                Name = values.Name,
                Stock = values.Stock,
                Price = values.Price,
                Description = values.Description
            };
        }
    }
}
