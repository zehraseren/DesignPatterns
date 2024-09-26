using DP.Repo.EntityLayer.Concrete;
using DP.Repo.BusinessLayer.Abstract;
using DP.Repo.DataAccessLayer.Abstract;

namespace DP.Repo.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void TDelete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDAL.GetList();
        }

        public void TInsert(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
