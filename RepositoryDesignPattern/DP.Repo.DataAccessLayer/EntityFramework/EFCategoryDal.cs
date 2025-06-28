using DP.Repo.EntityLayer.Concrete;
using DP.Repo.DataAccessLayer.Abstract;
using DP.Repo.DataAccessLayer.Concrete;
using DP.Repo.DataAccessLayer.Repositories;

namespace DP.Repo.DataAccessLayer.EntityFramework
{
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDAL
    {
        public EFCategoryDal(Context context) : base(context)
        {
        }
    }
}
