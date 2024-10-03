using DP.Facade.DAL;

namespace DP.Facade.Facade
{
    public class ProductStock
    {
        Context context = new Context();

        public void DecreaseStock(int id, int amount)
        {
            var value = context.Products.Find(id);
            value.ProductStock -= amount;
            context.SaveChanges();
        }
    }
}
