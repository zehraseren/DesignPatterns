using DP.Observer.DAL;

namespace DP.Observer.Observer
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
