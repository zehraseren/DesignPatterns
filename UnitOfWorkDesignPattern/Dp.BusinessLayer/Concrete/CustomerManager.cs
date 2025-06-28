using DP.EntityLayer.Concrete;
using DP.UOW.BusinessLayer.Abstract;
using DP.UOW.DataAccessLayer.Abstract;
using DP.UOW.DataAccessLayer.UnitOfWork;

namespace DP.UOW.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDAL _customerDAL;
        private readonly IUnitOfWorkDAL _unitOfWorkDAL;

        public CustomerManager(ICustomerDAL customerDAL, IUnitOfWorkDAL unitOfWorkDAL)
        {
            _customerDAL = customerDAL;
            _unitOfWorkDAL = unitOfWorkDAL;
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDAL.MultiUpdate(t);
            _unitOfWorkDAL.Save();
        }

        public void TDelete(Customer t)
        {
            _customerDAL.Delete(t);
            _unitOfWorkDAL.Save();
        }

        public Customer TGetByID(int id)
        {
            return _customerDAL.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDAL.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDAL.Insert(t);
            _unitOfWorkDAL.Save();
        }

        public void TUpdate(Customer t)
        {
            _customerDAL.Update(t);
            _unitOfWorkDAL.Save();
        }
    }
}
