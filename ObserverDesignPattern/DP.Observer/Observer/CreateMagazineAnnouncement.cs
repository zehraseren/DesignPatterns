using DP.Observer.DAL;

namespace DP.Observer.Observer
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Dergimizin Mart ayı sayısı, 1 Mart'ta tarafınıza ulaştırılacaktır. Bu ayki dergimizin konusu Jüpiter ve Mars gezegenleridir."
            });
            context.SaveChanges();
        }
    }
}
