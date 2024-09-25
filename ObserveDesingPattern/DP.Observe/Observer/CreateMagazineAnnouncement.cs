using DP.Observe.DAL;

namespace DP.Observe.Observe
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
                Content = "Bilim dergimizin Mart sayısı 1 Mart'ta evinize ulaştırılacaktır. Bu sayımızdaki konular Jupiter ve Mars gezegenleridir."
            });
            context.SaveChanges();
        }
    }
}
