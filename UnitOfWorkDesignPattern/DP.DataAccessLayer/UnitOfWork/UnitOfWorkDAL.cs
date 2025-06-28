using DP.UOW.DataAccessLayer.Concrete;

namespace DP.UOW.DataAccessLayer.UnitOfWork
{
    public class UnitOfWorkDAL : IUnitOfWorkDAL
    {
        private readonly Context _context;

        public UnitOfWorkDAL(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
