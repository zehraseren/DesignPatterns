using DP.CQRS.DAL;
using DP.CQRS.CQRS.Commands;

namespace DP.CQRS.CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Name = command.Name;
            values.Stock = command.Stock;
            values.Price = command.Price;
            values.Description = command.Description;
            values.Status = true;
            _context.SaveChanges();
        }
    }
}
