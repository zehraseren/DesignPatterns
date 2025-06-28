using DP.Repo.EntityLayer.Concrete;

namespace DP.Repo.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TProductListWithCategory();
    }
}
