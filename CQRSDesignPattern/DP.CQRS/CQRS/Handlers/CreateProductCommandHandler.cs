using DP.CQRS.DAL;
using DP.CQRS.CQRS.Commands;

namespace DP.CQRS.CQRS.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Name = command.Name,
                Stock = command.Stock,
                Price = command.Price,
                Description = command.Description,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}