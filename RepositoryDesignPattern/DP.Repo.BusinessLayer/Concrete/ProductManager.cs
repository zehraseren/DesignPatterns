using DP.Repo.EntityLayer.Concrete;
using DP.Repo.BusinessLayer.Abstract;
using DP.Repo.DataAccessLayer.Abstract;

namespace DP.Repo.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(Product t)
        {
            _productDAL.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _productDAL.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productDAL.GetList();
        }

        public void TInsert(Product t)
        {
            _productDAL.Insert(t);
        }

        public List<Product> TProductListWithCategory()
        {
            return _productDAL.ProductListWithCategory();
        }

        public void TUpdate(Product t)
        {
            _productDAL.Update(t);
        }
    }
}
