﻿using DP.Observer.DAL;

namespace DP.Observer.Observer
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Bültenimize kayıt olduğunuz için teşekkür ederiz,dergilerimize websitemizden ulaşabilirsiniz.",
            });
            context.SaveChanges();
        }
    }
}
