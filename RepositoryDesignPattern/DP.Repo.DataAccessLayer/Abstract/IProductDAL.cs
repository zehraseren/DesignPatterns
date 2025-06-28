using DP.Repo.EntityLayer.Concrete;

namespace DP.Repo.DataAccessLayer.Abstract
{
    public interface IProductDAL : IGenericDAL<Product>
    {
        List<Product> ProductListWithCategory();
    }
}
