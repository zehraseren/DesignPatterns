using DP.Repo.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using DP.Repo.DataAccessLayer.Abstract;
using DP.Repo.DataAccessLayer.Concrete;
using DP.Repo.DataAccessLayer.Repositories;

namespace DP.Repo.DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDAL
    {
        private readonly Context _context;
        public EFProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            return _context.Products.Include(x => x.Category).ToList();
        }
    }
}
