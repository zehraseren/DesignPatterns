using DP.Decorator.DAL;

namespace DP.Decorator.Decorator
{
    // DesignPattern klasöründe yeniden düzenlenerek yapıldı.
    public class Decorator : INotifier
    {
        Context context = new Context();
        private readonly INotifier _notifier;

        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        virtual public void CreateNotify(Notifier notifier)
        {
            notifier.NotifierCreator = "Admin";
            notifier.NotifierSubject = "Toplantı";
            notifier.NotifierType = "Public";
            notifier.NotifierChannel = "WhatsApp";
            _notifier.CreateNotify(notifier);
        }
    }
}
