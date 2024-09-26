using DP.EntityLayer.Concrete;
using DP.UOW.DataAccessLayer.Abstract;
using DP.UOW.DataAccessLayer.Concrete;
using DP.UOW.DataAccessLayer.Repositories;

namespace DP.UOW.EntityLayer.EntityFramework
{
    public class EFCustomerDAL : GenericRepository<Customer>, ICustomerDAL
    {
        public EFCustomerDAL(Context context) : base(context)
        {

        }
    }
}
