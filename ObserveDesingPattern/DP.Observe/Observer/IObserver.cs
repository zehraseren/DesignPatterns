using DP.Observe.DAL;

namespace DP.Observe.Observe
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
